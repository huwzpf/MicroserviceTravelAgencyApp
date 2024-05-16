using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class GetSingleReservationRequestConsumer : IConsumer<GetSingleReservationRequest>
{
    private readonly ILogger<GetSingleReservationRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public GetSingleReservationRequestConsumer(ILogger<GetSingleReservationRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<GetSingleReservationRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetSingleReservationRequestConsumer), context.Message);
        await context.RespondAsync(_reservationService.GetSingleReservation(context.Message));
    }
}
