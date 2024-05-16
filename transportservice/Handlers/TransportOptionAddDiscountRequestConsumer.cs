
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class TransportOptionAddDiscountRequestConsumer : IConsumer<TransportOptionAddDiscountRequest>
{
    private readonly ILogger<TransportOptionAddDiscountRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public TransportOptionAddDiscountRequestConsumer(ILogger<TransportOptionAddDiscountRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<TransportOptionAddDiscountRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(TransportOptionAddDiscountRequestConsumer), context.Message);
        await context.RespondAsync(_transportService.AddDiscount(context.Message));
    }
}
