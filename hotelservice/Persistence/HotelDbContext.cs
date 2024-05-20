using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace hotelservice.Models
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Room>()
                .HasOne<Hotel>()
                .WithMany(r => r.Rooms)
                .HasForeignKey(r => r.HotelId);

            modelBuilder.Entity<Discount>()
                .HasOne<Hotel>()
                .WithMany(d => d.Discounts)
                .HasForeignKey(d => d.HotelId);

            modelBuilder.Entity<RoomReservation>()
                .HasOne<Room>()
                .WithMany(rr => rr.Bookings)
                .HasForeignKey(rr => rr.RoomsId);

            modelBuilder.Entity<Hotel>()
                .HasKey(h => h.Id);

            modelBuilder.Entity<RoomReservation>()
                .HasKey(rr => rr.Id);

            modelBuilder.Entity<Discount>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Room>()
                .HasKey(r => r.Id);


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

            var hotel1Id = Guid.NewGuid();
            var hotel2Id = Guid.NewGuid();
            var hotel3Id = Guid.NewGuid();

            var hotels = new[]
            {
                new Hotel
                {
                    Id = hotel1Id, Name = "Berlin Hotel", FoodPricePerPerson = 20, City = "Berlin", Country = "Germany", Street = "Alexanderplatz"
                },
                new Hotel
                {
                    Id = hotel2Id, Name = "Gdansk Hotel", FoodPricePerPerson = 15, City = "Gdansk", Country = "Poland", Street = "Dluga"
                },
                new Hotel
                {
                    Id = hotel3Id, Name = "Tokyo Hotel", FoodPricePerPerson = 25, City = "Tokyo", Country = "Japan", Street = "Shinjuku"
                }
            };

            modelBuilder.Entity<Hotel>().HasData(hotels);

            var rooms = new[]
            {
                new Room { Id = Guid.NewGuid(), HotelId = hotel1Id, Size = 25, Price = 100, Count = 5 },
                new Room { Id = Guid.NewGuid(), HotelId = hotel1Id, Size = 35, Price = 150, Count = 5 },
                new Room { Id = Guid.NewGuid(), HotelId = hotel2Id, Size = 20, Price = 80, Count = 5 },
                new Room { Id = Guid.NewGuid(), HotelId = hotel2Id, Size = 30, Price = 120, Count = 5 },
                new Room { Id = Guid.NewGuid(), HotelId = hotel3Id, Size = 22, Price = 200, Count = 5 },
                new Room { Id = Guid.NewGuid(), HotelId = hotel3Id, Size = 40, Price = 300, Count = 5 }
            };

            modelBuilder.Entity<Room>().HasData(rooms);
        }
    }
}