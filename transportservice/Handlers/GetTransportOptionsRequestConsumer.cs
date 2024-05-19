
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class GetTransportOptionsRequestConsumer : IConsumer<GetTransportOptionsRequest>
{
    private readonly ILogger<GetTransportOptionsRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public GetTransportOptionsRequestConsumer(ILogger<GetTransportOptionsRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<GetTransportOptionsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetTransportOptionsRequestConsumer), context.Message);
        var response = await _transportService.GetTransportOptions(context.Message);
        await context.RespondAsync(response);
    }
}
