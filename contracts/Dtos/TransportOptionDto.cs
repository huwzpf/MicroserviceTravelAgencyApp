namespace contracts.Dtos;

public class TransportOptionDto
{
    public Guid Id { get; set; }
    public List<DiscountDto> Discounts { get; set; }
    public int SeatsAvailable { get; set; }
    public AddressDto From { get; set; }
    public AddressDto To { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public decimal PriceAdult { get; set; }
    public decimal PriceUnder3 { get; set; }
    public decimal PriceUnder10 { get; set; }
    public decimal PriceUnder18 { get; set; }
    public string Type { get; set; } // "Airplane", "Train", "Bus"
}