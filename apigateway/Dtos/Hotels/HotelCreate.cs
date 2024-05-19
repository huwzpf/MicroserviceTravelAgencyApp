using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Hotels;

public class HotelCreate
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Country { get; set; }
    
    [Required]
    public string City { get; set; }
    
    [Required]
    public string Street { get; set; }
    
    [Required]
    public decimal FoodPricePerPerson { get; set; }
    
    [Required]
    public IEnumerable<contracts.Dtos.RoomsCount> Rooms { get; set; }
}