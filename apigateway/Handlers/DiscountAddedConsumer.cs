using System.Threading.Channels;
using contracts;
using MassTransit;

namespace apigateway.Handlers;

public class DiscountAddedConsumer : IConsumer<DiscountAddedEvent>
{
    private readonly ILogger<DiscountAddedConsumer> _logger;
    private readonly Channel<DiscountAddedEvent> _channel;

    public DiscountAddedConsumer(ILogger<DiscountAddedConsumer> logger, Channel<DiscountAddedEvent> channel)
    {
        _logger = logger;
        _channel = channel;
    }

    public async Task Consume(ConsumeContext<DiscountAddedEvent> context)
    {
        var message = context.Message;
        _logger.LogInformation("Handler received an event:\nDscount Added: Id={Id}", message.Id);

        await _channel.Writer.WriteAsync(message);
    }
}