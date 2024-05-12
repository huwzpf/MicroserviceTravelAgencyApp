using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Destinations;

public class Destination
{
    [Required]
    public string Country { get; set; }
    
    [Required]
    public IEnumerable<String> Cities { get; set; }
}