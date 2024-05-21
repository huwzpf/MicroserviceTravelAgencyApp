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

    private IQueryable<Models.Hotel> FetchHotels()
    {
        return _dbContext.Hotels
            .Include(h => h.Discounts)
            .Include(h => h.Rooms)
            .ThenInclude(r => r.Bookings);
    }

    public async Task<AddHotelResponse> AddHotel(AddHotelRequest request)
    {
        var hotelGuid = Guid.NewGuid();

        var rooms = request.Hotel.Rooms.Select(rc => new Room
        {
            Id = Guid.NewGuid(),
            HotelId = hotelGuid,
            Size = rc.Size,
            Price = rc.Price,
            Count = rc.Count,
            Bookings = new List<RoomReservation>()
        }).ToList();

        var hotel = new Models.Hotel
        {
            Id = hotelGuid,
            Name = request.Hotel.Name,
            City = request.Hotel.City,
            Country = request.Hotel.Country,
            Street = request.Hotel.Street,
            FoodPricePerPerson = request.Hotel.FoodPricePerPerson,
            Rooms = rooms
        };

        await _dbContext.Hotels.AddAsync(hotel);
        await _dbContext.SaveChangesAsync();

        return new AddHotelResponse(hotel.ToDto());
    }

    public async Task<HotelCheckAvailabilityResponse> CheckHotelAvailability(HotelCheckAvailabilityRequest request)
    {
        var hotel = await FetchHotels()
            .FirstOrDefaultAsync(h => h.Id == request.Id);

        var response = false;
        if (hotel != null) response = hotel.IsAvailable(request.Start, request.End, request.NumPeople);

        return new HotelCheckAvailabilityResponse(response);
    }

    public async Task<GetHotelsResponse> GetHotels(GetHotelsRequest request)
    {
        var hotels = await FetchHotels()
            .ToListAsync();

        var hotelsDto = hotels.Select(hotel => hotel.ToDto()).ToList();

        return new GetHotelsResponse(hotelsDto);
    }

    public async Task<GetHotelResponse> GetHotel(GetHotelRequest request)
    {
        var hotel = await FetchHotels()
            .FirstOrDefaultAsync(h => h.Id == request.Id);

        return new GetHotelResponse(hotel?.ToDto());
    }

    public async Task<HotelBookRoomsResponse> BookRooms(HotelBookRoomsRequest request)
    {
        var hotel = await FetchHotels()
            .FirstOrDefaultAsync(h => h.Id == request.BookingDetails.Id);

        if (hotel == null) return new HotelBookRoomsResponse(Enumerable.Empty<RoomReservationDto>());

        await using var transaction = await _dbContext.Database.BeginTransactionAsync();
        try
        {
            var roomReservationDtos = new List<RoomReservationDto>();
            var startDate = request.BookingDetails.Start;
            var endDate = request.BookingDetails.Start.AddDays(request.BookingDetails.NumberOfNights);

            foreach (var size in request.BookingDetails.Sizes)
            {
                var roomSize = size.Key;
                var nRooms = size.Value;

                var room = hotel.Rooms.FirstOrDefault(r => r.Size == roomSize);
                if (room == null)
                    // Room of requested size does not exist in the hotel
                    throw new InvalidOperationException("Requested room size not available");

                if (!room.GetAvailability(startDate, endDate, nRooms).Any())
                    // Not enough rooms available, rollback the transaction
                    throw new InvalidOperationException("Not enough rooms available for requested size");

                var reservation = new RoomReservation
                {
                    Id = Guid.NewGuid(),
                    RoomsId = room.Id,
                    RoomsReserved = nRooms,
                    Start = startDate,
                    End = endDate
                };

                _dbContext.RoomReservations.Add(reservation);
                roomReservationDtos.Add(reservation.ToDto(roomSize));
            }

            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
            return new HotelBookRoomsResponse(roomReservationDtos);
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            return new HotelBookRoomsResponse(Enumerable.Empty<RoomReservationDto>());
        }
    }

    public async Task<HotelGetAvailableRoomsResponse> GetAvailableRooms(HotelGetAvailableRoomsRequest request)
    {
        var hotel = await FetchHotels()
            .FirstOrDefaultAsync(h => h.Id == request.HotelId);

        if (hotel == null)
            return new HotelGetAvailableRoomsResponse(new RoomAvailabilityDto
            {
                StartDate = request.Start,
                EndDate = request.End,
                Rooms = Enumerable.Empty<RoomsCount>()
            });

        var roomCounts = hotel.Rooms
            .Select(room => new RoomsCount
            {
                Count = room.GetFreeRooms(request.Start, request.End).Min(),
                Price = room.Price,
                Size = room.Size
            })
            .ToList();

        return new HotelGetAvailableRoomsResponse(new RoomAvailabilityDto
        {
            StartDate = request.Start,
            EndDate = request.End,
            Rooms = roomCounts
        });
    }

    public async Task<HotelAddDiscountResponse> AddDiscount(HotelAddDiscountRequest request)
    {
        var hotelQuery = await FetchHotels()
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (hotelQuery == null) return new HotelAddDiscountResponse();

        var newDiscount = new Discount
        {
            Id = Guid.NewGuid(),
            HotelId = request.Id,
            Value = request.Discount.Value,
            Start = DateTime.SpecifyKind(request.Discount.Start, DateTimeKind.Utc),
            End = DateTime.SpecifyKind(request.Discount.End, DateTimeKind.Utc)
        };

        hotelQuery.Discounts.Add(newDiscount);
        await _dbContext.Discounts.AddAsync(newDiscount);
        await _dbContext.SaveChangesAsync();

        return new HotelAddDiscountResponse();
    }

    public async Task<HotelCancelBookRoomsResponse> CancelBookRooms(HotelCancelBookRoomsRequest request)
    {
        foreach (var bookingId in request.Bookings)
        {
            var reservation = await _dbContext.RoomReservations
                .FirstOrDefaultAsync(r => r.Id == bookingId);
            if (reservation != null) reservation.CancelationDate = DateTime.UtcNow;

            await _dbContext.SaveChangesAsync();
        }

        return new HotelCancelBookRoomsResponse();
    }
}