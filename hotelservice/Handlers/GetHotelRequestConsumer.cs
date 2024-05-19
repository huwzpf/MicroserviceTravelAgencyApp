
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class GetHotelRequestConsumer : IConsumer<GetHotelRequest>
{
    private readonly ILogger<GetHotelRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public GetHotelRequestConsumer(ILogger<GetHotelRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<GetHotelRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetHotelRequestConsumer), context.Message);
        var response = await _hotelService.GetHotel(context.Message);
        await context.RespondAsync(response);
    }
}
