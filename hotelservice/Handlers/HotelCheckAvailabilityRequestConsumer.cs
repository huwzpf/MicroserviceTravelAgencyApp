
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class HotelCheckAvailabilityRequestConsumer : IConsumer<HotelCheckAvailabilityRequest>
{
    private readonly ILogger<HotelCheckAvailabilityRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public HotelCheckAvailabilityRequestConsumer(ILogger<HotelCheckAvailabilityRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<HotelCheckAvailabilityRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(HotelCheckAvailabilityRequestConsumer), context.Message);
        var response = await _hotelService.CheckHotelAvailability(context.Message);
        await context.RespondAsync(response);
    }
}
