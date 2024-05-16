using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using apigateway.Dtos.Reservations;
using contracts;
using contracts.Dtos;
using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationsController : ControllerBase
{
    private readonly ILogger<ReservationsController> _logger;
    private readonly IRequestClient<GetReservationsRequest> _getReservationsClient;
    private readonly IRequestClient<GetSingleReservationRequest> _getSingleReservationClient;
    private readonly IRequestClient<CreateReservationRequest> _createReservationClient;
    private readonly IRequestClient<BuyRequest> _buyClient;

    public ReservationsController(
        ILogger<ReservationsController> logger,
        IRequestClient<GetReservationsRequest> getReservationsClient,
        IRequestClient<GetSingleReservationRequest> getSingleReservationClient,
        IRequestClient<CreateReservationRequest> createReservationClient,
        IRequestClient<BuyRequest> buyClient)
    {
        _logger = logger;
        _getReservationsClient = getReservationsClient;
        _getSingleReservationClient = getSingleReservationClient;
        _createReservationClient = createReservationClient;
        _buyClient = buyClient;
    }
    
    [Authorize]
    [HttpGet(Name = "GetReservations")]
    public async Task<ActionResult<IEnumerable<Reservation>>> Get()
    {
        var response = await _getReservationsClient.GetResponse<GetReservationsResponse>(new GetReservationsRequest(Guid.NewGuid())); // Replace with actual UserId
        return Ok(response.Message.Reservations);
    }
    
    [Authorize]
    [HttpPost(Name = "PostReservation")]
    public async Task<ActionResult<Reservation>> Post(ReservationCreate reservationCreate)
    {
        var reservationDto = new CreateReservationDto
        {
            UserId = Guid.Parse(User.FindFirstValue(ClaimTypes.Name)),
            NumAdults = reservationCreate.NumberOfAdults,
            NumUnder3 = reservationCreate.NumberOfUnder3,
            NumUnder10 = reservationCreate.NumberOfUnder10,
            NumUnder18 = reservationCreate.NumberOfUnder18,
            ToDestinationTransport = reservationCreate.ToHotelTransportOptionId.GetValueOrDefault(),
            Hotel = reservationCreate.HotelId,
            Rooms = new Dictionary<int, int>(reservationCreate.Rooms.Select(r => new KeyValuePair<int, int>(r.Size, r.Number))),
            FromDestinationTransport = reservationCreate.FromHotelTransportOptionId.GetValueOrDefault(),
            WithFood = reservationCreate.FoodIncluded,
            StartDate = reservationCreate.DateTime.GetValueOrDefault(),
            EndDate = reservationCreate.DateTime.GetValueOrDefault().AddDays(reservationCreate.NumberOfNights.GetValueOrDefault(1))
        };
        var response = await _createReservationClient.GetResponse<CreateReservationResponse>(new CreateReservationRequest(reservationDto));
        return Ok(response.Message.Reservation);
    }
    
    [Authorize]
    [HttpGet("{id}", Name = "GetReservation")]
    public async Task<ActionResult<Reservation>> Get(Guid id)
    {
        var response = await _getSingleReservationClient.GetResponse<GetSingleReservationResponse>(new GetSingleReservationRequest(id));
        return Ok(response.Message.Reservation);
    }
    
    [Authorize]
    [HttpPost("{id}/Buy", Name = "BuyReservation")]
    public async Task<ActionResult<bool>> BuyReservation(Guid id, PaymentInfo paymentInfo)
    {
        var paymentInfoDto = new PaymentInfoDto
        {
            CreditCardNumber = paymentInfo.CreditCardNumber,
            CreditCardExpirationDate = new Tuple<string, string>(paymentInfo.ExpirationDate.Month.ToString(), paymentInfo.ExpirationDate.Year.ToString()),
            CardSecurityCode = paymentInfo.SecurityNumber
        };
        var response = await _buyClient.GetResponse<BuyResponse>(new BuyRequest(id, paymentInfoDto));
        return Ok(response.Message.Success);
    }
}