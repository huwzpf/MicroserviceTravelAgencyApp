using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class GetAvailableDestinationsRequestConsumer : IConsumer<GetAvailableDestinationsRequest>
{
    private readonly ILogger<GetAvailableDestinationsRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public GetAvailableDestinationsRequestConsumer(ILogger<GetAvailableDestinationsRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<GetAvailableDestinationsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetAvailableDestinationsRequestConsumer), context.Message);
        var response = await _reservationService.GetAvailableDestinations();
        await context.RespondAsync(response);
    }
}
