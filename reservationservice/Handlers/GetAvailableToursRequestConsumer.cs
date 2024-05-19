using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class GetAvailableToursRequestConsumer : IConsumer<GetAvailableToursRequest>
{
    private readonly ILogger<GetAvailableToursRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public GetAvailableToursRequestConsumer(ILogger<GetAvailableToursRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<GetAvailableToursRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetAvailableToursRequestConsumer), context.Message);
        var response = await _reservationService.GetAvailableTours(context.Message);
        await context.RespondAsync(response);
    }
}
