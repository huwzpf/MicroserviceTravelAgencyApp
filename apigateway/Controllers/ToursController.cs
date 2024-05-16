using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apigateway.Dtos.Tours;
using contracts;
using contracts.Dtos;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class ToursController : ControllerBase
{
    private readonly ILogger<ToursController> _logger;
    private readonly IRequestClient<GetAvailableToursRequest> _getAvailableToursClient;

    public ToursController(ILogger<ToursController> logger, IRequestClient<GetAvailableToursRequest> getAvailableToursClient)
    {
        _logger = logger;
        _getAvailableToursClient = getAvailableToursClient;
    }
    
    [HttpGet(Name = "GetTours")]
    public async Task<ActionResult<IEnumerable<Tour>>> Get(int numberOfPeople, string? fromCity, string? fromCountry, string? toCity, string? toCountry, DateTime? minStart, DateTime? maxEnd, int? minDuration, int? maxDuration)
    {
        var toursDto = new GetAvailableToursDto
        {
            NumPeople = numberOfPeople,
            SourceCity = fromCity,
            SourceCountry = fromCountry,
            DestinationCity = toCity,
            DestinationCountry = toCountry,
            MinStart = minStart,
            MaxEnd = maxEnd,
            MinDuration = minDuration,
            MaxDuration = maxDuration
        };
        var response = await _getAvailableToursClient.GetResponse<GetAvailableToursResponse>(new GetAvailableToursRequest(toursDto));
        return Ok(response.Message.Tours);
    }
}
