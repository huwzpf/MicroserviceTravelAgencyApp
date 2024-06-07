using System.Collections.Generic;
using System.Threading.Tasks;
using apigateway.Dtos.Destinations;
using contracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class DestinationsController : ControllerBase
{
    private readonly ILogger<DestinationsController> _logger;
    private readonly IRequestClient<GetAvailableDestinationsRequest> _getDestinations;

    public DestinationsController(ILogger<DestinationsController> logger, IRequestClient<GetAvailableDestinationsRequest> getDestinations)
    {
        _logger = logger;
        _getDestinations = getDestinations;
    }

    [HttpGet("AvailableDestinations", Name = "GetAvailableDestinations")]
    public async Task<ActionResult<IEnumerable<Destination>>> GetAvailableDestinations()
    {
        var response = await _getDestinations.GetResponse<GetAvailableDestinationsResponse>(new GetAvailableDestinationsRequest());
        var destinations = new List<Destination>();
        foreach (var kvp in response.Message.Destinations)
        {
            destinations.Add(new Destination
            {
                Country = kvp.Key,
                Cities = kvp.Value
            });
        }
        return Ok(destinations);
    }
}