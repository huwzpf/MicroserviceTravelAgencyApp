using hotelservice.Persistence;
using contracts;
using contracts.Dtos;


namespace hotelservice.Services.Hotel;

public class HotelService
{
    private readonly HotelDbContext _dbContext;

    public HotelService(HotelDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public AddHotelResponse AddHotel(AddHotelRequest request)
    {
        return new AddHotelResponse(new HotelDto
        {
            Id = Guid.NewGuid(),
            Name = request.Hotel.Name,
            Address = request.Hotel.Address,
            Rooms = request.Hotel.Rooms,
            Bookings = new List<RoomReservationDto>(),
            Discounts = new List<DiscountDto>(),
            FoodPricePerPerson = request.Hotel.FoodPricePerPerson
        });
    }

    public HotelSearchResponse SearchHotels(HotelSearchRequest request)
    {
        return new HotelSearchResponse(new List<HotelDto>
        {
            new HotelDto
            {
                Id = Guid.NewGuid(),
                Name = "Sample Hotel",
                Address = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
                Rooms = new Dictionary<int, Tuple<decimal, int>> { { 2, new Tuple<decimal, int>(100, 5) } },
                Bookings = new List<RoomReservationDto>(),
                Discounts = new List<DiscountDto>(),
                FoodPricePerPerson = 20
            }
        });
    }

    public GetHotelsResponse GetHotels(GetHotelsRequest request)
    {
        return new GetHotelsResponse(new List<HotelDto>
        {
            new HotelDto
            {
                Id = Guid.NewGuid(),
                Name = "Sample Hotel",
                Address = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
                Rooms = new Dictionary<int, Tuple<decimal, int>> { { 2, new Tuple<decimal, int>(100, 5) } },
                Bookings = new List<RoomReservationDto>(),
                Discounts = new List<DiscountDto>(),
                FoodPricePerPerson = 20
            }
        });
    }

    public GetHotelResponse GetHotel(GetHotelRequest request)
    {
        return new GetHotelResponse(new HotelDto
        {
            Id = request.Id,
            Name = "Sample Hotel",
            Address = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
            Rooms = new Dictionary<int, Tuple<decimal, int>> { { 2, new Tuple<decimal, int>(100, 5) } },
            Bookings = new List<RoomReservationDto>(),
            Discounts = new List<DiscountDto>(),
            FoodPricePerPerson = 20
        });
    }

    public HotelBookRoomsResponse BookRooms(HotelBookRoomsRequest request)
    {
        return new HotelBookRoomsResponse(new List<RoomReservationDto>
        {
            new RoomReservationDto
            {
                Id = Guid.NewGuid(),
                Size = 2,
                Start = request.BookingDetails.Start,
                End = request.BookingDetails.End
            }
        });
    }

    public HotelGetAvailableRoomsResponse GetAvailableRooms(HotelGetAvailableRoomsRequest request)
    {
        return new HotelGetAvailableRoomsResponse(new Dictionary<int, int>
        {
            { 2, 5 },
            { 3, 3 }
        });
    }

    public HotelAddDiscountResponse AddDiscount(HotelAddDiscountRequest request)
    {
        return new HotelAddDiscountResponse();
    }

    public HotelCancelBookRoomsResponse CancelBookRooms(HotelCancelBookRoomsRequest request)
    {
        return new HotelCancelBookRoomsResponse();
    }
    
}

