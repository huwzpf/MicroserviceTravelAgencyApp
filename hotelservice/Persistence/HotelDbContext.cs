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

            Guid[] hotelIds = new Guid[43];
                    for (int i = 0; i < hotelIds.Length; i++)
                    {
                        hotelIds[i] = Guid.NewGuid();
                    }

        
            var hotels = new[]
            {
        
                new Hotel
                    {
                        Id = hotelIds[0], Name = "Pinea Resort & Spa", FoodPricePerPerson = 103, City = "Durres", Country = "albania", Street = "Rruga e Dibres"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[1], Name = "Diamma Resort", FoodPricePerPerson = 110, City = "Durres", Country = "albania", Street = "Rruga Abdyl Frasheri"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[2], Name = "Bonita Luxury Hotel", FoodPricePerPerson = 101, City = "Durres", Country = "albania", Street = "Rruga Abdyl Frasheri"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[3], Name = "Monte Carlo Vlora", FoodPricePerPerson = 44, City = "Vlora", Country = "albania", Street = "Rruga 28 Nentori"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[4], Name = "MonteCarlo Lungomare", FoodPricePerPerson = 119, City = "Vlora", Country = "albania", Street = "Rruga e Kavajes"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[5], Name = "Mel Holidays", FoodPricePerPerson = 102, City = "Durres", Country = "albania", Street = "Bulevardi Bajram Curri"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[6], Name = "Casa Durres", FoodPricePerPerson = 40, City = "Durres", Country = "albania", Street = "Rruga e Dibres"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[7], Name = "Rethymno Mare Water Park", FoodPricePerPerson = 37, City = "Chania", Country = "grecja", Street = "Leoforos Vasilissis Sofias"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[8], Name = "Aldemar Olympian Village", FoodPricePerPerson = 31, City = "Peloponez", Country = "grecja", Street = "Leoforos Alexandras"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[9], Name = "Studia Katerina", FoodPricePerPerson = 80, City = "Nero", Country = "grecja", Street = "Leoforos Vasilissis Sofias"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[10], Name = "Irini Studios", FoodPricePerPerson = 85, City = "Heraklion", Country = "grecja", Street = "Plateia Syntagmatos"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[11], Name = "Studia Maria", FoodPricePerPerson = 90, City = "Nero", Country = "grecja", Street = "Leoforos Alexandras"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[12], Name = "Dias Apartments", FoodPricePerPerson = 86, City = "Olimpijska", Country = "grecja", Street = "Plateia Syntagmatos"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[13], Name = "Turunc Resort", FoodPricePerPerson = 65, City = "Marmaris", Country = "turcja", Street = "Bağdat Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[14], Name = "Andriake Beach Club Hotel", FoodPricePerPerson = 119, City = "Turecka", Country = "turcja", Street = "Atatürk Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[15], Name = "Kimeros Park Holiday Village", FoodPricePerPerson = 90, City = "Turecka", Country = "turcja", Street = "Bağdat Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[16], Name = "Kleopatra Micador", FoodPricePerPerson = 81, City = "Turecka", Country = "turcja", Street = "Atatürk Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[17], Name = "Melissa", FoodPricePerPerson = 82, City = "Turecka", Country = "turcja", Street = "Halaskargazi Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[18], Name = "Kolibri Hotel", FoodPricePerPerson = 45, City = "Turecka", Country = "turcja", Street = "Atatürk Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[19], Name = "Evenia Zoraida Beach Resort", FoodPricePerPerson = 119, City = "Almeria", Country = "hiszpania", Street = "Paseo del Prado"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[20], Name = "Evenia Olympic Park", FoodPricePerPerson = 76, City = "Brava", Country = "hiszpania", Street = "Calle Mayor"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[21], Name = "Estival Islantilla", FoodPricePerPerson = 45, City = "Luz", Country = "hiszpania", Street = "Calle Mayor"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[22], Name = "Cartago Nova by Alegria", FoodPricePerPerson = 82, City = "Brava", Country = "hiszpania", Street = "Paseo del Prado"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[23], Name = "Catalonia", FoodPricePerPerson = 60, City = "Brava", Country = "hiszpania", Street = "Calle de Alcalá"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[24], Name = "Reymar Playa", FoodPricePerPerson = 84, City = "Maresme", Country = "hiszpania", Street = "Paseo del Prado"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[25], Name = "GHT Oasis Park & Spa", FoodPricePerPerson = 66, City = "Brava", Country = "hiszpania", Street = "Gran Vía"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[26], Name = "San Domenico", FoodPricePerPerson = 73, City = "Kalabria", Country = "wlochy", Street = "Via del Corso"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[27], Name = "Baia di Zambrone", FoodPricePerPerson = 109, City = "Kalabria", Country = "wlochy", Street = "Via Veneto"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[28], Name = "Rada Siri", FoodPricePerPerson = 70, City = "Kalabria", Country = "wlochy", Street = "Via Veneto"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[29], Name = "Hotel Orizzonte Blu", FoodPricePerPerson = 90, City = "Kalabria", Country = "wlochy", Street = "Via Nazionale"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[30], Name = "Gradac", FoodPricePerPerson = 92, City = "Riwiera", Country = "chorwacja", Street = "Kapucinska ulica"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[31], Name = "Villa Penava", FoodPricePerPerson = 100, City = "Riwiera", Country = "chorwacja", Street = "Trg bana Josipa Jelačića"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[32], Name = "Apartamenty Omiś", FoodPricePerPerson = 84, City = "Riwiera", Country = "chorwacja", Street = "Vukovarska ulica"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[33], Name = "Nano", FoodPricePerPerson = 30, City = "Riwiera", Country = "chorwacja", Street = "Maksimirska ulica"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[34], Name = "Apartamenty Makarska", FoodPricePerPerson = 37, City = "Riwiera", Country = "chorwacja", Street = "Maksimirska ulica"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[35], Name = "Marina Resort Port Ghalib", FoodPricePerPerson = 74, City = "Alam", Country = "egipt", Street = "Sharia Tahrir"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[36], Name = "Barcelo Tiran Sharm Resort", FoodPricePerPerson = 87, City = "Sheikh", Country = "egipt", Street = "Sharia Tahrir"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[37], Name = "Old Vic Resort Sharm", FoodPricePerPerson = 76, City = "Sheikh", Country = "egipt", Street = "Sharia Ramsis"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[38], Name = "Marina Lodge Port Ghalib", FoodPricePerPerson = 118, City = "Alam", Country = "egipt", Street = "Sharia Ramsis"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[39], Name = "Falcon Naama Star", FoodPricePerPerson = 62, City = "Sheikh", Country = "egipt", Street = "Sharia Salah Salem"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[40], Name = "Protels Crystal Beach Resort", FoodPricePerPerson = 86, City = "Alam", Country = "egipt", Street = "Sharia Tahrir"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[41], Name = "MG Alexander The Great", FoodPricePerPerson = 98, City = "Alam", Country = "egipt", Street = "Sharia Gamal Abdel Nasser"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[42], Name = "Bliss Nada Beach Resort", FoodPricePerPerson = 75, City = "Alam", Country = "egipt", Street = "Sharia Tahrir"
                    },
            };
            modelBuilder.Entity<Hotel>().HasData(hotels);
            
            var rooms = new[]
            {
        
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[0], Size = 2, Price = 118, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[0], Size = 3, Price = 201, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[0], Size = 4, Price = 76, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[0], Size = 5, Price = 149, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[1], Size = 2, Price = 202, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[1], Size = 3, Price = 209, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[1], Size = 4, Price = 57, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[1], Size = 5, Price = 151, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[2], Size = 2, Price = 50, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[2], Size = 3, Price = 149, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[2], Size = 4, Price = 118, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[2], Size = 5, Price = 192, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[3], Size = 2, Price = 196, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[3], Size = 3, Price = 134, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[3], Size = 4, Price = 87, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[3], Size = 5, Price = 192, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[4], Size = 2, Price = 103, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[4], Size = 3, Price = 147, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[4], Size = 4, Price = 87, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[4], Size = 5, Price = 196, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[5], Size = 2, Price = 163, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[5], Size = 3, Price = 165, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[5], Size = 4, Price = 152, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[5], Size = 5, Price = 165, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[6], Size = 2, Price = 197, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[6], Size = 3, Price = 167, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[6], Size = 4, Price = 91, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[6], Size = 5, Price = 190, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[7], Size = 2, Price = 176, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[7], Size = 3, Price = 62, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[7], Size = 4, Price = 205, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[7], Size = 5, Price = 183, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[8], Size = 2, Price = 186, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[8], Size = 3, Price = 113, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[8], Size = 4, Price = 161, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[8], Size = 5, Price = 235, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[9], Size = 2, Price = 92, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[9], Size = 3, Price = 214, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[9], Size = 4, Price = 183, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[9], Size = 5, Price = 148, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[10], Size = 2, Price = 146, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[10], Size = 3, Price = 133, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[10], Size = 4, Price = 186, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[10], Size = 5, Price = 146, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[11], Size = 2, Price = 206, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[11], Size = 3, Price = 181, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[11], Size = 4, Price = 185, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[11], Size = 5, Price = 57, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[12], Size = 2, Price = 140, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[12], Size = 3, Price = 181, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[12], Size = 4, Price = 183, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[12], Size = 5, Price = 226, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[13], Size = 2, Price = 159, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[13], Size = 3, Price = 203, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[13], Size = 4, Price = 222, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[13], Size = 5, Price = 50, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[14], Size = 2, Price = 147, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[14], Size = 3, Price = 127, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[14], Size = 4, Price = 204, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[14], Size = 5, Price = 247, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[15], Size = 2, Price = 168, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[15], Size = 3, Price = 241, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[15], Size = 4, Price = 185, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[15], Size = 5, Price = 215, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[16], Size = 2, Price = 50, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[16], Size = 3, Price = 235, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[16], Size = 4, Price = 243, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[16], Size = 5, Price = 73, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[17], Size = 2, Price = 229, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[17], Size = 3, Price = 153, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[17], Size = 4, Price = 87, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[17], Size = 5, Price = 59, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[18], Size = 2, Price = 171, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[18], Size = 3, Price = 87, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[18], Size = 4, Price = 159, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[18], Size = 5, Price = 143, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[19], Size = 2, Price = 171, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[19], Size = 3, Price = 148, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[19], Size = 4, Price = 91, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[19], Size = 5, Price = 172, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[20], Size = 2, Price = 70, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[20], Size = 3, Price = 92, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[20], Size = 4, Price = 206, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[20], Size = 5, Price = 175, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[21], Size = 2, Price = 92, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[21], Size = 3, Price = 199, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[21], Size = 4, Price = 141, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[21], Size = 5, Price = 140, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[22], Size = 2, Price = 221, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[22], Size = 3, Price = 236, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[22], Size = 4, Price = 226, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[22], Size = 5, Price = 106, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[23], Size = 2, Price = 230, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[23], Size = 3, Price = 159, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[23], Size = 4, Price = 98, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[23], Size = 5, Price = 85, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[24], Size = 2, Price = 98, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[24], Size = 3, Price = 135, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[24], Size = 4, Price = 211, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[24], Size = 5, Price = 91, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[25], Size = 2, Price = 117, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[25], Size = 3, Price = 178, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[25], Size = 4, Price = 222, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[25], Size = 5, Price = 150, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[26], Size = 2, Price = 57, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[26], Size = 3, Price = 109, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[26], Size = 4, Price = 80, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[26], Size = 5, Price = 164, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[27], Size = 2, Price = 219, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[27], Size = 3, Price = 119, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[27], Size = 4, Price = 174, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[27], Size = 5, Price = 127, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[28], Size = 2, Price = 159, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[28], Size = 3, Price = 153, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[28], Size = 4, Price = 173, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[28], Size = 5, Price = 172, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[29], Size = 2, Price = 55, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[29], Size = 3, Price = 193, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[29], Size = 4, Price = 130, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[29], Size = 5, Price = 240, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[30], Size = 2, Price = 139, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[30], Size = 3, Price = 140, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[30], Size = 4, Price = 250, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[30], Size = 5, Price = 51, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[31], Size = 2, Price = 63, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[31], Size = 3, Price = 244, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[31], Size = 4, Price = 116, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[31], Size = 5, Price = 191, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[32], Size = 2, Price = 249, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[32], Size = 3, Price = 53, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[32], Size = 4, Price = 237, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[32], Size = 5, Price = 52, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[33], Size = 2, Price = 236, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[33], Size = 3, Price = 97, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[33], Size = 4, Price = 65, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[33], Size = 5, Price = 208, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[34], Size = 2, Price = 163, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[34], Size = 3, Price = 250, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[34], Size = 4, Price = 134, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[34], Size = 5, Price = 81, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[35], Size = 2, Price = 158, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[35], Size = 3, Price = 177, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[35], Size = 4, Price = 100, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[35], Size = 5, Price = 104, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[36], Size = 2, Price = 77, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[36], Size = 3, Price = 248, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[36], Size = 4, Price = 215, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[36], Size = 5, Price = 248, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[37], Size = 2, Price = 129, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[37], Size = 3, Price = 53, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[37], Size = 4, Price = 192, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[37], Size = 5, Price = 120, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[38], Size = 2, Price = 205, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[38], Size = 3, Price = 241, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[38], Size = 4, Price = 92, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[38], Size = 5, Price = 52, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[39], Size = 2, Price = 51, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[39], Size = 3, Price = 137, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[39], Size = 4, Price = 222, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[39], Size = 5, Price = 77, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[40], Size = 2, Price = 161, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[40], Size = 3, Price = 99, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[40], Size = 4, Price = 139, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[40], Size = 5, Price = 55, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[41], Size = 2, Price = 65, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[41], Size = 3, Price = 244, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[41], Size = 4, Price = 55, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[41], Size = 5, Price = 228, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[42], Size = 2, Price = 204, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[42], Size = 3, Price = 229, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[42], Size = 4, Price = 168, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[42], Size = 5, Price = 194, Count = 3 },
                
            };

            modelBuilder.Entity<Room>().HasData(rooms);
        
        }
    }
}
        