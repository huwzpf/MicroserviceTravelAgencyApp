
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class GetTransportOptionWhenRequestConsumer : IConsumer<GetTransportOptionWhenRequest>
{
    private readonly ILogger<GetTransportOptionWhenRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public GetTransportOptionWhenRequestConsumer(ILogger<GetTransportOptionWhenRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<GetTransportOptionWhenRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetTransportOptionWhenRequestConsumer), context.Message);
        await context.RespondAsync(_transportService.GetTransportOptionWhen(context.Message));
    }
}
