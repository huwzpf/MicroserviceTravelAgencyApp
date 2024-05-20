
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class HotelCancelBookRoomsRequestConsumer : IConsumer<HotelCancelBookRoomsRequest>
{
    private readonly ILogger<HotelCancelBookRoomsRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public HotelCancelBookRoomsRequestConsumer(ILogger<HotelCancelBookRoomsRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<HotelCancelBookRoomsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(HotelCancelBookRoomsRequestConsumer), context.Message);
        var response = await _hotelService.CancelBookRooms(context.Message);
        await context.RespondAsync(response);
    }
}
