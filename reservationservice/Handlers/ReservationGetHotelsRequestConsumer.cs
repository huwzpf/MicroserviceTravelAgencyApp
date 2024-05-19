using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class ReservationGetHotelsRequestConsumer : IConsumer<ReservationGetHotelsRequest>
{
    private readonly ILogger<ReservationGetHotelsRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public ReservationGetHotelsRequestConsumer(ILogger<ReservationGetHotelsRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<ReservationGetHotelsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(ReservationGetHotelsRequestConsumer), context.Message);
        var response = await _reservationService.ReservationGetHotels();
        await context.RespondAsync(response);
    }
}
