using apigateway.Dtos.Common;
using apigateway.Dtos.Hotels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class HotelsController : ControllerBase
{
    private readonly ILogger<HotelsController> _logger;

    public HotelsController(ILogger<HotelsController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetHotels")]
    public IEnumerable<Hotel> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Hotel()
            {
                
            })
            .ToArray();
    }
    
    [Authorize("RequireAdmin")]
    [HttpPost(Name = "PostHotel")]
    public Hotel Post(HotelCreate hotelCreate)
    {
        return new Hotel()
        {

        };
    }
    
    [HttpGet("{id}", Name = "GetHotel")]
    public Hotel Get(Guid id, DateTime? fromTimeStamp)
    {
        return new Hotel()
        {

        };
    }
    
    [HttpGet("{id}/RoomsAvailability", Name = "GetHotelRoomsAvailability")]
    public HotelRoomAvailability GetRoomsAvailability(Guid id)
    {
        return new HotelRoomAvailability()
        {

        };
    }
    
    [Authorize("RequireAdmin")]
    [HttpPost("{id}/Discount", Name = "PostHotelDiscount")]
    public void PostHotelDiscount(Guid id, HotelDiscount hotelDiscount)
    {
        
    }
}