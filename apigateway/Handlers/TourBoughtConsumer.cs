using System.Threading.Channels;
using contracts;
using MassTransit;

namespace apigateway.Handlers;

public class TourBoughtConsumer : IConsumer<TourBoughtEvent>
{
    private readonly ILogger<TourBoughtConsumer> _logger;
    private readonly Channel<TourBoughtEvent> _channel;

    public TourBoughtConsumer(ILogger<TourBoughtConsumer> logger, Channel<TourBoughtEvent> channel)
    {
        _logger = logger;
        _channel = channel;
    }

    public async Task Consume(ConsumeContext<TourBoughtEvent> context)
    {
        var message = context.Message;
        _logger.LogInformation("Handler received an event:\nTour Reserved: HotelId={HotelId}, ReservationId={ReservationId} ToTransportOptionId={ToTransportOptionId}, FromTransportOptionId={FromTransportOptionId}",
            message.HotelId, message.ReservatonId, message.ToTransportOptionId, message.FromTransportOptionId);

        await _channel.Writer.WriteAsync(message);
    }
}