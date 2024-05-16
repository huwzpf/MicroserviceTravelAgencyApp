using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class GetPopularOffersRequestConsumer : IConsumer<GetPopularOffersRequest>
{
    private readonly ILogger<GetPopularOffersRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public GetPopularOffersRequestConsumer(ILogger<GetPopularOffersRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<GetPopularOffersRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetPopularOffersRequestConsumer), context.Message);
        await context.RespondAsync(_reservationService.GetPopularOffers(context.Message));
    }
}
