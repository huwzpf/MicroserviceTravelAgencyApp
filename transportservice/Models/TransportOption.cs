using contracts.Dtos;

namespace transportservice.Models;

public class CommandTransportOption
{
    public Guid Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public decimal PriceAdult { get; set; }
    public decimal PriceUnder3 { get; set; }
    public decimal PriceUnder10 { get; set; }
    public decimal PriceUnder18 { get; set; }
    public string Type { get; set; }
    public int InitialSeats { get; set; }
    public string FromCity { get; set; }
    public string FromCountry { get; set; }
    public string FromStreet { get; set; }
    public string? FromShowName { get; set; }
    public string ToCity { get; set; }
    public string ToCountry { get; set; }
    public string ToStreet { get; set; }
    public string? ToShowName { get; set; }
    public List<Discount> Discounts { get; set; } = new();
    public List<SeatsChange> SeatsChanges { get; set; } = new();

    public TransportOptionDto ToDto()
    {
        return new TransportOptionDto
        {
            Id = Id,
            SeatsAvailable = GetSeats(),
            Start = Start,
            End = End,
            PriceAdult = PriceAdult,
            PriceUnder3 = PriceUnder3,
            PriceUnder10 = PriceUnder10,
            PriceUnder18 = PriceUnder18,
            Type = Type,
            FromStreet = FromStreet,
            FromCity = FromCity,
            FromCountry = FromCountry,
            FromShowName = FromShowName,
            ToStreet = ToStreet,
            ToCity = ToCity,
            ToCountry = ToCountry,
            ToShowName = ToShowName
        };
    }

    public int GetSeats()
    {
        int totalChange = SeatsChanges.Sum(sc => sc.ChangeBy);
        return InitialSeats + totalChange;
    }
}

public class Discount
{
    public Guid Id { get; set; }
    public Guid TransportOptionId { get; set; } // Foreign key
    public decimal Value { get; set; }
    public DateTime Start { get; set; }
}

public class SeatsChange
{
    public Guid Id { get; set; }
    public Guid TransportOptionId { get; set; } // Foreign Key
    public int ChangeBy { get; set; }
}

public class QueryTransportOption
{
    public Guid Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public decimal PriceAdult { get; set; }
    public decimal PriceUnder3 { get; set; }
    public decimal PriceUnder10 { get; set; }
    public decimal PriceUnder18 { get; set; }
    public string Type { get; set; }
    public int Seats { get; set; }
    public string FromCity { get; set; }
    public string FromCountry { get; set; }
    public string FromStreet { get; set; }
    public string? FromShowName { get; set; }
    public string ToCity { get; set; }
    public string ToCountry { get; set; }
    public string ToStreet { get; set; }
    public string? ToShowName { get; set; }
    
    public decimal? Discount { get; set; }

    private decimal GetDiscount()
    {
        return Discount ?? 1;
    }

    public TransportOptionDto ToDto()
    {
        var discount = GetDiscount();
        return new TransportOptionDto
        {
            Id = Id,
            SeatsAvailable = Seats,
            Start = Start,
            End = End,
            PriceAdult = PriceAdult * discount,
            PriceUnder3 = PriceUnder3 * discount,
            PriceUnder10 = PriceUnder10 * discount,
            PriceUnder18 = PriceUnder18 * discount,
            Discount = discount,
            Type = Type,
            FromStreet = FromStreet,
            FromCity = FromCity,
            FromCountry = FromCountry,
            FromShowName = FromShowName,
            ToStreet = ToStreet,
            ToCity = ToCity,
            ToCountry = ToCountry,
            ToShowName = ToShowName
        };
    }
}
public class PopularDestination
{
    public Guid Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public int Counter { get; set; }

    public PopularDestinationDto ToDto()
    {
        return new PopularDestinationDto
        {
            Id = this.Id,
            Country = this.Country,
            City = this.City,
            Counter = this.Counter
        };
    }
}

public class PopularTransportType
{
    public Guid Id { get ; set; }
    public string Type { get; set; }
    public int Counter { get; set; }
}
