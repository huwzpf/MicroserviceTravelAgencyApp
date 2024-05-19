using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class CreateReservationRequestConsumer : IConsumer<CreateReservationRequest>
{
    private readonly ILogger<CreateReservationRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public CreateReservationRequestConsumer(ILogger<CreateReservationRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<CreateReservationRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(CreateReservationRequestConsumer), context.Message);
        var response = await _reservationService.CreateReservation(context.Message);
        await context.RespondAsync(response);
    }
}
