using apigateway.Dtos.TransportOptions;
using contracts;
using contracts.Dtos;
using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class TransportOptionsController : ControllerBase
{
    private readonly ILogger<TransportOptionsController> _logger;
    private readonly IRequestClient<ReservationGetTransportOptionsRequest> _getTransportOptionsClient;
    private readonly IRequestClient<ReservationGetTransportOptionRequest> _getTransportOptionClient;
    private readonly IRequestClient<AddTransportOptionRequest> _addTransportOptionClient;
    private readonly IRequestClient<TransportOptionAddDiscountRequest> _addTransportDiscountClient;
    private readonly IRequestClient<GetPopularTransportDestinationsRequest> _getDestinations;
    private readonly IRequestClient<GetPopularTransportTypesRequest> _getTypes;

    public TransportOptionsController(ILogger<TransportOptionsController> logger,
        IRequestClient<ReservationGetTransportOptionsRequest> getTransportOptionsClient,
        IRequestClient<ReservationGetTransportOptionRequest> getTransportOptionClient,
        IRequestClient<AddTransportOptionRequest> addTransportOptionClient,
        IRequestClient<TransportOptionAddDiscountRequest> addTransportDiscountClient,
        IRequestClient<GetPopularTransportDestinationsRequest> getDestinations,
        IRequestClient<GetPopularTransportTypesRequest> getTypes)
    {
        _logger = logger;
        _getTransportOptionsClient = getTransportOptionsClient;
        _getTransportOptionClient = getTransportOptionClient;
        _addTransportOptionClient = addTransportOptionClient;
        _addTransportDiscountClient = addTransportDiscountClient;
        _getDestinations = getDestinations;
        _getTypes = getTypes;
    }

    [HttpGet(Name = "GetTransportOptions")]
    public async Task<ActionResult<IEnumerable<TransportOptionDto>>> Get()
    {
        var response =
            await _getTransportOptionsClient.GetResponse<ReservationGetTransportOptionsResponse>(
                new ReservationGetTransportOptionsRequest());
        return Ok(response.Message.TransportOptions);
    }

    [Authorize("RequireAdmin")]
    [HttpPost(Name = "PostTransportOption")]
    public async Task<ActionResult<TransportOptionDto>> Post(TransportOptionCreate transportOptionCreate)
    {
        var transportOptionDto = new TransportOptionDto
        {
            Id = Guid.NewGuid(),
            FromCity = transportOptionCreate.FromCity,
            FromCountry = transportOptionCreate.FromCountry,
            FromStreet = transportOptionCreate.FromStreet,
            FromShowName = transportOptionCreate.FromShowName,
            ToCity = transportOptionCreate.ToCity,
            ToCountry = transportOptionCreate.ToCountry,
            ToStreet = transportOptionCreate.ToStreet,
            ToShowName = transportOptionCreate.ToShowName,
            Start = transportOptionCreate.Start,
            End = transportOptionCreate.End,
            SeatsAvailable = transportOptionCreate.SeatsAvailable,
            PriceAdult = transportOptionCreate.PriceAdult,
            PriceUnder3 = transportOptionCreate.PriceUnder3,
            PriceUnder10 = transportOptionCreate.PriceUnder10,
            PriceUnder18 = transportOptionCreate.PriceUnder18,
            Type = transportOptionCreate.Type
        };

        var response =
            await _addTransportOptionClient.GetResponse<AddTransportOptionResponse>(
                new AddTransportOptionRequest(transportOptionDto));
        return Ok(response.Message.TransportOption);
    }

    [HttpGet("{id}", Name = "GetTransportOption")]
    public async Task<ActionResult<TransportOptionDto>> Get(Guid id)
    {
        var response =
            await _getTransportOptionClient.GetResponse<ReservationGetTransportOptionResponse>(
                new ReservationGetTransportOptionRequest(id));
        return response.Message.TransportOption == null
            ? BadRequest(new ProblemDetails { Title = "Buy failed", Status = 400 })
            : Ok(response.Message.TransportOption);
        ;
    }

    [Authorize("RequireAdmin")]
    [HttpPost("{id}/Discount", Name = "PostTransportOptionDiscount")]
    public async Task<IActionResult> PostTransportOptionDiscount(Guid id,  decimal value)
    {
        await _addTransportDiscountClient.GetResponse<TransportOptionAddDiscountResponse>(
            new TransportOptionAddDiscountRequest(id, value));
        return Ok();
    }
    
    
    
    [HttpGet("PopularTransportDestinations", Name = "GetPopularTransportDestinations")]
    public async Task<ActionResult<Dictionary<string, List<string>>>> GetPopularTransportDestinations()
    {
        var response = await _getDestinations.GetResponse<GetPopularTransportDestinationsResponse>(new GetPopularTransportDestinationsRequest());
        return Ok(response.Message.PopularCities);
    }
    
    
    
    [HttpGet("PopularTransportTypes", Name = "GetPopularTransportTypes")]
    public async Task<ActionResult<List<string>>> GetPopularTransportTypes()
    {
        var response = await _getTypes.GetResponse<GetPopularTransportTypesResponse>(new GetPopularTransportTypesRequest());
        return Ok(response.Message.Types);
    }
}