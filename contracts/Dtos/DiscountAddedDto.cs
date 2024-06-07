using System.ComponentModel.DataAnnotations;

namespace contracts.Dtos;

public class DiscountAddedDto
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public decimal PriceAdult { get; set; }
    [Required]
    public decimal PriceUnder3 { get; set; }
    [Required]
    public decimal PriceUnder10 { get; set; }
    [Required]
    public decimal PriceUnder18 { get; set; }
}