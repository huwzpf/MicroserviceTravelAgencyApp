
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class AddTransportOptionRequestConsumer : IConsumer<AddTransportOptionRequest>
{
    private readonly ILogger<AddTransportOptionRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public AddTransportOptionRequestConsumer(ILogger<AddTransportOptionRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<AddTransportOptionRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(AddTransportOptionRequestConsumer), context.Message);
        var response = await _transportService.AddTransportOption(context.Message);
        await context.RespondAsync(response);
    }
}
