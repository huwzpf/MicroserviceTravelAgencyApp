using contracts;
using contracts.Dtos;
using hotelservice.Models;
using Microsoft.EntityFrameworkCore;


namespace hotelservice.Services.Hotel;

public class HotelService
{
    private readonly HotelDbContext _dbContext;

    public HotelService(HotelDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<AddHotelResponse> AddHotel(AddHotelRequest request)
    {
        var hotel = new Models.Hotel
        {
            Id = Guid.NewGuid(),
            Name = request.Hotel.Name,
            City = request.Hotel.City,
            Country = request.Hotel.Country,
            Street = request.Hotel.Street,
            FoodPricePerPerson = request.Hotel.FoodPricePerPerson,
            Discounts = new List<Discount>(),
        };
        
        var Rooms = request.Hotel.Rooms.Select(rc => new Room
        {
            Id = Guid.NewGuid(),
            HotelId = hotel.Id,
            Size = rc.Size,
            Price = rc.Price,
            Count = rc.Count,
            Bookings = new List<RoomReservation>()
        }).ToList();


        hotel.Rooms = Rooms;

        await _dbContext.Hotels.AddAsync(hotel);
        await _dbContext.SaveChangesAsync();

        return new AddHotelResponse(hotel.ToDto());
    }

    public async Task<HotelSearchResponse> SearchHotels(HotelSearchRequest request)
    {
        var searchCriteria = request.SearchCriteria;
        var hotelsQuery = _dbContext.Hotels
            .Include(h => h.Discounts)
            .Include(h => h.Rooms)
                .ThenInclude(r => r.Bookings)
            .AsQueryable();

        if (!string.IsNullOrEmpty(searchCriteria.City))
        {
            hotelsQuery = hotelsQuery.Where(h => h.City == searchCriteria.City);
        }

        if (!string.IsNullOrEmpty(searchCriteria.Country))
        {
            hotelsQuery = hotelsQuery.Where(h => h.Country == searchCriteria.Country);
        }

        if (searchCriteria.MinimumGuests.HasValue)
        {
            hotelsQuery = hotelsQuery.Where(h =>
                h.Rooms.Sum(r => r.Count * r.Size) >= searchCriteria.MinimumGuests.Value);
        }

        if (searchCriteria.MinStart.HasValue || searchCriteria.MaxEnd.HasValue)
        {
            hotelsQuery = hotelsQuery.Where(h =>
                h.Rooms.Any(r =>
                    r.Bookings.Any(b =>
                        (!searchCriteria.MinStart.HasValue || b.Start >= searchCriteria.MinStart.Value) &&
                        (!searchCriteria.MaxEnd.HasValue || b.End <= searchCriteria.MaxEnd.Value))));
        }

        if (searchCriteria.MinDuration.HasValue || searchCriteria.MaxDuration.HasValue)
        {
            hotelsQuery = hotelsQuery.Where(h =>
                h.Rooms.Any(r =>
                    r.Bookings.Any(b =>
                        (!searchCriteria.MinDuration.HasValue || EF.Functions.DateDiffDay(b.Start, b.End) >= searchCriteria.MinDuration.Value) &&
                        (!searchCriteria.MaxDuration.HasValue || EF.Functions.DateDiffDay(b.Start, b.End) <= searchCriteria.MaxDuration.Value))));
        }

        var hotels = await hotelsQuery.ToListAsync();
        var hotelsDto = hotels.Select(hotel => hotel.ToDto()).ToList();

        return new HotelSearchResponse(hotelsDto);
    }

    public async Task<GetHotelsResponse> GetHotels(GetHotelsRequest request)
    {
        var hotels = await _dbContext.Hotels
            .Include(h => h.Discounts)
            .Include(h => h.Rooms)
            .ThenInclude(r => r.Bookings)
            .ToListAsync();
        
        var hotelsDto = hotels.Select(hotel => hotel.ToDto()).ToList();

        return new GetHotelsResponse(hotelsDto);
    }

    public async Task<GetHotelResponse> GetHotel(GetHotelRequest request)
    {
        var hotel = await _dbContext.Hotels
            .Include(h => h.Discounts)
            .Include(h => h.Rooms)
            .ThenInclude(r => r.Bookings)
            .FirstOrDefaultAsync(h => h.Id == request.Id);

        if (hotel == null)
        {
            return null;
        }

        var hotelDto = hotel.ToDto();

        return new GetHotelResponse(hotelDto);
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

