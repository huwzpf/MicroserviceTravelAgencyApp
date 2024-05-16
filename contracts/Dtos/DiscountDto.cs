namespace contracts.Dtos;

public class DiscountDto
{
    public Guid Id { get; set; }
    public decimal Value { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}