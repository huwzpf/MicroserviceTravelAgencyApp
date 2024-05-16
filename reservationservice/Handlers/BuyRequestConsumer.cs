using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class BuyRequestConsumer : IConsumer<BuyRequest>
{
    private readonly ILogger<BuyRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public BuyRequestConsumer(ILogger<BuyRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<BuyRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(BuyRequestConsumer), context.Message);
        await context.RespondAsync(_reservationService.Buy(context.Message));
    }
}
