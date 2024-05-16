
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class TransportOptionSubtractSeatsRequestConsumer : IConsumer<TransportOptionSubtractSeatsRequest>
{
    private readonly ILogger<TransportOptionSubtractSeatsRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public TransportOptionSubtractSeatsRequestConsumer(ILogger<TransportOptionSubtractSeatsRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<TransportOptionSubtractSeatsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(TransportOptionSubtractSeatsRequestConsumer), context.Message);
        await context.RespondAsync(_transportService.SubtractSeats(context.Message));
    }
}
