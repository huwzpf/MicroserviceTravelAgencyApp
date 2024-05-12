using apigateway.Dtos.Tours;
using apigateway.Dtos.TransportOptions;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class ToursController : ControllerBase
{
    private readonly ILogger<ToursController> _logger;

    public ToursController(ILogger<ToursController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetTours")]
    public IEnumerable<Tour> Get(int numberOfPeople, string? fromCity, string? fromCountry, string? toCity, TypeOfTransport? toCountry, DateTime? minStart, DateTime? maxEnd, int? minDuration, int? maxDuration)
    {
        return Enumerable.Range(1, 5).Select(index => new Tour()
            {
                
            })
            .ToArray();
    }
}