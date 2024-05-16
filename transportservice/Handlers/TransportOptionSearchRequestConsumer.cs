
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class TransportOptionSearchRequestConsumer : IConsumer<TransportOptionSearchRequest>
{
    private readonly ILogger<TransportOptionSearchRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public TransportOptionSearchRequestConsumer(ILogger<TransportOptionSearchRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<TransportOptionSearchRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(TransportOptionSearchRequestConsumer), context.Message);
        await context.RespondAsync(_transportService.SearchTransportOptions(context.Message));
    }
}
