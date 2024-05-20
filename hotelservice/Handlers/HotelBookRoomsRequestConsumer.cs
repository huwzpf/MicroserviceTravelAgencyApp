
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class HotelBookRoomsRequestConsumer : IConsumer<HotelBookRoomsRequest>
{
    private readonly ILogger<HotelBookRoomsRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public HotelBookRoomsRequestConsumer(ILogger<HotelBookRoomsRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<HotelBookRoomsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(HotelBookRoomsRequestConsumer), context.Message);
        var response = await _hotelService.BookRooms(context.Message);
        await context.RespondAsync(response);
    }
}
