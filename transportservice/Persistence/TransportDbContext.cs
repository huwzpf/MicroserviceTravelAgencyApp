using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace transportservice.Models
{
    public class TransportDbContext : DbContext
    {
        public DbSet<CommandTransportOption> CommandTransportOptions { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<SeatsChange> SeatsChanges { get; set; }
        
        public DbSet<QueryTransportOption> QueryTransportOptions { get; set; }

        public TransportDbContext(DbContextOptions<TransportDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CommandTransportOption>()
                .HasKey(to => to.Id);
            
            modelBuilder.Entity<QueryTransportOption>()
                .HasKey(to => to.Id);

            modelBuilder.Entity<Discount>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Discount>()
                .HasOne<CommandTransportOption>()
                .WithMany(to => to.Discounts)
                .HasForeignKey(d => d.TransportOptionId);

            modelBuilder.Entity<SeatsChange>()
                .HasKey(sc => sc.Id);

            modelBuilder.Entity<SeatsChange>()
                .HasOne<CommandTransportOption>()
                .WithMany(to => to.SeatsChanges)
                .HasForeignKey(sc => sc.TransportOptionId);
            
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
                        modelBuilder.Entity(entityType.Name).Property(property.Name)
                            .HasConversion(nullableDateTimeConverter);
                    }
                }
            }

            Guid g1 = Guid.NewGuid();
            Guid g2 = Guid.NewGuid();
            Guid g3 = Guid.NewGuid();
            Guid g4 = Guid.NewGuid();
            Guid g5 = Guid.NewGuid();
            
            var transportOptions = new[]
            {
                new CommandTransportOption
                {
                    Id = g1, Start = DateTime.UtcNow.AddDays(1), End = DateTime.UtcNow.AddDays(1).AddHours(2), PriceAdult = 150, Type = "Plane", InitialSeats = 100,
                    FromCity = "Paris", FromCountry = "France", FromStreet = "Charles de Gaulle", ToCity = "Berlin", ToCountry = "Germany", ToStreet = "Tegel"
                },
                new CommandTransportOption
                {
                    Id = g2, Start = DateTime.UtcNow.AddDays(5), End = DateTime.UtcNow.AddDays(5).AddHours(5), PriceAdult = 150, Type = "Plane", InitialSeats = 100,
                    FromCity = "Berlin", FromCountry = "Germany", FromStreet = "Tegel", ToCity = "Paris", ToCountry = "France", ToStreet = "Charles de Gaulle"
                },
                new CommandTransportOption
                {
                    Id = g3, Start = DateTime.UtcNow.AddDays(1), End = DateTime.UtcNow.AddDays(1).AddHours(10), PriceAdult = 500, Type = "Plane", InitialSeats = 150,
                    FromCity = "Tokyo", FromCountry = "Japan", FromStreet = "Narita", ToCity = "Gdansk", ToCountry = "Poland", ToStreet = "Lech Walesa"
                },
                new CommandTransportOption
                {
                    Id = g4, Start = DateTime.UtcNow.AddDays(14), End = DateTime.UtcNow.AddDays(14).AddHours(10), PriceAdult = 500, Type = "Plane", InitialSeats = 150,
                    FromCity = "Gdansk", FromCountry = "Poland", FromStreet = "Lech Walesa", ToCity = "Tokyo", ToCountry = "Japan", ToStreet = "Narita"
                },
                new CommandTransportOption
                {
                    Id = g5, Start = DateTime.UtcNow.AddDays(3), End = DateTime.UtcNow.AddDays(3).AddHours(2), PriceAdult = 200, Type = "Plane", InitialSeats = 120,
                    FromCity = "London", FromCountry = "UK", FromStreet = "Heathrow", ToCity = "Gdansk", ToCountry = "Poland", ToStreet = "Lech Walesa"
                }
            };

            modelBuilder.Entity<CommandTransportOption>().HasData(transportOptions);
            
            var queryTransportOptions = new[]
            {
                new QueryTransportOption
                {
                    Id = g1, Start = DateTime.UtcNow.AddDays(1), End = DateTime.UtcNow.AddDays(1).AddHours(2), PriceAdult = 150, Type = "Plane", Seats = 100,
                    FromCity = "Paris", FromCountry = "France", FromStreet = "Charles de Gaulle", ToCity = "Berlin", ToCountry = "Germany", ToStreet = "Tegel"
                },
                new QueryTransportOption
                {
                    Id = g2, Start = DateTime.UtcNow.AddDays(5), End = DateTime.UtcNow.AddDays(5).AddHours(5), PriceAdult = 150, Type = "Plane", Seats = 100,
                    FromCity = "Berlin", FromCountry = "Germany", FromStreet = "Tegel", ToCity = "Paris", ToCountry = "France", ToStreet = "Charles de Gaulle"
                },
                new QueryTransportOption
                {
                    Id = g3, Start = DateTime.UtcNow.AddDays(1), End = DateTime.UtcNow.AddDays(1).AddHours(10), PriceAdult = 500, Type = "Plane", Seats = 150,
                    FromCity = "Tokyo", FromCountry = "Japan", FromStreet = "Narita", ToCity = "Gdansk", ToCountry = "Poland", ToStreet = "Lech Walesa"
                },
                new QueryTransportOption
                {
                    Id = g4, Start = DateTime.UtcNow.AddDays(14), End = DateTime.UtcNow.AddDays(14).AddHours(10), PriceAdult = 500, Type = "Plane", Seats = 150,
                    FromCity = "Gdansk", FromCountry = "Poland", FromStreet = "Lech Walesa", ToCity = "Tokyo", ToCountry = "Japan", ToStreet = "Narita"
                },
                new QueryTransportOption
                {
                    Id = g5, Start = DateTime.UtcNow.AddDays(3), End = DateTime.UtcNow.AddDays(3).AddHours(2), PriceAdult = 200, Type = "Plane", Seats = 120,
                    FromCity = "London", FromCountry = "UK", FromStreet = "Heathrow", ToCity = "Gdansk", ToCountry = "Poland", ToStreet = "Lech Walesa"
                }
            };

            modelBuilder.Entity<QueryTransportOption>().HasData(queryTransportOptions);
        }
    }
}
