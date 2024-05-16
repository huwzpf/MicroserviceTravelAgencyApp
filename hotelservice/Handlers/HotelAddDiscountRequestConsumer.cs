
using contracts;
using MassTransit;
using hotelservice.Services.Hotel;

namespace hotelservice.Handlers;

public class HotelAddDiscountRequestConsumer : IConsumer<HotelAddDiscountRequest>
{
    private readonly ILogger<HotelAddDiscountRequestConsumer> _logger;
    private readonly HotelService _hotelService;
    public HotelAddDiscountRequestConsumer(ILogger<HotelAddDiscountRequestConsumer> logger, HotelService hotelService)
    {
        _logger = logger;
        _hotelService = hotelService;
    }
    
    public async Task Consume(ConsumeContext<HotelAddDiscountRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(HotelAddDiscountRequestConsumer), context.Message);
        await context.RespondAsync(_hotelService.AddDiscount(context.Message));
    }
}
