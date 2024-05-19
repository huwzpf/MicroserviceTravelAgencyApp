
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class GetTransportOptionRequestConsumer : IConsumer<GetTransportOptionRequest>
{
    private readonly ILogger<GetTransportOptionRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public GetTransportOptionRequestConsumer(ILogger<GetTransportOptionRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<GetTransportOptionRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetTransportOptionRequestConsumer), context.Message);
        var response = await _transportService.GetTransportOption(context.Message);
        await context.RespondAsync(response);
    }
}
