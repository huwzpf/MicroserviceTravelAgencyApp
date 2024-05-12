using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Common;

public class HotelDiscount
{   
    [Required]
    public decimal Percentage { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime Start { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime End { get; set; }
}
