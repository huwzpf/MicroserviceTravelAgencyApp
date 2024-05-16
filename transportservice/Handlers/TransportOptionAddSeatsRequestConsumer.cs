
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class TransportOptionAddSeatsRequestConsumer : IConsumer<TransportOptionAddSeatsRequest>
{
    private readonly ILogger<TransportOptionAddSeatsRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public TransportOptionAddSeatsRequestConsumer(ILogger<TransportOptionAddSeatsRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<TransportOptionAddSeatsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(TransportOptionAddSeatsRequestConsumer), context.Message);
        await context.RespondAsync(_transportService.AddSeats(context.Message));
    }
}
