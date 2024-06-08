namespace contracts.Dtos;
using System.ComponentModel.DataAnnotations;

public class HotelDto
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public IEnumerable<RoomsCount> Rooms { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Street { get; set; }
    [Required]
    public decimal FoodPricePerPerson { get; set; }
    [Required]
    public decimal Discount { get; set; }
}