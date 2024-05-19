using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class GetReservationsRequestConsumer : IConsumer<GetReservationsRequest>
{
    private readonly ILogger<GetReservationsRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public GetReservationsRequestConsumer(ILogger<GetReservationsRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<GetReservationsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetReservationsRequestConsumer), context.Message);
        var response = await _reservationService.GetReservations(context.Message);
        await context.RespondAsync(response);
    }
}
