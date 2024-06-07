// WebSocketController.cs
using System.Net.WebSockets;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Channels;
using contracts;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace apigateway.Controllers;

public interface ISubscription<T>
{
    bool Matches(T @event);
}

public class TourReservedEventSubscription : ISubscription<TourReservedEvent>
{
    public Guid? HotelId { get; set; }
    public Guid? ToTransportOptionId { get; set; }
    public Guid? FromTransportOptionId { get; set; }

    public bool Matches(TourReservedEvent @event)
    {
        return !HotelId.HasValue || (@event.HotelId == HotelId &&
               (!ToTransportOptionId.HasValue || @event.ToTransportOptionId == ToTransportOptionId) &&
               (!FromTransportOptionId.HasValue || @event.FromTransportOptionId == FromTransportOptionId));
    }
}

public class DiscountAddedEventSubscription : ISubscription<DiscountAddedEvent>
{
    public Guid? Id { get; set; }

    public bool Matches(DiscountAddedEvent @event)
    {
        return !Id.HasValue || @event.Id == Id;
    }
}

[ApiExplorerSettings(IgnoreApi = true)]
public class WebSocketController : ControllerBase
{
    private readonly Channel<TourReservedEvent> _tourChannel;
    private readonly Channel<DiscountAddedEvent> _discountChannel;
    private readonly ILogger<WebSocketController> _logger;

    public WebSocketController(Channel<TourReservedEvent> tourChannel, Channel<DiscountAddedEvent> discountChannel, ILogger<WebSocketController> logger)
    {
        _tourChannel = tourChannel;
        _discountChannel = discountChannel;
        _logger = logger;
    }

    [Route("/ws/tours")]
    public async Task GetTourWs(CancellationToken cancellationToken)
    {
        if (HttpContext.WebSockets.IsWebSocketRequest)
        {
            var subscription = ExtractTourSubscriptionFromQuery(HttpContext.Request.Query);

            await HandleWebSocketConnection(subscription, cancellationToken);
        }
        else
        {
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
    }

    [Route("/ws/discounts")]
    public async Task GetDiscountWs(CancellationToken cancellationToken)
    {
        if (HttpContext.WebSockets.IsWebSocketRequest)
        {
            var subscription = ExtractDiscountSubscriptionFromQuery(HttpContext.Request.Query);

            await HandleWebSocketConnection(subscription, cancellationToken);
        }
        else
        {
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
    }

    private TourReservedEventSubscription ExtractTourSubscriptionFromQuery(IQueryCollection query)
    {
        return new TourReservedEventSubscription
        {
            HotelId = query.ContainsKey("hotelId") ? Guid.Parse(query["hotelId"]) : (Guid?)null,
            ToTransportOptionId = query.ContainsKey("toTransportOptionId") ? Guid.Parse(query["toTransportOptionId"]) : (Guid?)null,
            FromTransportOptionId = query.ContainsKey("fromTransportOptionId") ? Guid.Parse(query["fromTransportOptionId"]) : (Guid?)null
        };
    }

    private DiscountAddedEventSubscription ExtractDiscountSubscriptionFromQuery(IQueryCollection query)
    {
        return new DiscountAddedEventSubscription
        {
            Id = query.ContainsKey("Id") ? Guid.Parse(query["Id"]) : (Guid?)null
        };
    }

    private async Task HandleWebSocketConnection<T>(ISubscription<T> subscription, CancellationToken cancellationToken) where T : class
    {
        using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
        
        try
        {
            await BroadcastService<T>.AddClientAsync(webSocket, subscription, cancellationToken);

            while (webSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
            {
                await Task.Delay(Timeout.Infinite, cancellationToken);
            }
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation("WebSocket connection was cancelled.");
        }
        finally
        {
            BroadcastService<T>.RemoveClient(webSocket);

            if (webSocket.State == WebSocketState.Open || webSocket.State == WebSocketState.CloseReceived)
            {
                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
            }
        }
    }

    public class BroadcastService<T> : BackgroundService where T : class
    {
        private readonly Channel<T> _channel;
        private readonly ILogger<BroadcastService<T>> _logger;
        private static readonly ConcurrentDictionary<WebSocket, ISubscription<T>> _subscriptions = new ConcurrentDictionary<WebSocket, ISubscription<T>>();

        public BroadcastService(Channel<T> channel, ILogger<BroadcastService<T>> logger)
        {
            _channel = channel;
            _logger = logger;
        }

        public static Task AddClientAsync(WebSocket webSocket, ISubscription<T> subscription, CancellationToken cancellationToken)
        {
            _subscriptions.TryAdd(webSocket, subscription);
            return Task.CompletedTask;
        }

        public static void RemoveClient(WebSocket webSocket)
        {
            _subscriptions.TryRemove(webSocket, out _);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var incomingEvent = await _channel.Reader.ReadAsync(stoppingToken);
                    await BroadcastNotification(incomingEvent, stoppingToken);
                }
                catch (OperationCanceledException)
                {
                    _logger.LogInformation("Broadcasting operation was cancelled.");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred while broadcasting.");
                }
            }
        }

        private async Task BroadcastNotification(T reservedEvent, CancellationToken cancellationToken)
        {
            var message = JsonSerializer.Serialize(reservedEvent);
            var buffer = Encoding.UTF8.GetBytes(message);
            var segment = new ArraySegment<byte>(buffer);

            foreach (var (socket, subscription) in _subscriptions)
            {
                if (socket.State == WebSocketState.Open && subscription.Matches(reservedEvent))
                {
                    await socket.SendAsync(segment, WebSocketMessageType.Text, true, cancellationToken);
                    _logger.LogInformation("Sent: " + message);
                }
            }
        }
    }
}

