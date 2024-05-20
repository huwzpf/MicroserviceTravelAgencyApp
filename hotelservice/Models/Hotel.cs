using contracts.Dtos;

namespace hotelservice.Models;

public class Hotel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal FoodPricePerPerson { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Street { get; set; }
    public List<Discount> Discounts { get; set; }
    public List<Room> Rooms { get; set; }

    // This property is needed for optimizing searching for hotel
    // It contains map numGuests: {roomSize: roomCount} - all possible room configurations for given number of guests
    // Splits are without duplicates and are "optimal" -
    // meaning that configuration with rooms accommodating more than  numGuests are possible, but roomCount is minimized
    // i.e. for 2 guests it's possible to have configuration with single room for 5 people, but not with 2 such rooms
    public Dictionary<int, List<Dictionary<int, int>>> GuestConfigurations; 

    public HotelDto ToDto()
    {
        var RoomsCount = Rooms
            .GroupBy(r => new { r.Price, r.Size })
            .Select(g => new RoomsCount
            {
                Price = g.Key.Price,
                Size = g.Key.Size,
                Count = g.Sum(r => r.Count)
            }).ToList();
        
        return new HotelDto
        {
            Id = this.Id,
            Name = this.Name,
            FoodPricePerPerson = this.FoodPricePerPerson,
            City = this.City,
            Country = this.Country,
            Street = this.Street,
            Rooms = RoomsCount
        };
    }
    public Dictionary<int, int> GetRoomCounts()
    {
        var roomCounts = new Dictionary<int, int>();
        foreach (var room in Rooms)
        {
            if (roomCounts.ContainsKey(room.Size))
            {
                roomCounts[room.Size] += room.Count;
            }
            else
            {
                roomCounts[room.Size] = room.Count;
            }
        }
        return roomCounts;
    }
    public bool IsAvailable(DateTime start, DateTime end, int numPeople, int minLength=0)
    {
        // if minLength == 0: minLength = end - start
        foreach (var config in GuestConfigurations[numPeople])
        {
            bool allAvailable = true;
            foreach (var kvp in config)
            {
                int roomSize = kvp.Key;
                int roomsRequired = kvp.Value;
                if (roomsRequired == 0) continue;
                
                // Here the assumption that rooms are unique in terms of size
                var room = Rooms.FirstOrDefault(r => r.Size == roomSize);
                if (room == null)
                {
                    // This should never be the case
                    allAvailable = false;
                    break;
                }

                var availability = room.GetAvailability(start, end, roomsRequired, minLength);
                if (!availability.Any())
                {
                    allAvailable = false;
                    break;
                }
            }
            if (allAvailable)
            {
                return true;
            }
        }
        return false;
    }
}

public class RoomReservation
{
    public Guid Id { get; set; }
    public Guid RoomsId { get; set; } // Foreign key
    public int RoomsReserved { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public DateTime? CancelationDate { get; set; }

    public RoomReservationDto ToDto(int size)
    {
        return new RoomReservationDto
        {
            Id = this.Id,
            Size = size,
            Start = this.Start,
            NumberOfNights = (int)(End - Start).TotalDays
        };
    }
}

public class Discount
{
    public Guid Id { get; set; }
    public Guid HotelId { get; set; } // Foreign key
    public decimal Value { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    public DiscountDto ToDto()
    {
        return new DiscountDto
        {
            Id = this.Id,
            Value = this.Value,
            Start = this.Start,
            End = this.End
        };
    }
}

public class Room
{
    public Guid Id { get; set; }
    public Guid HotelId { get; set; } // Foreign key
    public int Size { get; set; }
    public Decimal Price { get; set; }
    public int Count { get; set; }
    public List<RoomReservation> Bookings { get; set; }
    public List<Tuple<DateTime, DateTime>> GetAvailability(DateTime rangeStart, DateTime rangeEnd, int nRooms, int minLength = 0)
    {
        // This function returns a list of ranges, 
        // where each of these ranges is within rangeStart, end rangeEnd passed as parameter and each range is at least minLength
        // 1) Validate range - minLength should greater or equal (rangeEnd - rangeStart) and (rangeEnd - rangeStart) should be smaller than maxDays days
        // 2) Create a list of free rooms - array of ints with self.count at each index - we start with all rooms available
        // 3) Iterate over reservations, for each reservation that has common part with current range decrease corresponding array elements
        // 4) Iterate over list of free rooms to find valid ranges of at least minLength, save them to results list
        (rangeEnd, var rangeDays) = RangeDays(rangeStart, rangeEnd);

        if (minLength > rangeDays || minLength == 0)
        {
            minLength = rangeDays;
        }

        var freeRooms = GetFreeRooms(rangeStart, rangeEnd);

        // List<Start, End>
        var results = new List<Tuple<DateTime, DateTime>>();
        int idx = 0;

        while (idx <= rangeDays - minLength)
        {
            if (freeRooms.Skip(idx).Take(minLength).Any(fr => fr < nRooms))
            {
                idx++;
                continue;
            }

            int endIdx = idx + minLength;
            while (endIdx < rangeDays && freeRooms[endIdx] >= nRooms)
            {
                endIdx++;
            }

            results.Add(Tuple.Create(rangeStart.AddDays(idx), rangeStart.AddDays(endIdx - 1)));
            idx = endIdx;
        }

        return results;
    }

    private static (DateTime rangeEnd, int rangeDays) RangeDays(DateTime rangeStart, DateTime rangeEnd)
    {
        const int maxDays = 60;
        int rangeDays = (int)(rangeEnd - rangeStart).TotalDays + 1;

        if (rangeDays >= maxDays)
        {
            rangeEnd = rangeStart.AddDays(maxDays-1);
            rangeDays = maxDays;
        }

        return (rangeEnd, rangeDays);
    }

    public int[] GetFreeRooms(DateTime rangeStart, DateTime rangeEnd)
    {
        (rangeEnd, var rangeDays) = RangeDays(rangeStart, rangeEnd);
        var freeRooms = Enumerable.Repeat(Count, rangeDays).ToArray();

        foreach (var reservation in Bookings)
        {
            if (reservation.CancelationDate.HasValue) continue;
            // max(reservation.Start, rangeStart)
            var resStart = reservation.Start > rangeStart ? reservation.Start : rangeStart;
            // min(reservation.End, rangeEnd)
            var resEnd = reservation.End < rangeEnd ? reservation.End : rangeEnd;

            if (resStart <= resEnd)
            {
                for (int i = 0; i <= (resEnd - resStart).TotalDays; i++)
                {
                    freeRooms[(resStart - rangeStart).Days + i] -= reservation.RoomsReserved;
                }
            }
        }

        return freeRooms;
    }
}

