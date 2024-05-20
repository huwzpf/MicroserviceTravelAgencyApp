
using contracts;
using MassTransit;
using transportservice.Services.Transport;

namespace transportservice.Handlers;

public class GetPopularDestinationsRequestConsumer : IConsumer<GetPopularDestinationsRequest>
{
    private readonly ILogger<GetPopularDestinationsRequestConsumer> _logger;
    private readonly TransportService _transportService;
    public GetPopularDestinationsRequestConsumer(ILogger<GetPopularDestinationsRequestConsumer> logger, TransportService transportService)
    {
        _logger = logger;
        _transportService = transportService;
    }
    
    public async Task Consume(ConsumeContext<GetPopularDestinationsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetPopularDestinationsRequest), context.Message);
        var response = await _transportService.GetPopularDestinations(context.Message);
        await context.RespondAsync(response);
    }
}
