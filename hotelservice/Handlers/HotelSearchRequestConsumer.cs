
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class HotelSearchRequestConsumer : IConsumer<HotelSearchRequest>
{
    private readonly ILogger<HotelSearchRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public HotelSearchRequestConsumer(ILogger<HotelSearchRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<HotelSearchRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(HotelSearchRequestConsumer), context.Message);
        var response = await _hotelService.SearchHotels(context.Message);
        await context.RespondAsync(response);
    }
}
