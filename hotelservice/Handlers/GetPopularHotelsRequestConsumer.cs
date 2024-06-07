using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class GetPopularHotelsRequestConsumer : IConsumer<GetPopularHotelsRequest>
{
    private readonly ILogger<GetPopularHotelsRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public GetPopularHotelsRequestConsumer(ILogger<GetPopularHotelsRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<GetPopularHotelsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetPopularHotelsRequestConsumer), context.Message);
        var response = await _hotelService.GetPopularHotels(context.Message);
        await context.RespondAsync(response);
    }
}
