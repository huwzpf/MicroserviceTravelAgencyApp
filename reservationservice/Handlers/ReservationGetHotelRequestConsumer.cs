using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class ReservationGetHotelRequestConsumer : IConsumer<ReservationGetHotelRequest>
{
    private readonly ILogger<ReservationGetHotelRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public ReservationGetHotelRequestConsumer(ILogger<ReservationGetHotelRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<ReservationGetHotelRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(ReservationGetHotelRequestConsumer), context.Message);
        var response = await _reservationService.ReservationGetHotel(context.Message);
        await context.RespondAsync(response);
    }
}
