using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

    public TransportOptionsController(
        ILogger<TransportOptionsController> logger,
        IRequestClient<ReservationGetTransportOptionsRequest> getTransportOptionsClient,
        IRequestClient<ReservationGetTransportOptionRequest> getTransportOptionClient,
        IRequestClient<AddTransportOptionRequest> addTransportOptionClient,
        IRequestClient<TransportOptionAddDiscountRequest> addTransportDiscountClient)
    {
        _logger = logger;
        _getTransportOptionsClient = getTransportOptionsClient;
        _getTransportOptionClient = getTransportOptionClient;
        _addTransportOptionClient = addTransportOptionClient;
        _addTransportDiscountClient = addTransportDiscountClient;
    }
    
    [HttpGet(Name = "GetTransportOptions")]
    public async Task<ActionResult<IEnumerable<TransportOption>>> Get()
    {
        var response = await _getTransportOptionsClient.GetResponse<ReservationGetTransportOptionsResponse>(new ReservationGetTransportOptionsRequest());
        return Ok(response.Message.TransportOptions);
    }
    
    [Authorize("RequireAdmin")]
    [HttpPost(Name = "PostTransportOption")]
    public async Task<ActionResult<TransportOption>> Post(TransportOptionCreate transportOptionCreate)
    {
        var transportOptionDto = new TransportOptionDto
        {
            Id = Guid.NewGuid(),
            From = new AddressDto
            {
                City = transportOptionCreate.FromCity,
                Country = transportOptionCreate.FromCountry,
                Street = transportOptionCreate.FromStreet,
                ShowName = transportOptionCreate.FromShowName
            },
            To = new AddressDto
            {
                City = transportOptionCreate.ToCity,
                Country = transportOptionCreate.ToCountry,
                Street = transportOptionCreate.ToStreet,
                ShowName = transportOptionCreate.ToShowName
            },
            Start = transportOptionCreate.Start,
            End = transportOptionCreate.End,
            SeatsAvailable = transportOptionCreate.SeatsAvailable,
            PriceAdult = transportOptionCreate.PriceAdult,
            PriceUnder3 = transportOptionCreate.PriceUnder3,
            PriceUnder10 = transportOptionCreate.PriceUnder10,
            PriceUnder18 = transportOptionCreate.PriceUnder18,
            Type = transportOptionCreate.Type.ToString(),
            Discounts = new List<DiscountDto>()
        };

        var response = await _addTransportOptionClient.GetResponse<AddTransportOptionResponse>(new AddTransportOptionRequest(transportOptionDto));
        return Ok(response.Message.TransportOption);
    }
    
    [HttpGet("{id}", Name = "GetTransportOption")]
    public async Task<ActionResult<TransportOption>> Get(Guid id, DateTime? fromTimeStamp)
    {
        var response = await _getTransportOptionClient.GetResponse<ReservationGetTransportOptionResponse>(new ReservationGetTransportOptionRequest(id));
        return Ok(response.Message.TransportOption);
    }
    
    [Authorize("RequireAdmin")]
    [HttpPost("{id}/Discount", Name = "PostTransportOptionDiscount")]
    public async Task<IActionResult> PostTransportOptionDiscount(Guid id, TransportOptionDiscount transportOptionDiscount)
    {
        var discountDto = new DiscountDto
        {
            Value = transportOptionDiscount.Percentage,
            Start = transportOptionDiscount.Start,
            End = transportOptionDiscount.End
        };

        await _addTransportDiscountClient.GetResponse<TransportOptionAddDiscountResponse>(new TransportOptionAddDiscountRequest(id, discountDto));
        return Ok();
    }
}
