using apigateway.Dtos.Reservations;
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
    
    [HttpGet(Name = "GetReservations")]
    public IEnumerable<Reservation> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Reservation()
            {
                
            })
            .ToArray();
    }
    
    [HttpPost(Name = "PostReservation")]
    public Reservation Post(ReservationCreate reservationCreate)
    {
        return new Reservation()
        {

        };
    }
    
    [HttpGet("{id}", Name = "GetReservation")]
    public Reservation Get(Guid id)
    {
        return new Reservation()
        {

        };
    }
    
    [HttpPost("{id}/Buy",Name = "BuyReservation")]
    public Boolean BuyReservation(Guid id, PaymentInfo paymentInfo)
    {
        return true;
    }
}