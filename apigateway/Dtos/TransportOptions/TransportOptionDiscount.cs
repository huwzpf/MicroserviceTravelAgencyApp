using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.TransportOptions;

public class TransportOptionDiscount
{
    [Required]
    public decimal Percentage { get; set; }
    
    [Required]
    public DateTime Start { get; set; }
    
    [Required]
    public DateTime End { get; set; }
}