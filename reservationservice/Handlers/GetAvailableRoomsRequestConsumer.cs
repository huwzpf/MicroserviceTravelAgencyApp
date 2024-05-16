using contracts;
using MassTransit;
using reservationservice.Services.Reservation;

namespace reservationservice.Handlers;

public class GetAvailableRoomsRequestConsumer : IConsumer<GetAvailableRoomsRequest>
{
    private readonly ILogger<GetAvailableRoomsRequestConsumer> _logger;
    private readonly ReservationService _reservationService;
    public GetAvailableRoomsRequestConsumer(ILogger<GetAvailableRoomsRequestConsumer> logger, ReservationService reservationService)
    {
        _logger = logger;
        _reservationService = reservationService;
    }
    
    public async Task Consume(ConsumeContext<GetAvailableRoomsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetAvailableRoomsRequestConsumer), context.Message);
        var response = await _reservationService.GetAvailableRooms(context.Message);
        await context.RespondAsync(response);
    }
}
