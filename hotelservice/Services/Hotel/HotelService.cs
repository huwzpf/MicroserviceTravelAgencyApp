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
                Name = "G Hotel",
                City = "Berlin",
                Country = "Germany",
                Street = "Sample Street",
                Rooms =  new List<RoomsCount>(),
                FoodPricePerPerson = 20
        });
    }

    public HotelSearchResponse SearchHotels(HotelSearchRequest request)
    {
        return new HotelSearchResponse(new List<HotelDto>
        {
            new HotelDto
            {
                Id = Guid.NewGuid(),
                Name = "G Hotel",
                City = "Gdansk",
                Country = "Poland",
                Street = "Sample Street",
                Rooms = new List<RoomsCount>(),
                FoodPricePerPerson = 20
            },
            new HotelDto
            {
                Id = Guid.NewGuid(),
                Name = "W Hotel",
                City = "Warsaw",
                Country = "Poland",
                Street = "Sample Street",
                Rooms = new List<RoomsCount>(),
                FoodPricePerPerson = 20
            },
            new HotelDto
            {
                Id = Guid.NewGuid(),
                Name = "B Hotel",
                City = "Berlin",
                Country = "Germany",
                Street = "Sample Street",
                Rooms = new List<RoomsCount>(),
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
                Name = "Sample Hotel 1",
                City = "Berlin",
                Country = "Germany",
                Street = "Sample Street",
                Rooms = new List<RoomsCount>(){new RoomsCount{Price = 10, Size = 2, Count = 1}},
                FoodPricePerPerson = 20
            },
            new HotelDto
            {
                Id = Guid.NewGuid(),
                Name = "Sample Hotel 2",
                City = "Berlin",
                Country = "Germany",
                Street = "Sample Street",
                Rooms = new List<RoomsCount>(){new RoomsCount{Price = 10, Size = 2, Count = 1}},
                FoodPricePerPerson = 20
            },
            
            new HotelDto
            {
                Id = Guid.NewGuid(),
                Name = "Sample Hotel 3",
                City = "Paris",
                Country = "France",
                Street = "Sample Street",
                Rooms = new List<RoomsCount>(){new RoomsCount{Price = 10, Size = 2, Count = 1}},
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
            City = "Berlin",
            Country = "Germany",
            Street = "Sample Street",
            Rooms = new List<RoomsCount>(),
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
                NumberOfNights = request.BookingDetails.NumberOfNights
            }
        });
    }

    public HotelGetAvailableRoomsResponse GetAvailableRooms(HotelGetAvailableRoomsRequest request)
    {
        return new HotelGetAvailableRoomsResponse(new RoomAvailabilityDto {StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow.AddDays(1), Rooms = new List<RoomsCount>(){new RoomsCount{Price = 10, Size = 2, Count = 1}}});
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

