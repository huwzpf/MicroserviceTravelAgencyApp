
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class GetPopularTransportDestinationsRequestConsumer : IConsumer<GetPopularTransportDestinationsRequest>
{
    private readonly ILogger<GetPopularTransportDestinationsRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public GetPopularTransportDestinationsRequestConsumer(ILogger<GetPopularTransportDestinationsRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<GetPopularTransportDestinationsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetPopularTransportDestinationsRequest), context.Message);
        var response = await _transportService.GetPopularTransportDestinations(context.Message);
        await context.RespondAsync(response);
    }
}
