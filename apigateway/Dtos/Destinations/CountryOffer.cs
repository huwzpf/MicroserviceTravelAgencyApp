using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Destinations;

public class Offer
{
    [Required]
    public string City { get; set; }
    [Required]
    public IEnumerable<String> Hotels { get; set; }
}

public class CountryOffer
{
    [Required]
    public string Country { get; set; }
    
    [Required]
    public IEnumerable<Offer> Offers { get; set; }
}