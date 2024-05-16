using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using apigateway.Dtos.Common;
using apigateway.Dtos.Hotels;
using contracts;
using contracts.Dtos;
using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class HotelsController : ControllerBase
{
    private readonly ILogger<HotelsController> _logger;
    private readonly IRequestClient<ReservationGetHotelsRequest> _getHotelsClient;
    private readonly IRequestClient<ReservationGetHotelRequest> _getHotelClient;
    private readonly IRequestClient<GetAvailableRoomsRequest> _getAvailableRoomsClient;
    private readonly IRequestClient<AddHotelRequest> _addHotelClient;
    private readonly IRequestClient<HotelAddDiscountRequest> _addHotelDiscountClient;

    public HotelsController(
        ILogger<HotelsController> logger,
        IRequestClient<ReservationGetHotelsRequest> getHotelsClient,
        IRequestClient<ReservationGetHotelRequest> getHotelClient,
        IRequestClient<GetAvailableRoomsRequest> getAvailableRoomsClient,
        IRequestClient<AddHotelRequest> addHotelClient,
        IRequestClient<HotelAddDiscountRequest> addHotelDiscountClient)
    {
        _logger = logger;
        _getHotelsClient = getHotelsClient;
        _getHotelClient = getHotelClient;
        _getAvailableRoomsClient = getAvailableRoomsClient;
        _addHotelClient = addHotelClient;
        _addHotelDiscountClient = addHotelDiscountClient;
    }
    
    [HttpGet(Name = "GetHotels")]
    public async Task<ActionResult<IEnumerable<Hotel>>> Get()
    {
        var response = await _getHotelsClient.GetResponse<ReservationGetHotelsResponse>(new ReservationGetHotelsRequest());
        return Ok(response.Message.Hotels);
    }
    
    [Authorize("RequireAdmin")]
    [HttpPost(Name = "PostHotel")]
    public async Task<ActionResult<Hotel>> Post(HotelCreate hotelCreate)
    {
        var hotelDto = new HotelDto
        {
            Id = Guid.NewGuid(),
            Name = hotelCreate.Name,
            Address = new AddressDto
            {
                City = hotelCreate.City,
                Country = hotelCreate.Country,
                Street = hotelCreate.Street
            },
            Rooms = new Dictionary<int, Tuple<decimal, int>>(),
            Bookings = new List<RoomReservationDto>(),
            Discounts = new List<DiscountDto>(),
            FoodPricePerPerson = hotelCreate.FoodPricePerPerson
        };

        foreach (var room in hotelCreate.Rooms)
        {
            hotelDto.Rooms.Add(room.Size, new Tuple<decimal, int>(room.Price, room.Count));
        }

        var response = await _addHotelClient.GetResponse<AddHotelResponse>(new AddHotelRequest(hotelDto));
        return Ok(response.Message.Hotel);
    }
    
    [HttpGet("{id}", Name = "GetHotel")]
    public async Task<ActionResult<Hotel>> Get(Guid id, DateTime? fromTimeStamp)
    {
        var response = await _getHotelClient.GetResponse<ReservationGetHotelResponse>(new ReservationGetHotelRequest(id));
        return Ok(response.Message.Hotel);
    }
    
    [HttpGet("{id}/RoomsAvailability", Name = "GetHotelRoomsAvailability")]
    public async Task<ActionResult<HotelRoomAvailability>> GetRoomsAvailability(Guid id)
    {
        var response = await _getAvailableRoomsClient.GetResponse<GetAvailableRoomsResponse>(new GetAvailableRoomsRequest(id, DateTime.UtcNow, DateTime.UtcNow.AddDays(1)));
        return Ok(response.Message.Rooms);
    }
    
    [Authorize("RequireAdmin")]
    [HttpPost("{id}/Discount", Name = "PostHotelDiscount")]
    public async Task<IActionResult> PostHotelDiscount(Guid id, HotelDiscount hotelDiscount)
    {
        var discountDto = new DiscountDto
        {
            Value = hotelDiscount.Percentage,
            Start = hotelDiscount.Start,
            End = hotelDiscount.End
        };

        await _addHotelDiscountClient.GetResponse<HotelAddDiscountResponse>(new HotelAddDiscountRequest(id, discountDto));
        return Ok();
    }
}
