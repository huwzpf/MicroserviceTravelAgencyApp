using contracts.Dtos;

namespace transportservice.Models;

public class TransportOption
{
    public Guid Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public decimal PriceAdult { get; set; }
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
            PriceUnder3 = PriceAdult * (decimal)0.1,
            PriceUnder10 = PriceAdult * (decimal)0.5,
            PriceUnder18 = PriceAdult * (decimal)0.9,
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
    public DateTime End { get; set; }
}

public class SeatsChange
{
    public Guid Id { get; set; }
    public Guid TransportOptionId { get; set; } // Foreign Key
    public int ChangeBy { get; set; }
}