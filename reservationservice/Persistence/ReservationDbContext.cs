using Microsoft.EntityFrameworkCore;
using reservationservice.Models;

namespace reservationservice.Persistence;

public class ReservationDbContext : DbContext
{
    public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options)
    {
    }

    public DbSet<Reservation> Reservations { get; set; }
}