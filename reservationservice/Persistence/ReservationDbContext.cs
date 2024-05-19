using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using reservationservice.Models;

namespace reservationservice.Persistence;

public class ReservationDbContext : DbContext
{
    public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options)
    {
    }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<HotelRoomReservation> HotelRoomReservations { get; set; }
    public DbSet<BeingPaidFor> BeingPaidFors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Reservation>()
            .HasKey(r => r.Id);

        modelBuilder.Entity<HotelRoomReservation>()
            .HasKey(hr => hr.Id);

        modelBuilder.Entity<HotelRoomReservation>()
            .HasOne<Reservation>()
            .WithMany(r => r.HotelRoomReservations)
            .HasForeignKey(hr => hr.ReservationId);

        modelBuilder.Entity<BeingPaidFor>()
            .HasKey(bp => bp.Id);

        modelBuilder.Entity<BeingPaidFor>()
            .HasOne<Reservation>()
            .WithMany(r => r.BeingPaidFors)
            .HasForeignKey(bp => bp.ReservationId);
        
        var dateTimeConverter = new ValueConverter<DateTime, DateTime>(
            v => v.Kind == DateTimeKind.Local ? v.ToUniversalTime() : v, 
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

        var nullableDateTimeConverter = new ValueConverter<DateTime?, DateTime?>(
            v => v.HasValue ? (v.Value.Kind == DateTimeKind.Local ? v.Value.ToUniversalTime() : v.Value) : v, 
            v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : v);

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var dateTimeProperties = entityType.ClrType.GetProperties()
                .Where(p => p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(DateTime?));

            foreach (var property in dateTimeProperties)
            {
                if (property.PropertyType == typeof(DateTime))
                {
                    modelBuilder.Entity(entityType.Name).Property(property.Name).HasConversion(dateTimeConverter);
                }
                else if (property.PropertyType == typeof(DateTime?))
                {
                    modelBuilder.Entity(entityType.Name).Property(property.Name).HasConversion(nullableDateTimeConverter);
                }
            }
        }
    }
}
