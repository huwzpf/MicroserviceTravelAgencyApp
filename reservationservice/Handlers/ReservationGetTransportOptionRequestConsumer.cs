using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class ReservationGetTransportOptionRequestConsumer : IConsumer<ReservationGetTransportOptionRequest>
{
    private readonly ILogger<ReservationGetTransportOptionRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public ReservationGetTransportOptionRequestConsumer(ILogger<ReservationGetTransportOptionRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<ReservationGetTransportOptionRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(ReservationGetTransportOptionRequestConsumer), context.Message);
        var response = await _reservationService.ReservationGetTransportOption(context.Message);
        await context.RespondAsync(response);
    }
}
