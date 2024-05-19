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
}

public class RoomReservation
{
    public Guid Id { get; set; }
    public Guid RoomsId { get; set; } // Foreign key
    public int RoomsReserved { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public DateTime? CancelationDate { get; set; }
    public Room Rooms { get; set; }

    public RoomReservationDto ToDto()
    {
        return new RoomReservationDto
        {
            Id = this.Id,
            Size = this.Rooms.Size,
            Start = this.Start,
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
    public Guid Id;
    public Guid HotelId; // Foreign key
    public int Size;
    public Decimal Price;
    public int Count;
    public List<RoomReservation> Bookings { get; set; }
}

