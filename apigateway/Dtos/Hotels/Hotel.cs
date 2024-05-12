using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Hotels;


public class RoomsCount
{
    public decimal Price { get; set; }
    public int Size { get; set; }
    public int Count { get; set; }
}

public class Hotel
{
    [Required]
    public Guid Id { get; set; }
    
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
    public IEnumerable<RoomsCount> Rooms { get; set; }
}