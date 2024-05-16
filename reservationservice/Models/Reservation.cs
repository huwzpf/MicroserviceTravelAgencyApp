using Microsoft.EntityFrameworkCore;

namespace reservationservice.Models;
public class Reservation
{
    public Guid Id { get; init; }
    
    public bool Finalized { get; init; }
    
    public Guid UserId { get; init; }
    
    public decimal Price { get; init; }
}