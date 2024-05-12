using apigateway.Dtos.Destinations;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class DestinationsController : ControllerBase
{
    private readonly ILogger<DestinationsController> _logger;

    public DestinationsController(ILogger<DestinationsController> logger)
    {
        _logger = logger;
    }

    [HttpGet("AvailableDestinations", Name = "GetAvailableDestinations")]
    public IEnumerable<Destination> GetAvailableDestinations()
    {
        return Enumerable.Range(1, 5).Select(index => new Destination()
            {
                
            })
            .ToArray();
    }
    
    [HttpGet("PopularOffers", Name = "GetPopularOffers")]
    public IEnumerable<CountryOffer> GetPopularPlaces()
    {
        return Enumerable.Range(1, 5).Select(index => new CountryOffer()
            {
                
            })
            .ToArray();
    }
}