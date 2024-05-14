using apigateway.Dtos.Reservations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationsController : ControllerBase
{
    private readonly ILogger<ReservationsController> _logger;

    public ReservationsController(ILogger<ReservationsController> logger)
    {
        _logger = logger;
    }
    
    [Authorize]
    [HttpGet(Name = "GetReservations")]
    public IEnumerable<Reservation> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Reservation()
            {
                
            })
            .ToArray();
    }
    
    [Authorize]
    [HttpPost(Name = "PostReservation")]
    public Reservation Post(ReservationCreate reservationCreate)
    {
        return new Reservation()
        {

        };
    }
    
    [Authorize]
    [HttpGet("{id}", Name = "GetReservation")]
    public Reservation Get(Guid id)
    {
        return new Reservation()
        {

        };
    }
    
    [Authorize]
    [HttpPost("{id}/Buy",Name = "BuyReservation")]
    public Boolean BuyReservation(Guid id, PaymentInfo paymentInfo)
    {
        return true;
    }
}