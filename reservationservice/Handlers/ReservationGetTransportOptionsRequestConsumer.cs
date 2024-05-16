using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class ReservationGetTransportOptionsRequestConsumer : IConsumer<ReservationGetTransportOptionsRequest>
{
    private readonly ILogger<ReservationGetTransportOptionsRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public ReservationGetTransportOptionsRequestConsumer(ILogger<ReservationGetTransportOptionsRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<ReservationGetTransportOptionsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(ReservationGetTransportOptionsRequestConsumer), context.Message);
        var response = await _reservationService.ReservationGetTransportOptions(context.Message);
        await context.RespondAsync(response);
    }
}
