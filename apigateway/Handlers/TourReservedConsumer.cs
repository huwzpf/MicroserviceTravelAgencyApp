using System.Threading.Channels;
using contracts;
using MassTransit;

namespace apigateway.Handlers;

public class TourReservedConsumer : IConsumer<TourReservedEvent>
{
    private readonly ILogger<TourReservedConsumer> _logger;
    private readonly Channel<TourReservedEvent> _channel;

    public TourReservedConsumer(ILogger<TourReservedConsumer> logger, Channel<TourReservedEvent> channel)
    {
        _logger = logger;
        _channel = channel;
    }

    public async Task Consume(ConsumeContext<TourReservedEvent> context)
    {
        var message = context.Message;
        _logger.LogInformation("Handler received an event:\nTour Reserved: HotelId={HotelId}, ReservationId={ReservationId} ToTransportOptionId={ToTransportOptionId}, FromTransportOptionId={FromTransportOptionId}",
            message.HotelId, message.ReservatonId, message.ToTransportOptionId, message.FromTransportOptionId);

        await _channel.Writer.WriteAsync(message);
    }
}