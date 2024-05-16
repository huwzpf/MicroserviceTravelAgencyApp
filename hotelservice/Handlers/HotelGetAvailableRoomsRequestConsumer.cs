
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class HotelGetAvailableRoomsRequestConsumer : IConsumer<HotelGetAvailableRoomsRequest>
{
    private readonly ILogger<HotelGetAvailableRoomsRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public HotelGetAvailableRoomsRequestConsumer(ILogger<HotelGetAvailableRoomsRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<HotelGetAvailableRoomsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(HotelGetAvailableRoomsRequestConsumer), context.Message);
        await context.RespondAsync(_hotelService.GetAvailableRooms(context.Message));
    }
}
