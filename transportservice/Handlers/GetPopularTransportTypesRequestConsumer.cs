using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class GetPopularTransportTypesRequestConsumer:  IConsumer<GetPopularTransportTypesRequest>
{
    private readonly ILogger<GetPopularTransportTypesRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public GetPopularTransportTypesRequestConsumer(ILogger<GetPopularTransportTypesRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<GetPopularTransportTypesRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetPopularTransportTypesRequest), context.Message);
        var response = await _transportService.GetPopularTransportTypes(context.Message);
        await context.RespondAsync(response);
    }
}
