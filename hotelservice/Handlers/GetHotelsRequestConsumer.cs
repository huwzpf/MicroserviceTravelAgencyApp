
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class GetHotelsRequestConsumer : IConsumer<GetHotelsRequest>
{
    private readonly ILogger<GetHotelsRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public GetHotelsRequestConsumer(ILogger<GetHotelsRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<GetHotelsRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(GetHotelsRequestConsumer), context.Message);
        var response = await _hotelService.GetHotels(context.Message);
        await context.RespondAsync(response);
    }
}
