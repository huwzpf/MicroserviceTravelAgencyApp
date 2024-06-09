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
        public DbSet<PopularHotel> PopularHotels { get; set; }

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
            
            modelBuilder.Entity<PopularHotel>()
                .HasKey(ph => ph.Id);
            
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
                        Id = hotelIds[0], Name = "Pinea Resort & Spa", FoodPricePerPerson = 83, City = "Durres", Country = "albania", Street = "Rruga e Dibres"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[1], Name = "Diamma Resort", FoodPricePerPerson = 34, City = "Durres", Country = "albania", Street = "Rruga Abdyl Frasheri"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[2], Name = "Bonita Luxury Hotel", FoodPricePerPerson = 31, City = "Durres", Country = "albania", Street = "Rruga Abdyl Frasheri"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[3], Name = "Monte Carlo Vlora", FoodPricePerPerson = 90, City = "Vlora", Country = "albania", Street = "Rruga 28 Nentori"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[4], Name = "MonteCarlo Lungomare", FoodPricePerPerson = 99, City = "Vlora", Country = "albania", Street = "Rruga e Kavajes"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[5], Name = "Mel Holidays", FoodPricePerPerson = 94, City = "Durres", Country = "albania", Street = "Bulevardi Bajram Curri"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[6], Name = "Casa Durres", FoodPricePerPerson = 74, City = "Durres", Country = "albania", Street = "Rruga e Dibres"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[7], Name = "Rethymno Mare Water Park", FoodPricePerPerson = 91, City = "Chania", Country = "grecja", Street = "Leoforos Vasilissis Sofias"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[8], Name = "Aldemar Olympian Village", FoodPricePerPerson = 43, City = "Peloponez", Country = "grecja", Street = "Leoforos Alexandras"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[9], Name = "Studia Katerina", FoodPricePerPerson = 56, City = "Nero", Country = "grecja", Street = "Leoforos Vasilissis Sofias"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[10], Name = "Irini Studios", FoodPricePerPerson = 74, City = "Heraklion", Country = "grecja", Street = "Plateia Syntagmatos"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[11], Name = "Studia Maria", FoodPricePerPerson = 110, City = "Nero", Country = "grecja", Street = "Leoforos Alexandras"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[12], Name = "Dias Apartments", FoodPricePerPerson = 31, City = "Olimpijska", Country = "grecja", Street = "Plateia Syntagmatos"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[13], Name = "Turunc Resort", FoodPricePerPerson = 109, City = "Marmaris", Country = "turcja", Street = "Bağdat Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[14], Name = "Andriake Beach Club Hotel", FoodPricePerPerson = 111, City = "Turecka", Country = "turcja", Street = "Atatürk Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[15], Name = "Kimeros Park Holiday Village", FoodPricePerPerson = 114, City = "Turecka", Country = "turcja", Street = "Bağdat Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[16], Name = "Kleopatra Micador", FoodPricePerPerson = 35, City = "Turecka", Country = "turcja", Street = "Atatürk Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[17], Name = "Melissa", FoodPricePerPerson = 50, City = "Turecka", Country = "turcja", Street = "Halaskargazi Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[18], Name = "Kolibri Hotel", FoodPricePerPerson = 107, City = "Turecka", Country = "turcja", Street = "Atatürk Caddesi"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[19], Name = "Evenia Zoraida Beach Resort", FoodPricePerPerson = 38, City = "Almeria", Country = "hiszpania", Street = "Paseo del Prado"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[20], Name = "Evenia Olympic Park", FoodPricePerPerson = 96, City = "Brava", Country = "hiszpania", Street = "Calle Mayor"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[21], Name = "Estival Islantilla", FoodPricePerPerson = 94, City = "Luz", Country = "hiszpania", Street = "Calle Mayor"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[22], Name = "Cartago Nova by Alegria", FoodPricePerPerson = 37, City = "Brava", Country = "hiszpania", Street = "Paseo del Prado"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[23], Name = "Catalonia", FoodPricePerPerson = 67, City = "Brava", Country = "hiszpania", Street = "Calle de Alcalá"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[24], Name = "Reymar Playa", FoodPricePerPerson = 106, City = "Maresme", Country = "hiszpania", Street = "Paseo del Prado"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[25], Name = "GHT Oasis Park & Spa", FoodPricePerPerson = 77, City = "Brava", Country = "hiszpania", Street = "Gran Vía"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[26], Name = "San Domenico", FoodPricePerPerson = 79, City = "Kalabria", Country = "wlochy", Street = "Via del Corso"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[27], Name = "Baia di Zambrone", FoodPricePerPerson = 47, City = "Kalabria", Country = "wlochy", Street = "Via Veneto"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[28], Name = "Rada Siri", FoodPricePerPerson = 93, City = "Kalabria", Country = "wlochy", Street = "Via Veneto"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[29], Name = "Hotel Orizzonte Blu", FoodPricePerPerson = 81, City = "Kalabria", Country = "wlochy", Street = "Via Nazionale"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[30], Name = "Gradac", FoodPricePerPerson = 116, City = "Riwiera", Country = "chorwacja", Street = "Kapucinska ulica"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[31], Name = "Villa Penava", FoodPricePerPerson = 31, City = "Riwiera", Country = "chorwacja", Street = "Trg bana Josipa Jelačića"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[32], Name = "Apartamenty Omiś", FoodPricePerPerson = 42, City = "Riwiera", Country = "chorwacja", Street = "Vukovarska ulica"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[33], Name = "Nano", FoodPricePerPerson = 88, City = "Riwiera", Country = "chorwacja", Street = "Maksimirska ulica"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[34], Name = "Apartamenty Makarska", FoodPricePerPerson = 83, City = "Riwiera", Country = "chorwacja", Street = "Maksimirska ulica"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[35], Name = "Marina Resort Port Ghalib", FoodPricePerPerson = 97, City = "Alam", Country = "egipt", Street = "Sharia Tahrir"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[36], Name = "Barcelo Tiran Sharm Resort", FoodPricePerPerson = 76, City = "Sheikh", Country = "egipt", Street = "Sharia Tahrir"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[37], Name = "Old Vic Resort Sharm", FoodPricePerPerson = 74, City = "Sheikh", Country = "egipt", Street = "Sharia Ramsis"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[38], Name = "Marina Lodge Port Ghalib", FoodPricePerPerson = 33, City = "Alam", Country = "egipt", Street = "Sharia Ramsis"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[39], Name = "Falcon Naama Star", FoodPricePerPerson = 116, City = "Sheikh", Country = "egipt", Street = "Sharia Salah Salem"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[40], Name = "Protels Crystal Beach Resort", FoodPricePerPerson = 80, City = "Alam", Country = "egipt", Street = "Sharia Tahrir"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[41], Name = "MG Alexander The Great", FoodPricePerPerson = 89, City = "Alam", Country = "egipt", Street = "Sharia Gamal Abdel Nasser"
                    },
                
                new Hotel
                    {
                        Id = hotelIds[42], Name = "Bliss Nada Beach Resort", FoodPricePerPerson = 83, City = "Alam", Country = "egipt", Street = "Sharia Tahrir"
                    },        

            };

            modelBuilder.Entity<Hotel>().HasData(hotels);
        
            var rooms = new[]
            {
        
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[0], Size = 2, Price = 119, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[0], Size = 3, Price = 95, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[0], Size = 4, Price = 123, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[0], Size = 5, Price = 215, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[1], Size = 2, Price = 145, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[1], Size = 3, Price = 138, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[1], Size = 4, Price = 74, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[1], Size = 5, Price = 205, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[2], Size = 2, Price = 186, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[2], Size = 3, Price = 247, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[2], Size = 4, Price = 164, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[2], Size = 5, Price = 69, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[3], Size = 2, Price = 84, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[3], Size = 3, Price = 147, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[3], Size = 4, Price = 78, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[3], Size = 5, Price = 110, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[4], Size = 2, Price = 193, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[4], Size = 3, Price = 182, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[4], Size = 4, Price = 238, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[4], Size = 5, Price = 70, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[5], Size = 2, Price = 219, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[5], Size = 3, Price = 109, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[5], Size = 4, Price = 78, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[5], Size = 5, Price = 143, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[6], Size = 2, Price = 104, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[6], Size = 3, Price = 136, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[6], Size = 4, Price = 177, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[6], Size = 5, Price = 105, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[7], Size = 2, Price = 211, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[7], Size = 3, Price = 77, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[7], Size = 4, Price = 169, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[7], Size = 5, Price = 84, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[8], Size = 2, Price = 239, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[8], Size = 3, Price = 208, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[8], Size = 4, Price = 161, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[8], Size = 5, Price = 64, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[9], Size = 2, Price = 129, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[9], Size = 3, Price = 234, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[9], Size = 4, Price = 84, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[9], Size = 5, Price = 216, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[10], Size = 2, Price = 165, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[10], Size = 3, Price = 88, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[10], Size = 4, Price = 210, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[10], Size = 5, Price = 119, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[11], Size = 2, Price = 130, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[11], Size = 3, Price = 97, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[11], Size = 4, Price = 165, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[11], Size = 5, Price = 72, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[12], Size = 2, Price = 153, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[12], Size = 3, Price = 125, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[12], Size = 4, Price = 183, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[12], Size = 5, Price = 84, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[13], Size = 2, Price = 207, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[13], Size = 3, Price = 131, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[13], Size = 4, Price = 146, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[13], Size = 5, Price = 119, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[14], Size = 2, Price = 132, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[14], Size = 3, Price = 244, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[14], Size = 4, Price = 243, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[14], Size = 5, Price = 111, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[15], Size = 2, Price = 148, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[15], Size = 3, Price = 168, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[15], Size = 4, Price = 230, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[15], Size = 5, Price = 111, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[16], Size = 2, Price = 201, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[16], Size = 3, Price = 219, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[16], Size = 4, Price = 76, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[16], Size = 5, Price = 63, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[17], Size = 2, Price = 175, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[17], Size = 3, Price = 245, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[17], Size = 4, Price = 50, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[17], Size = 5, Price = 219, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[18], Size = 2, Price = 215, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[18], Size = 3, Price = 164, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[18], Size = 4, Price = 163, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[18], Size = 5, Price = 247, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[19], Size = 2, Price = 76, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[19], Size = 3, Price = 149, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[19], Size = 4, Price = 197, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[19], Size = 5, Price = 237, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[20], Size = 2, Price = 87, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[20], Size = 3, Price = 247, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[20], Size = 4, Price = 70, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[20], Size = 5, Price = 184, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[21], Size = 2, Price = 242, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[21], Size = 3, Price = 132, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[21], Size = 4, Price = 142, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[21], Size = 5, Price = 154, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[22], Size = 2, Price = 233, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[22], Size = 3, Price = 204, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[22], Size = 4, Price = 171, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[22], Size = 5, Price = 94, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[23], Size = 2, Price = 53, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[23], Size = 3, Price = 92, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[23], Size = 4, Price = 250, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[23], Size = 5, Price = 241, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[24], Size = 2, Price = 190, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[24], Size = 3, Price = 112, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[24], Size = 4, Price = 152, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[24], Size = 5, Price = 177, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[25], Size = 2, Price = 60, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[25], Size = 3, Price = 190, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[25], Size = 4, Price = 77, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[25], Size = 5, Price = 217, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[26], Size = 2, Price = 146, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[26], Size = 3, Price = 107, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[26], Size = 4, Price = 164, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[26], Size = 5, Price = 162, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[27], Size = 2, Price = 213, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[27], Size = 3, Price = 131, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[27], Size = 4, Price = 140, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[27], Size = 5, Price = 250, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[28], Size = 2, Price = 178, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[28], Size = 3, Price = 216, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[28], Size = 4, Price = 98, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[28], Size = 5, Price = 165, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[29], Size = 2, Price = 118, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[29], Size = 3, Price = 73, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[29], Size = 4, Price = 166, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[29], Size = 5, Price = 81, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[30], Size = 2, Price = 111, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[30], Size = 3, Price = 110, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[30], Size = 4, Price = 95, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[30], Size = 5, Price = 239, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[31], Size = 2, Price = 121, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[31], Size = 3, Price = 187, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[31], Size = 4, Price = 201, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[31], Size = 5, Price = 73, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[32], Size = 2, Price = 84, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[32], Size = 3, Price = 145, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[32], Size = 4, Price = 221, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[32], Size = 5, Price = 108, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[33], Size = 2, Price = 220, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[33], Size = 3, Price = 96, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[33], Size = 4, Price = 143, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[33], Size = 5, Price = 71, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[34], Size = 2, Price = 179, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[34], Size = 3, Price = 155, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[34], Size = 4, Price = 177, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[34], Size = 5, Price = 195, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[35], Size = 2, Price = 76, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[35], Size = 3, Price = 195, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[35], Size = 4, Price = 180, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[35], Size = 5, Price = 210, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[36], Size = 2, Price = 153, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[36], Size = 3, Price = 221, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[36], Size = 4, Price = 223, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[36], Size = 5, Price = 135, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[37], Size = 2, Price = 66, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[37], Size = 3, Price = 179, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[37], Size = 4, Price = 125, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[37], Size = 5, Price = 147, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[38], Size = 2, Price = 176, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[38], Size = 3, Price = 95, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[38], Size = 4, Price = 127, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[38], Size = 5, Price = 88, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[39], Size = 2, Price = 158, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[39], Size = 3, Price = 133, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[39], Size = 4, Price = 95, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[39], Size = 5, Price = 154, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[40], Size = 2, Price = 129, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[40], Size = 3, Price = 62, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[40], Size = 4, Price = 162, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[40], Size = 5, Price = 191, Count = 3 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[41], Size = 2, Price = 188, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[41], Size = 3, Price = 90, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[41], Size = 4, Price = 166, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[41], Size = 5, Price = 209, Count = 2 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[42], Size = 2, Price = 123, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[42], Size = 3, Price = 219, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[42], Size = 4, Price = 218, Count = 1 },
                
                new Room { Id = Guid.NewGuid(), HotelId = hotelIds[42], Size = 5, Price = 235, Count = 1 },
                
            };

            modelBuilder.Entity<Room>().HasData(rooms);
        
        }
    }
}
        