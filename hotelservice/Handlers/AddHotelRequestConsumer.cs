
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class AddHotelRequestConsumer : IConsumer<AddHotelRequest>
{
    private readonly ILogger<AddHotelRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public AddHotelRequestConsumer(ILogger<AddHotelRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<AddHotelRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(AddHotelRequestConsumer), context.Message);
        var response = await _hotelService.AddHotel(context.Message);
        await context.RespondAsync(response);
    }
}
