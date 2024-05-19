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
    private readonly IRequestClient<GetPopularOffersRequest> _getOffers;

    public DestinationsController(ILogger<DestinationsController> logger, IRequestClient<GetAvailableDestinationsRequest> getDestinations, IRequestClient<GetPopularOffersRequest> getOffers)
    {
        _logger = logger;
        _getDestinations = getDestinations;
        _getOffers = getOffers;
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
    
    [HttpGet("PopularOffers", Name = "GetPopularOffers")]
    public async Task<ActionResult<IEnumerable<CountryOffer>>> GetPopularPlaces()
    {
        var response = await _getOffers.GetResponse<GetPopularOffersResponse>(new GetPopularOffersRequest());
        var popularOffers = new List<CountryOffer>();
        
        foreach (var countryKvp in response.Message.HotelsInCities)
        {
            var offers = new List<Offer>();

            foreach (var cityKvp in countryKvp.Value)
            {
                offers.Add(new Offer
                {
                    City = cityKvp.Key,
                    Hotels = cityKvp.Value
                });
            }

            popularOffers.Add(new CountryOffer
            {
                Country = countryKvp.Key,
                Offers = offers
            });
        }

        return Ok(popularOffers);
    }
}