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
        public DbSet<PopularDestination> PopularDestinations { get; set; }
        public DbSet<PopularTransportType> PopularTransportTypes { get; set; }

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

            modelBuilder.Entity<PopularDestination>()
                .HasKey(to => to.Id);

            modelBuilder.Entity<PopularTransportType>()
                .HasKey(to => to.Id);
            
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

            Guid[] TransportIds = new Guid[200];
                    for (int i = 0; i < TransportIds.Length; i++)
                    {
                        TransportIds[i] = Guid.NewGuid();
                    }

        
        var transportOptions = new[]
            {
                
    new CommandTransportOption
    {
        Id = TransportIds[0], Start = DateTime.UtcNow.AddDays(81).AddHours(10), 
        End = DateTime.UtcNow.AddDays(81).AddHours(18), 
        PriceAdult = 107, Type = "Bus", InitialSeats = 88,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[1], Start = DateTime.UtcNow.AddDays(51).AddHours(6), 
        End = DateTime.UtcNow.AddDays(51).AddHours(9), 
        PriceAdult = 271, Type = "Plane", InitialSeats = 111,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[2], Start = DateTime.UtcNow.AddDays(27).AddHours(22), 
        End = DateTime.UtcNow.AddDays(28).AddHours(1), 
        PriceAdult = 211, Type = "Bus", InitialSeats = 161,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[3], Start = DateTime.UtcNow.AddDays(1).AddHours(3), 
        End = DateTime.UtcNow.AddDays(1).AddHours(7), 
        PriceAdult = 52, Type = "Train", InitialSeats = 72,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[4], Start = DateTime.UtcNow.AddDays(71).AddHours(23), 
        End = DateTime.UtcNow.AddDays(72).AddHours(6), 
        PriceAdult = 186, Type = "Bus", InitialSeats = 172,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[5], Start = DateTime.UtcNow.AddDays(11).AddHours(22), 
        End = DateTime.UtcNow.AddDays(12).AddHours(1), 
        PriceAdult = 121, Type = "Plane", InitialSeats = 173,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[6], Start = DateTime.UtcNow.AddDays(64).AddHours(14), 
        End = DateTime.UtcNow.AddDays(64).AddHours(18), 
        PriceAdult = 296, Type = "Train", InitialSeats = 51,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[7], Start = DateTime.UtcNow.AddDays(13).AddHours(0), 
        End = DateTime.UtcNow.AddDays(13).AddHours(8), 
        PriceAdult = 295, Type = "Plane", InitialSeats = 166,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[8], Start = DateTime.UtcNow.AddDays(85).AddHours(9), 
        End = DateTime.UtcNow.AddDays(85).AddHours(13), 
        PriceAdult = 187, Type = "Plane", InitialSeats = 122,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[9], Start = DateTime.UtcNow.AddDays(88).AddHours(21), 
        End = DateTime.UtcNow.AddDays(89).AddHours(7), 
        PriceAdult = 240, Type = "Bus", InitialSeats = 116,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[10], Start = DateTime.UtcNow.AddDays(21).AddHours(5), 
        End = DateTime.UtcNow.AddDays(21).AddHours(13), 
        PriceAdult = 257, Type = "Plane", InitialSeats = 76,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[11], Start = DateTime.UtcNow.AddDays(89).AddHours(2), 
        End = DateTime.UtcNow.AddDays(89).AddHours(8), 
        PriceAdult = 192, Type = "Bus", InitialSeats = 65,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[12], Start = DateTime.UtcNow.AddDays(57).AddHours(10), 
        End = DateTime.UtcNow.AddDays(57).AddHours(12), 
        PriceAdult = 270, Type = "Plane", InitialSeats = 63,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[13], Start = DateTime.UtcNow.AddDays(5).AddHours(21), 
        End = DateTime.UtcNow.AddDays(5).AddHours(24), 
        PriceAdult = 200, Type = "Bus", InitialSeats = 65,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[14], Start = DateTime.UtcNow.AddDays(31).AddHours(16), 
        End = DateTime.UtcNow.AddDays(31).AddHours(24), 
        PriceAdult = 160, Type = "Bus", InitialSeats = 137,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[15], Start = DateTime.UtcNow.AddDays(45).AddHours(16), 
        End = DateTime.UtcNow.AddDays(46).AddHours(3), 
        PriceAdult = 195, Type = "Train", InitialSeats = 60,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[16], Start = DateTime.UtcNow.AddDays(80).AddHours(17), 
        End = DateTime.UtcNow.AddDays(81).AddHours(4), 
        PriceAdult = 128, Type = "Train", InitialSeats = 109,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[17], Start = DateTime.UtcNow.AddDays(41).AddHours(7), 
        End = DateTime.UtcNow.AddDays(41).AddHours(11), 
        PriceAdult = 79, Type = "Plane", InitialSeats = 176,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[18], Start = DateTime.UtcNow.AddDays(67).AddHours(4), 
        End = DateTime.UtcNow.AddDays(67).AddHours(10), 
        PriceAdult = 179, Type = "Bus", InitialSeats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[19], Start = DateTime.UtcNow.AddDays(79).AddHours(21), 
        End = DateTime.UtcNow.AddDays(79).AddHours(23), 
        PriceAdult = 71, Type = "Plane", InitialSeats = 177,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[20], Start = DateTime.UtcNow.AddDays(52).AddHours(10), 
        End = DateTime.UtcNow.AddDays(52).AddHours(20), 
        PriceAdult = 269, Type = "Plane", InitialSeats = 125,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[21], Start = DateTime.UtcNow.AddDays(81).AddHours(15), 
        End = DateTime.UtcNow.AddDays(81).AddHours(20), 
        PriceAdult = 190, Type = "Train", InitialSeats = 105,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[22], Start = DateTime.UtcNow.AddDays(14).AddHours(16), 
        End = DateTime.UtcNow.AddDays(14).AddHours(21), 
        PriceAdult = 67, Type = "Train", InitialSeats = 194,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[23], Start = DateTime.UtcNow.AddDays(86).AddHours(12), 
        End = DateTime.UtcNow.AddDays(86).AddHours(18), 
        PriceAdult = 299, Type = "Bus", InitialSeats = 64,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[24], Start = DateTime.UtcNow.AddDays(18).AddHours(6), 
        End = DateTime.UtcNow.AddDays(18).AddHours(16), 
        PriceAdult = 127, Type = "Train", InitialSeats = 154,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[25], Start = DateTime.UtcNow.AddDays(79).AddHours(23), 
        End = DateTime.UtcNow.AddDays(80).AddHours(5), 
        PriceAdult = 82, Type = "Plane", InitialSeats = 98,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[26], Start = DateTime.UtcNow.AddDays(8).AddHours(15), 
        End = DateTime.UtcNow.AddDays(8).AddHours(17), 
        PriceAdult = 266, Type = "Train", InitialSeats = 168,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[27], Start = DateTime.UtcNow.AddDays(68).AddHours(0), 
        End = DateTime.UtcNow.AddDays(68).AddHours(6), 
        PriceAdult = 94, Type = "Bus", InitialSeats = 74,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[28], Start = DateTime.UtcNow.AddDays(48).AddHours(19), 
        End = DateTime.UtcNow.AddDays(49).AddHours(2), 
        PriceAdult = 126, Type = "Train", InitialSeats = 131,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[29], Start = DateTime.UtcNow.AddDays(20).AddHours(17), 
        End = DateTime.UtcNow.AddDays(20).AddHours(24), 
        PriceAdult = 242, Type = "Train", InitialSeats = 191,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[30], Start = DateTime.UtcNow.AddDays(65).AddHours(3), 
        End = DateTime.UtcNow.AddDays(65).AddHours(7), 
        PriceAdult = 182, Type = "Train", InitialSeats = 142,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[31], Start = DateTime.UtcNow.AddDays(52).AddHours(18), 
        End = DateTime.UtcNow.AddDays(53).AddHours(1), 
        PriceAdult = 108, Type = "Train", InitialSeats = 112,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[32], Start = DateTime.UtcNow.AddDays(62).AddHours(13), 
        End = DateTime.UtcNow.AddDays(62).AddHours(22), 
        PriceAdult = 106, Type = "Train", InitialSeats = 163,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[33], Start = DateTime.UtcNow.AddDays(6).AddHours(8), 
        End = DateTime.UtcNow.AddDays(6).AddHours(10), 
        PriceAdult = 66, Type = "Bus", InitialSeats = 180,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[34], Start = DateTime.UtcNow.AddDays(26).AddHours(15), 
        End = DateTime.UtcNow.AddDays(26).AddHours(21), 
        PriceAdult = 185, Type = "Train", InitialSeats = 184,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[35], Start = DateTime.UtcNow.AddDays(62).AddHours(1), 
        End = DateTime.UtcNow.AddDays(62).AddHours(11), 
        PriceAdult = 63, Type = "Train", InitialSeats = 97,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[36], Start = DateTime.UtcNow.AddDays(12).AddHours(17), 
        End = DateTime.UtcNow.AddDays(13).AddHours(5), 
        PriceAdult = 278, Type = "Bus", InitialSeats = 60,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[37], Start = DateTime.UtcNow.AddDays(5).AddHours(17), 
        End = DateTime.UtcNow.AddDays(6).AddHours(5), 
        PriceAdult = 170, Type = "Plane", InitialSeats = 57,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[38], Start = DateTime.UtcNow.AddDays(88).AddHours(6), 
        End = DateTime.UtcNow.AddDays(88).AddHours(10), 
        PriceAdult = 109, Type = "Bus", InitialSeats = 166,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[39], Start = DateTime.UtcNow.AddDays(31).AddHours(6), 
        End = DateTime.UtcNow.AddDays(31).AddHours(15), 
        PriceAdult = 78, Type = "Bus", InitialSeats = 92,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[40], Start = DateTime.UtcNow.AddDays(25).AddHours(4), 
        End = DateTime.UtcNow.AddDays(25).AddHours(9), 
        PriceAdult = 206, Type = "Bus", InitialSeats = 137,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[41], Start = DateTime.UtcNow.AddDays(61).AddHours(18), 
        End = DateTime.UtcNow.AddDays(61).AddHours(22), 
        PriceAdult = 151, Type = "Bus", InitialSeats = 190,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[42], Start = DateTime.UtcNow.AddDays(46).AddHours(7), 
        End = DateTime.UtcNow.AddDays(46).AddHours(10), 
        PriceAdult = 208, Type = "Train", InitialSeats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[43], Start = DateTime.UtcNow.AddDays(31).AddHours(21), 
        End = DateTime.UtcNow.AddDays(32).AddHours(4), 
        PriceAdult = 67, Type = "Train", InitialSeats = 195,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[44], Start = DateTime.UtcNow.AddDays(11).AddHours(14), 
        End = DateTime.UtcNow.AddDays(12).AddHours(1), 
        PriceAdult = 54, Type = "Plane", InitialSeats = 197,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[45], Start = DateTime.UtcNow.AddDays(78).AddHours(7), 
        End = DateTime.UtcNow.AddDays(78).AddHours(13), 
        PriceAdult = 110, Type = "Bus", InitialSeats = 120,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[46], Start = DateTime.UtcNow.AddDays(28).AddHours(22), 
        End = DateTime.UtcNow.AddDays(29).AddHours(2), 
        PriceAdult = 194, Type = "Train", InitialSeats = 79,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[47], Start = DateTime.UtcNow.AddDays(7).AddHours(15), 
        End = DateTime.UtcNow.AddDays(7).AddHours(19), 
        PriceAdult = 169, Type = "Bus", InitialSeats = 136,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[48], Start = DateTime.UtcNow.AddDays(34).AddHours(7), 
        End = DateTime.UtcNow.AddDays(34).AddHours(9), 
        PriceAdult = 187, Type = "Train", InitialSeats = 143,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[49], Start = DateTime.UtcNow.AddDays(10).AddHours(9), 
        End = DateTime.UtcNow.AddDays(10).AddHours(15), 
        PriceAdult = 295, Type = "Train", InitialSeats = 142,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[50], Start = DateTime.UtcNow.AddDays(78).AddHours(23), 
        End = DateTime.UtcNow.AddDays(79).AddHours(11), 
        PriceAdult = 231, Type = "Plane", InitialSeats = 79,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[51], Start = DateTime.UtcNow.AddDays(48).AddHours(11), 
        End = DateTime.UtcNow.AddDays(48).AddHours(21), 
        PriceAdult = 81, Type = "Bus", InitialSeats = 162,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[52], Start = DateTime.UtcNow.AddDays(87).AddHours(21), 
        End = DateTime.UtcNow.AddDays(88).AddHours(4), 
        PriceAdult = 143, Type = "Train", InitialSeats = 79,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[53], Start = DateTime.UtcNow.AddDays(63).AddHours(6), 
        End = DateTime.UtcNow.AddDays(63).AddHours(17), 
        PriceAdult = 195, Type = "Train", InitialSeats = 62,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[54], Start = DateTime.UtcNow.AddDays(85).AddHours(8), 
        End = DateTime.UtcNow.AddDays(85).AddHours(10), 
        PriceAdult = 226, Type = "Plane", InitialSeats = 97,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[55], Start = DateTime.UtcNow.AddDays(28).AddHours(16), 
        End = DateTime.UtcNow.AddDays(28).AddHours(19), 
        PriceAdult = 124, Type = "Bus", InitialSeats = 115,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[56], Start = DateTime.UtcNow.AddDays(55).AddHours(23), 
        End = DateTime.UtcNow.AddDays(56).AddHours(7), 
        PriceAdult = 183, Type = "Bus", InitialSeats = 187,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[57], Start = DateTime.UtcNow.AddDays(22).AddHours(16), 
        End = DateTime.UtcNow.AddDays(22).AddHours(19), 
        PriceAdult = 123, Type = "Plane", InitialSeats = 175,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[58], Start = DateTime.UtcNow.AddDays(5).AddHours(8), 
        End = DateTime.UtcNow.AddDays(5).AddHours(18), 
        PriceAdult = 238, Type = "Plane", InitialSeats = 151,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[59], Start = DateTime.UtcNow.AddDays(53).AddHours(21), 
        End = DateTime.UtcNow.AddDays(53).AddHours(23), 
        PriceAdult = 226, Type = "Plane", InitialSeats = 160,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[60], Start = DateTime.UtcNow.AddDays(17).AddHours(10), 
        End = DateTime.UtcNow.AddDays(17).AddHours(15), 
        PriceAdult = 139, Type = "Train", InitialSeats = 116,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[61], Start = DateTime.UtcNow.AddDays(72).AddHours(7), 
        End = DateTime.UtcNow.AddDays(72).AddHours(13), 
        PriceAdult = 269, Type = "Bus", InitialSeats = 92,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[62], Start = DateTime.UtcNow.AddDays(25).AddHours(7), 
        End = DateTime.UtcNow.AddDays(25).AddHours(15), 
        PriceAdult = 81, Type = "Bus", InitialSeats = 194,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[63], Start = DateTime.UtcNow.AddDays(24).AddHours(17), 
        End = DateTime.UtcNow.AddDays(24).AddHours(22), 
        PriceAdult = 241, Type = "Bus", InitialSeats = 88,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[64], Start = DateTime.UtcNow.AddDays(25).AddHours(9), 
        End = DateTime.UtcNow.AddDays(25).AddHours(15), 
        PriceAdult = 122, Type = "Bus", InitialSeats = 175,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[65], Start = DateTime.UtcNow.AddDays(86).AddHours(5), 
        End = DateTime.UtcNow.AddDays(86).AddHours(14), 
        PriceAdult = 256, Type = "Plane", InitialSeats = 132,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[66], Start = DateTime.UtcNow.AddDays(12).AddHours(9), 
        End = DateTime.UtcNow.AddDays(12).AddHours(19), 
        PriceAdult = 131, Type = "Bus", InitialSeats = 121,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[67], Start = DateTime.UtcNow.AddDays(51).AddHours(19), 
        End = DateTime.UtcNow.AddDays(51).AddHours(23), 
        PriceAdult = 238, Type = "Bus", InitialSeats = 103,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[68], Start = DateTime.UtcNow.AddDays(14).AddHours(17), 
        End = DateTime.UtcNow.AddDays(15).AddHours(1), 
        PriceAdult = 112, Type = "Plane", InitialSeats = 83,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[69], Start = DateTime.UtcNow.AddDays(77).AddHours(23), 
        End = DateTime.UtcNow.AddDays(78).AddHours(7), 
        PriceAdult = 265, Type = "Train", InitialSeats = 105,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[70], Start = DateTime.UtcNow.AddDays(37).AddHours(23), 
        End = DateTime.UtcNow.AddDays(38).AddHours(5), 
        PriceAdult = 161, Type = "Train", InitialSeats = 53,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[71], Start = DateTime.UtcNow.AddDays(66).AddHours(4), 
        End = DateTime.UtcNow.AddDays(66).AddHours(11), 
        PriceAdult = 286, Type = "Plane", InitialSeats = 136,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[72], Start = DateTime.UtcNow.AddDays(11).AddHours(11), 
        End = DateTime.UtcNow.AddDays(11).AddHours(13), 
        PriceAdult = 97, Type = "Plane", InitialSeats = 200,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[73], Start = DateTime.UtcNow.AddDays(34).AddHours(21), 
        End = DateTime.UtcNow.AddDays(35).AddHours(7), 
        PriceAdult = 269, Type = "Bus", InitialSeats = 79,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[74], Start = DateTime.UtcNow.AddDays(67).AddHours(11), 
        End = DateTime.UtcNow.AddDays(67).AddHours(16), 
        PriceAdult = 162, Type = "Train", InitialSeats = 101,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[75], Start = DateTime.UtcNow.AddDays(29).AddHours(6), 
        End = DateTime.UtcNow.AddDays(29).AddHours(17), 
        PriceAdult = 113, Type = "Train", InitialSeats = 65,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[76], Start = DateTime.UtcNow.AddDays(11).AddHours(6), 
        End = DateTime.UtcNow.AddDays(11).AddHours(18), 
        PriceAdult = 99, Type = "Plane", InitialSeats = 154,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[77], Start = DateTime.UtcNow.AddDays(51).AddHours(12), 
        End = DateTime.UtcNow.AddDays(51).AddHours(17), 
        PriceAdult = 265, Type = "Bus", InitialSeats = 105,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[78], Start = DateTime.UtcNow.AddDays(19).AddHours(17), 
        End = DateTime.UtcNow.AddDays(19).AddHours(20), 
        PriceAdult = 91, Type = "Train", InitialSeats = 82,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[79], Start = DateTime.UtcNow.AddDays(56).AddHours(15), 
        End = DateTime.UtcNow.AddDays(57).AddHours(2), 
        PriceAdult = 62, Type = "Train", InitialSeats = 175,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[80], Start = DateTime.UtcNow.AddDays(35).AddHours(4), 
        End = DateTime.UtcNow.AddDays(35).AddHours(10), 
        PriceAdult = 225, Type = "Plane", InitialSeats = 174,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[81], Start = DateTime.UtcNow.AddDays(53).AddHours(11), 
        End = DateTime.UtcNow.AddDays(53).AddHours(19), 
        PriceAdult = 201, Type = "Bus", InitialSeats = 72,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[82], Start = DateTime.UtcNow.AddDays(90).AddHours(16), 
        End = DateTime.UtcNow.AddDays(91).AddHours(4), 
        PriceAdult = 142, Type = "Train", InitialSeats = 63,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[83], Start = DateTime.UtcNow.AddDays(85).AddHours(0), 
        End = DateTime.UtcNow.AddDays(85).AddHours(5), 
        PriceAdult = 234, Type = "Train", InitialSeats = 198,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[84], Start = DateTime.UtcNow.AddDays(57).AddHours(14), 
        End = DateTime.UtcNow.AddDays(57).AddHours(19), 
        PriceAdult = 221, Type = "Plane", InitialSeats = 185,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[85], Start = DateTime.UtcNow.AddDays(14).AddHours(23), 
        End = DateTime.UtcNow.AddDays(15).AddHours(5), 
        PriceAdult = 122, Type = "Plane", InitialSeats = 67,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[86], Start = DateTime.UtcNow.AddDays(34).AddHours(3), 
        End = DateTime.UtcNow.AddDays(34).AddHours(5), 
        PriceAdult = 207, Type = "Train", InitialSeats = 89,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[87], Start = DateTime.UtcNow.AddDays(17).AddHours(16), 
        End = DateTime.UtcNow.AddDays(17).AddHours(24), 
        PriceAdult = 210, Type = "Train", InitialSeats = 79,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[88], Start = DateTime.UtcNow.AddDays(82).AddHours(15), 
        End = DateTime.UtcNow.AddDays(82).AddHours(24), 
        PriceAdult = 170, Type = "Plane", InitialSeats = 68,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[89], Start = DateTime.UtcNow.AddDays(32).AddHours(12), 
        End = DateTime.UtcNow.AddDays(32).AddHours(14), 
        PriceAdult = 292, Type = "Plane", InitialSeats = 85,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[90], Start = DateTime.UtcNow.AddDays(66).AddHours(11), 
        End = DateTime.UtcNow.AddDays(66).AddHours(20), 
        PriceAdult = 230, Type = "Plane", InitialSeats = 157,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[91], Start = DateTime.UtcNow.AddDays(90).AddHours(4), 
        End = DateTime.UtcNow.AddDays(90).AddHours(6), 
        PriceAdult = 189, Type = "Plane", InitialSeats = 93,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[92], Start = DateTime.UtcNow.AddDays(11).AddHours(0), 
        End = DateTime.UtcNow.AddDays(11).AddHours(10), 
        PriceAdult = 214, Type = "Train", InitialSeats = 116,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[93], Start = DateTime.UtcNow.AddDays(51).AddHours(8), 
        End = DateTime.UtcNow.AddDays(51).AddHours(17), 
        PriceAdult = 104, Type = "Train", InitialSeats = 184,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[94], Start = DateTime.UtcNow.AddDays(14).AddHours(1), 
        End = DateTime.UtcNow.AddDays(14).AddHours(9), 
        PriceAdult = 186, Type = "Bus", InitialSeats = 100,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[95], Start = DateTime.UtcNow.AddDays(45).AddHours(23), 
        End = DateTime.UtcNow.AddDays(46).AddHours(1), 
        PriceAdult = 244, Type = "Bus", InitialSeats = 71,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[96], Start = DateTime.UtcNow.AddDays(88).AddHours(10), 
        End = DateTime.UtcNow.AddDays(88).AddHours(15), 
        PriceAdult = 78, Type = "Train", InitialSeats = 52,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[97], Start = DateTime.UtcNow.AddDays(59).AddHours(20), 
        End = DateTime.UtcNow.AddDays(60).AddHours(6), 
        PriceAdult = 134, Type = "Train", InitialSeats = 171,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[98], Start = DateTime.UtcNow.AddDays(14).AddHours(17), 
        End = DateTime.UtcNow.AddDays(14).AddHours(21), 
        PriceAdult = 220, Type = "Plane", InitialSeats = 70,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[99], Start = DateTime.UtcNow.AddDays(63).AddHours(5), 
        End = DateTime.UtcNow.AddDays(63).AddHours(17), 
        PriceAdult = 144, Type = "Bus", InitialSeats = 134,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[100], Start = DateTime.UtcNow.AddDays(74).AddHours(18), 
        End = DateTime.UtcNow.AddDays(75).AddHours(4), 
        PriceAdult = 217, Type = "Bus", InitialSeats = 54,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[101], Start = DateTime.UtcNow.AddDays(42).AddHours(16), 
        End = DateTime.UtcNow.AddDays(43).AddHours(1), 
        PriceAdult = 155, Type = "Train", InitialSeats = 73,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[102], Start = DateTime.UtcNow.AddDays(45).AddHours(1), 
        End = DateTime.UtcNow.AddDays(45).AddHours(3), 
        PriceAdult = 54, Type = "Plane", InitialSeats = 194,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[103], Start = DateTime.UtcNow.AddDays(16).AddHours(15), 
        End = DateTime.UtcNow.AddDays(16).AddHours(19), 
        PriceAdult = 299, Type = "Plane", InitialSeats = 197,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[104], Start = DateTime.UtcNow.AddDays(45).AddHours(12), 
        End = DateTime.UtcNow.AddDays(45).AddHours(18), 
        PriceAdult = 125, Type = "Plane", InitialSeats = 167,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[105], Start = DateTime.UtcNow.AddDays(66).AddHours(3), 
        End = DateTime.UtcNow.AddDays(66).AddHours(11), 
        PriceAdult = 169, Type = "Bus", InitialSeats = 51,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[106], Start = DateTime.UtcNow.AddDays(67).AddHours(1), 
        End = DateTime.UtcNow.AddDays(67).AddHours(10), 
        PriceAdult = 135, Type = "Bus", InitialSeats = 161,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[107], Start = DateTime.UtcNow.AddDays(59).AddHours(22), 
        End = DateTime.UtcNow.AddDays(60).AddHours(1), 
        PriceAdult = 109, Type = "Bus", InitialSeats = 200,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[108], Start = DateTime.UtcNow.AddDays(35).AddHours(1), 
        End = DateTime.UtcNow.AddDays(35).AddHours(7), 
        PriceAdult = 138, Type = "Plane", InitialSeats = 99,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[109], Start = DateTime.UtcNow.AddDays(48).AddHours(21), 
        End = DateTime.UtcNow.AddDays(49).AddHours(6), 
        PriceAdult = 182, Type = "Plane", InitialSeats = 164,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[110], Start = DateTime.UtcNow.AddDays(29).AddHours(8), 
        End = DateTime.UtcNow.AddDays(29).AddHours(17), 
        PriceAdult = 161, Type = "Bus", InitialSeats = 123,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[111], Start = DateTime.UtcNow.AddDays(37).AddHours(23), 
        End = DateTime.UtcNow.AddDays(38).AddHours(6), 
        PriceAdult = 54, Type = "Bus", InitialSeats = 184,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[112], Start = DateTime.UtcNow.AddDays(82).AddHours(0), 
        End = DateTime.UtcNow.AddDays(82).AddHours(10), 
        PriceAdult = 259, Type = "Plane", InitialSeats = 191,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[113], Start = DateTime.UtcNow.AddDays(26).AddHours(22), 
        End = DateTime.UtcNow.AddDays(27).AddHours(8), 
        PriceAdult = 156, Type = "Train", InitialSeats = 66,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[114], Start = DateTime.UtcNow.AddDays(25).AddHours(22), 
        End = DateTime.UtcNow.AddDays(25).AddHours(24), 
        PriceAdult = 175, Type = "Train", InitialSeats = 194,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[115], Start = DateTime.UtcNow.AddDays(64).AddHours(23), 
        End = DateTime.UtcNow.AddDays(65).AddHours(11), 
        PriceAdult = 215, Type = "Plane", InitialSeats = 107,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[116], Start = DateTime.UtcNow.AddDays(64).AddHours(22), 
        End = DateTime.UtcNow.AddDays(65).AddHours(4), 
        PriceAdult = 239, Type = "Plane", InitialSeats = 182,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[117], Start = DateTime.UtcNow.AddDays(36).AddHours(12), 
        End = DateTime.UtcNow.AddDays(36).AddHours(14), 
        PriceAdult = 283, Type = "Plane", InitialSeats = 164,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[118], Start = DateTime.UtcNow.AddDays(28).AddHours(9), 
        End = DateTime.UtcNow.AddDays(28).AddHours(13), 
        PriceAdult = 189, Type = "Train", InitialSeats = 165,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[119], Start = DateTime.UtcNow.AddDays(40).AddHours(4), 
        End = DateTime.UtcNow.AddDays(40).AddHours(16), 
        PriceAdult = 107, Type = "Train", InitialSeats = 90,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[120], Start = DateTime.UtcNow.AddDays(2).AddHours(3), 
        End = DateTime.UtcNow.AddDays(2).AddHours(9), 
        PriceAdult = 134, Type = "Train", InitialSeats = 84,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[121], Start = DateTime.UtcNow.AddDays(35).AddHours(12), 
        End = DateTime.UtcNow.AddDays(35).AddHours(23), 
        PriceAdult = 248, Type = "Plane", InitialSeats = 93,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[122], Start = DateTime.UtcNow.AddDays(52).AddHours(9), 
        End = DateTime.UtcNow.AddDays(52).AddHours(14), 
        PriceAdult = 171, Type = "Train", InitialSeats = 112,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[123], Start = DateTime.UtcNow.AddDays(37).AddHours(16), 
        End = DateTime.UtcNow.AddDays(38).AddHours(3), 
        PriceAdult = 248, Type = "Plane", InitialSeats = 126,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[124], Start = DateTime.UtcNow.AddDays(31).AddHours(19), 
        End = DateTime.UtcNow.AddDays(32).AddHours(2), 
        PriceAdult = 231, Type = "Train", InitialSeats = 115,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[125], Start = DateTime.UtcNow.AddDays(35).AddHours(1), 
        End = DateTime.UtcNow.AddDays(35).AddHours(4), 
        PriceAdult = 115, Type = "Plane", InitialSeats = 162,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[126], Start = DateTime.UtcNow.AddDays(32).AddHours(5), 
        End = DateTime.UtcNow.AddDays(32).AddHours(13), 
        PriceAdult = 140, Type = "Train", InitialSeats = 123,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[127], Start = DateTime.UtcNow.AddDays(45).AddHours(4), 
        End = DateTime.UtcNow.AddDays(45).AddHours(16), 
        PriceAdult = 180, Type = "Train", InitialSeats = 138,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[128], Start = DateTime.UtcNow.AddDays(40).AddHours(2), 
        End = DateTime.UtcNow.AddDays(40).AddHours(7), 
        PriceAdult = 293, Type = "Train", InitialSeats = 147,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[129], Start = DateTime.UtcNow.AddDays(12).AddHours(3), 
        End = DateTime.UtcNow.AddDays(12).AddHours(15), 
        PriceAdult = 174, Type = "Plane", InitialSeats = 173,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[130], Start = DateTime.UtcNow.AddDays(84).AddHours(3), 
        End = DateTime.UtcNow.AddDays(84).AddHours(15), 
        PriceAdult = 108, Type = "Bus", InitialSeats = 84,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[131], Start = DateTime.UtcNow.AddDays(64).AddHours(20), 
        End = DateTime.UtcNow.AddDays(65).AddHours(6), 
        PriceAdult = 145, Type = "Plane", InitialSeats = 109,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[132], Start = DateTime.UtcNow.AddDays(76).AddHours(4), 
        End = DateTime.UtcNow.AddDays(76).AddHours(14), 
        PriceAdult = 212, Type = "Plane", InitialSeats = 192,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[133], Start = DateTime.UtcNow.AddDays(44).AddHours(6), 
        End = DateTime.UtcNow.AddDays(44).AddHours(16), 
        PriceAdult = 159, Type = "Train", InitialSeats = 65,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[134], Start = DateTime.UtcNow.AddDays(15).AddHours(20), 
        End = DateTime.UtcNow.AddDays(15).AddHours(24), 
        PriceAdult = 288, Type = "Bus", InitialSeats = 195,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[135], Start = DateTime.UtcNow.AddDays(65).AddHours(6), 
        End = DateTime.UtcNow.AddDays(65).AddHours(13), 
        PriceAdult = 82, Type = "Train", InitialSeats = 136,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[136], Start = DateTime.UtcNow.AddDays(82).AddHours(1), 
        End = DateTime.UtcNow.AddDays(82).AddHours(12), 
        PriceAdult = 217, Type = "Train", InitialSeats = 160,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[137], Start = DateTime.UtcNow.AddDays(48).AddHours(7), 
        End = DateTime.UtcNow.AddDays(48).AddHours(14), 
        PriceAdult = 70, Type = "Plane", InitialSeats = 149,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[138], Start = DateTime.UtcNow.AddDays(75).AddHours(23), 
        End = DateTime.UtcNow.AddDays(76).AddHours(1), 
        PriceAdult = 265, Type = "Train", InitialSeats = 126,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[139], Start = DateTime.UtcNow.AddDays(78).AddHours(10), 
        End = DateTime.UtcNow.AddDays(78).AddHours(18), 
        PriceAdult = 256, Type = "Train", InitialSeats = 103,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[140], Start = DateTime.UtcNow.AddDays(8).AddHours(2), 
        End = DateTime.UtcNow.AddDays(8).AddHours(6), 
        PriceAdult = 264, Type = "Plane", InitialSeats = 104,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[141], Start = DateTime.UtcNow.AddDays(30).AddHours(5), 
        End = DateTime.UtcNow.AddDays(30).AddHours(13), 
        PriceAdult = 269, Type = "Train", InitialSeats = 50,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[142], Start = DateTime.UtcNow.AddDays(24).AddHours(17), 
        End = DateTime.UtcNow.AddDays(24).AddHours(20), 
        PriceAdult = 168, Type = "Plane", InitialSeats = 153,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[143], Start = DateTime.UtcNow.AddDays(17).AddHours(16), 
        End = DateTime.UtcNow.AddDays(17).AddHours(22), 
        PriceAdult = 175, Type = "Bus", InitialSeats = 200,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[144], Start = DateTime.UtcNow.AddDays(47).AddHours(0), 
        End = DateTime.UtcNow.AddDays(47).AddHours(5), 
        PriceAdult = 83, Type = "Train", InitialSeats = 153,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[145], Start = DateTime.UtcNow.AddDays(61).AddHours(17), 
        End = DateTime.UtcNow.AddDays(62).AddHours(5), 
        PriceAdult = 170, Type = "Plane", InitialSeats = 167,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[146], Start = DateTime.UtcNow.AddDays(16).AddHours(21), 
        End = DateTime.UtcNow.AddDays(16).AddHours(24), 
        PriceAdult = 104, Type = "Plane", InitialSeats = 170,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[147], Start = DateTime.UtcNow.AddDays(55).AddHours(12), 
        End = DateTime.UtcNow.AddDays(55).AddHours(14), 
        PriceAdult = 268, Type = "Plane", InitialSeats = 132,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[148], Start = DateTime.UtcNow.AddDays(22).AddHours(15), 
        End = DateTime.UtcNow.AddDays(23).AddHours(3), 
        PriceAdult = 110, Type = "Bus", InitialSeats = 165,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[149], Start = DateTime.UtcNow.AddDays(12).AddHours(11), 
        End = DateTime.UtcNow.AddDays(12).AddHours(14), 
        PriceAdult = 91, Type = "Bus", InitialSeats = 187,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[150], Start = DateTime.UtcNow.AddDays(54).AddHours(1), 
        End = DateTime.UtcNow.AddDays(54).AddHours(8), 
        PriceAdult = 89, Type = "Plane", InitialSeats = 162,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[151], Start = DateTime.UtcNow.AddDays(79).AddHours(23), 
        End = DateTime.UtcNow.AddDays(80).AddHours(11), 
        PriceAdult = 68, Type = "Plane", InitialSeats = 91,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[152], Start = DateTime.UtcNow.AddDays(1).AddHours(22), 
        End = DateTime.UtcNow.AddDays(2).AddHours(8), 
        PriceAdult = 78, Type = "Train", InitialSeats = 187,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[153], Start = DateTime.UtcNow.AddDays(20).AddHours(3), 
        End = DateTime.UtcNow.AddDays(20).AddHours(8), 
        PriceAdult = 131, Type = "Train", InitialSeats = 70,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[154], Start = DateTime.UtcNow.AddDays(32).AddHours(6), 
        End = DateTime.UtcNow.AddDays(32).AddHours(10), 
        PriceAdult = 272, Type = "Train", InitialSeats = 73,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[155], Start = DateTime.UtcNow.AddDays(40).AddHours(4), 
        End = DateTime.UtcNow.AddDays(40).AddHours(12), 
        PriceAdult = 126, Type = "Bus", InitialSeats = 184,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[156], Start = DateTime.UtcNow.AddDays(43).AddHours(6), 
        End = DateTime.UtcNow.AddDays(43).AddHours(11), 
        PriceAdult = 289, Type = "Train", InitialSeats = 131,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[157], Start = DateTime.UtcNow.AddDays(4).AddHours(20), 
        End = DateTime.UtcNow.AddDays(5).AddHours(3), 
        PriceAdult = 140, Type = "Train", InitialSeats = 57,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[158], Start = DateTime.UtcNow.AddDays(78).AddHours(16), 
        End = DateTime.UtcNow.AddDays(78).AddHours(19), 
        PriceAdult = 242, Type = "Bus", InitialSeats = 168,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[159], Start = DateTime.UtcNow.AddDays(29).AddHours(11), 
        End = DateTime.UtcNow.AddDays(29).AddHours(18), 
        PriceAdult = 247, Type = "Train", InitialSeats = 85,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[160], Start = DateTime.UtcNow.AddDays(49).AddHours(0), 
        End = DateTime.UtcNow.AddDays(49).AddHours(9), 
        PriceAdult = 197, Type = "Plane", InitialSeats = 112,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[161], Start = DateTime.UtcNow.AddDays(51).AddHours(2), 
        End = DateTime.UtcNow.AddDays(51).AddHours(8), 
        PriceAdult = 146, Type = "Bus", InitialSeats = 154,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[162], Start = DateTime.UtcNow.AddDays(30).AddHours(19), 
        End = DateTime.UtcNow.AddDays(31).AddHours(7), 
        PriceAdult = 179, Type = "Plane", InitialSeats = 171,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[163], Start = DateTime.UtcNow.AddDays(90).AddHours(15), 
        End = DateTime.UtcNow.AddDays(90).AddHours(21), 
        PriceAdult = 188, Type = "Plane", InitialSeats = 110,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[164], Start = DateTime.UtcNow.AddDays(63).AddHours(1), 
        End = DateTime.UtcNow.AddDays(63).AddHours(8), 
        PriceAdult = 212, Type = "Plane", InitialSeats = 181,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[165], Start = DateTime.UtcNow.AddDays(89).AddHours(7), 
        End = DateTime.UtcNow.AddDays(89).AddHours(9), 
        PriceAdult = 95, Type = "Train", InitialSeats = 165,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[166], Start = DateTime.UtcNow.AddDays(43).AddHours(0), 
        End = DateTime.UtcNow.AddDays(43).AddHours(10), 
        PriceAdult = 264, Type = "Plane", InitialSeats = 180,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[167], Start = DateTime.UtcNow.AddDays(32).AddHours(21), 
        End = DateTime.UtcNow.AddDays(32).AddHours(23), 
        PriceAdult = 191, Type = "Plane", InitialSeats = 137,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[168], Start = DateTime.UtcNow.AddDays(68).AddHours(15), 
        End = DateTime.UtcNow.AddDays(68).AddHours(19), 
        PriceAdult = 105, Type = "Plane", InitialSeats = 94,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[169], Start = DateTime.UtcNow.AddDays(23).AddHours(9), 
        End = DateTime.UtcNow.AddDays(23).AddHours(15), 
        PriceAdult = 101, Type = "Bus", InitialSeats = 74,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[170], Start = DateTime.UtcNow.AddDays(77).AddHours(17), 
        End = DateTime.UtcNow.AddDays(78).AddHours(3), 
        PriceAdult = 158, Type = "Bus", InitialSeats = 100,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[171], Start = DateTime.UtcNow.AddDays(84).AddHours(4), 
        End = DateTime.UtcNow.AddDays(84).AddHours(16), 
        PriceAdult = 128, Type = "Train", InitialSeats = 175,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[172], Start = DateTime.UtcNow.AddDays(34).AddHours(7), 
        End = DateTime.UtcNow.AddDays(34).AddHours(17), 
        PriceAdult = 181, Type = "Train", InitialSeats = 60,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[173], Start = DateTime.UtcNow.AddDays(89).AddHours(5), 
        End = DateTime.UtcNow.AddDays(89).AddHours(8), 
        PriceAdult = 109, Type = "Plane", InitialSeats = 107,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[174], Start = DateTime.UtcNow.AddDays(32).AddHours(3), 
        End = DateTime.UtcNow.AddDays(32).AddHours(9), 
        PriceAdult = 223, Type = "Train", InitialSeats = 173,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[175], Start = DateTime.UtcNow.AddDays(2).AddHours(11), 
        End = DateTime.UtcNow.AddDays(2).AddHours(17), 
        PriceAdult = 75, Type = "Bus", InitialSeats = 185,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[176], Start = DateTime.UtcNow.AddDays(34).AddHours(10), 
        End = DateTime.UtcNow.AddDays(34).AddHours(15), 
        PriceAdult = 191, Type = "Bus", InitialSeats = 183,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[177], Start = DateTime.UtcNow.AddDays(30).AddHours(0), 
        End = DateTime.UtcNow.AddDays(30).AddHours(12), 
        PriceAdult = 82, Type = "Bus", InitialSeats = 51,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[178], Start = DateTime.UtcNow.AddDays(86).AddHours(3), 
        End = DateTime.UtcNow.AddDays(86).AddHours(6), 
        PriceAdult = 293, Type = "Train", InitialSeats = 165,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[179], Start = DateTime.UtcNow.AddDays(51).AddHours(0), 
        End = DateTime.UtcNow.AddDays(51).AddHours(2), 
        PriceAdult = 199, Type = "Train", InitialSeats = 178,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[180], Start = DateTime.UtcNow.AddDays(42).AddHours(14), 
        End = DateTime.UtcNow.AddDays(42).AddHours(20), 
        PriceAdult = 64, Type = "Plane", InitialSeats = 154,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[181], Start = DateTime.UtcNow.AddDays(83).AddHours(22), 
        End = DateTime.UtcNow.AddDays(84).AddHours(8), 
        PriceAdult = 74, Type = "Train", InitialSeats = 93,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[182], Start = DateTime.UtcNow.AddDays(67).AddHours(3), 
        End = DateTime.UtcNow.AddDays(67).AddHours(6), 
        PriceAdult = 197, Type = "Train", InitialSeats = 74,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[183], Start = DateTime.UtcNow.AddDays(13).AddHours(7), 
        End = DateTime.UtcNow.AddDays(13).AddHours(15), 
        PriceAdult = 289, Type = "Bus", InitialSeats = 125,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[184], Start = DateTime.UtcNow.AddDays(4).AddHours(20), 
        End = DateTime.UtcNow.AddDays(5).AddHours(2), 
        PriceAdult = 61, Type = "Bus", InitialSeats = 183,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[185], Start = DateTime.UtcNow.AddDays(23).AddHours(11), 
        End = DateTime.UtcNow.AddDays(23).AddHours(15), 
        PriceAdult = 137, Type = "Plane", InitialSeats = 132,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[186], Start = DateTime.UtcNow.AddDays(78).AddHours(23), 
        End = DateTime.UtcNow.AddDays(79).AddHours(10), 
        PriceAdult = 234, Type = "Bus", InitialSeats = 86,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[187], Start = DateTime.UtcNow.AddDays(26).AddHours(9), 
        End = DateTime.UtcNow.AddDays(26).AddHours(14), 
        PriceAdult = 227, Type = "Plane", InitialSeats = 169,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[188], Start = DateTime.UtcNow.AddDays(88).AddHours(13), 
        End = DateTime.UtcNow.AddDays(88).AddHours(19), 
        PriceAdult = 123, Type = "Plane", InitialSeats = 143,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[189], Start = DateTime.UtcNow.AddDays(19).AddHours(15), 
        End = DateTime.UtcNow.AddDays(19).AddHours(20), 
        PriceAdult = 256, Type = "Train", InitialSeats = 56,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[190], Start = DateTime.UtcNow.AddDays(31).AddHours(9), 
        End = DateTime.UtcNow.AddDays(31).AddHours(20), 
        PriceAdult = 277, Type = "Train", InitialSeats = 158,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[191], Start = DateTime.UtcNow.AddDays(18).AddHours(6), 
        End = DateTime.UtcNow.AddDays(18).AddHours(14), 
        PriceAdult = 192, Type = "Plane", InitialSeats = 174,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[192], Start = DateTime.UtcNow.AddDays(29).AddHours(16), 
        End = DateTime.UtcNow.AddDays(29).AddHours(23), 
        PriceAdult = 278, Type = "Bus", InitialSeats = 54,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[193], Start = DateTime.UtcNow.AddDays(47).AddHours(20), 
        End = DateTime.UtcNow.AddDays(48).AddHours(5), 
        PriceAdult = 295, Type = "Bus", InitialSeats = 112,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[194], Start = DateTime.UtcNow.AddDays(7).AddHours(8), 
        End = DateTime.UtcNow.AddDays(7).AddHours(13), 
        PriceAdult = 194, Type = "Plane", InitialSeats = 52,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[195], Start = DateTime.UtcNow.AddDays(32).AddHours(1), 
        End = DateTime.UtcNow.AddDays(32).AddHours(10), 
        PriceAdult = 188, Type = "Bus", InitialSeats = 122,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[196], Start = DateTime.UtcNow.AddDays(17).AddHours(9), 
        End = DateTime.UtcNow.AddDays(17).AddHours(20), 
        PriceAdult = 211, Type = "Train", InitialSeats = 130,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[197], Start = DateTime.UtcNow.AddDays(20).AddHours(5), 
        End = DateTime.UtcNow.AddDays(20).AddHours(17), 
        PriceAdult = 130, Type = "Plane", InitialSeats = 55,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[198], Start = DateTime.UtcNow.AddDays(78).AddHours(6), 
        End = DateTime.UtcNow.AddDays(78).AddHours(14), 
        PriceAdult = 227, Type = "Bus", InitialSeats = 129,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[199], Start = DateTime.UtcNow.AddDays(6).AddHours(8), 
        End = DateTime.UtcNow.AddDays(6).AddHours(10), 
        PriceAdult = 239, Type = "Plane", InitialSeats = 127,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
                                };
                modelBuilder.Entity<CommandTransportOption>().HasData(transportOptions);
           
        var queryTransportOptions = new[]
                    {
            
    new QueryTransportOption
    {
        Id = TransportIds[0], Start = DateTime.UtcNow.AddDays(81).AddHours(10), 
        End = DateTime.UtcNow.AddDays(81).AddHours(18), 
        PriceAdult = 107, PriceUnder3 = 21, PriceUnder10 = 53, PriceUnder18 = 96,  Type = "Bus", Seats = 88,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[1], Start = DateTime.UtcNow.AddDays(51).AddHours(6), 
        End = DateTime.UtcNow.AddDays(51).AddHours(9), 
        PriceAdult = 271, PriceUnder3 = 54, PriceUnder10 = 135, PriceUnder18 = 243,  Type = "Plane", Seats = 111,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[2], Start = DateTime.UtcNow.AddDays(27).AddHours(22), 
        End = DateTime.UtcNow.AddDays(28).AddHours(1), 
        PriceAdult = 211, PriceUnder3 = 42, PriceUnder10 = 105, PriceUnder18 = 189,  Type = "Bus", Seats = 161,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[3], Start = DateTime.UtcNow.AddDays(1).AddHours(3), 
        End = DateTime.UtcNow.AddDays(1).AddHours(7), 
        PriceAdult = 52, PriceUnder3 = 10, PriceUnder10 = 26, PriceUnder18 = 46,  Type = "Train", Seats = 72,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[4], Start = DateTime.UtcNow.AddDays(71).AddHours(23), 
        End = DateTime.UtcNow.AddDays(72).AddHours(6), 
        PriceAdult = 186, PriceUnder3 = 37, PriceUnder10 = 93, PriceUnder18 = 167,  Type = "Bus", Seats = 172,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[5], Start = DateTime.UtcNow.AddDays(11).AddHours(22), 
        End = DateTime.UtcNow.AddDays(12).AddHours(1), 
        PriceAdult = 121, PriceUnder3 = 24, PriceUnder10 = 60, PriceUnder18 = 108,  Type = "Plane", Seats = 173,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[6], Start = DateTime.UtcNow.AddDays(64).AddHours(14), 
        End = DateTime.UtcNow.AddDays(64).AddHours(18), 
        PriceAdult = 296, PriceUnder3 = 59, PriceUnder10 = 148, PriceUnder18 = 266,  Type = "Train", Seats = 51,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[7], Start = DateTime.UtcNow.AddDays(13).AddHours(0), 
        End = DateTime.UtcNow.AddDays(13).AddHours(8), 
        PriceAdult = 295, PriceUnder3 = 59, PriceUnder10 = 147, PriceUnder18 = 265,  Type = "Plane", Seats = 166,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[8], Start = DateTime.UtcNow.AddDays(85).AddHours(9), 
        End = DateTime.UtcNow.AddDays(85).AddHours(13), 
        PriceAdult = 187, PriceUnder3 = 37, PriceUnder10 = 93, PriceUnder18 = 168,  Type = "Plane", Seats = 122,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[9], Start = DateTime.UtcNow.AddDays(88).AddHours(21), 
        End = DateTime.UtcNow.AddDays(89).AddHours(7), 
        PriceAdult = 240, PriceUnder3 = 48, PriceUnder10 = 120, PriceUnder18 = 216,  Type = "Bus", Seats = 116,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[10], Start = DateTime.UtcNow.AddDays(21).AddHours(5), 
        End = DateTime.UtcNow.AddDays(21).AddHours(13), 
        PriceAdult = 257, PriceUnder3 = 51, PriceUnder10 = 128, PriceUnder18 = 231,  Type = "Plane", Seats = 76,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[11], Start = DateTime.UtcNow.AddDays(89).AddHours(2), 
        End = DateTime.UtcNow.AddDays(89).AddHours(8), 
        PriceAdult = 192, PriceUnder3 = 38, PriceUnder10 = 96, PriceUnder18 = 172,  Type = "Bus", Seats = 65,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[12], Start = DateTime.UtcNow.AddDays(57).AddHours(10), 
        End = DateTime.UtcNow.AddDays(57).AddHours(12), 
        PriceAdult = 270, PriceUnder3 = 54, PriceUnder10 = 135, PriceUnder18 = 243,  Type = "Plane", Seats = 63,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[13], Start = DateTime.UtcNow.AddDays(5).AddHours(21), 
        End = DateTime.UtcNow.AddDays(5).AddHours(24), 
        PriceAdult = 200, PriceUnder3 = 40, PriceUnder10 = 100, PriceUnder18 = 180,  Type = "Bus", Seats = 65,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[14], Start = DateTime.UtcNow.AddDays(31).AddHours(16), 
        End = DateTime.UtcNow.AddDays(31).AddHours(24), 
        PriceAdult = 160, PriceUnder3 = 32, PriceUnder10 = 80, PriceUnder18 = 144,  Type = "Bus", Seats = 137,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[15], Start = DateTime.UtcNow.AddDays(45).AddHours(16), 
        End = DateTime.UtcNow.AddDays(46).AddHours(3), 
        PriceAdult = 195, PriceUnder3 = 39, PriceUnder10 = 97, PriceUnder18 = 175,  Type = "Train", Seats = 60,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[16], Start = DateTime.UtcNow.AddDays(80).AddHours(17), 
        End = DateTime.UtcNow.AddDays(81).AddHours(4), 
        PriceAdult = 128, PriceUnder3 = 25, PriceUnder10 = 64, PriceUnder18 = 115,  Type = "Train", Seats = 109,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[17], Start = DateTime.UtcNow.AddDays(41).AddHours(7), 
        End = DateTime.UtcNow.AddDays(41).AddHours(11), 
        PriceAdult = 79, PriceUnder3 = 15, PriceUnder10 = 39, PriceUnder18 = 71,  Type = "Plane", Seats = 176,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[18], Start = DateTime.UtcNow.AddDays(67).AddHours(4), 
        End = DateTime.UtcNow.AddDays(67).AddHours(10), 
        PriceAdult = 179, PriceUnder3 = 35, PriceUnder10 = 89, PriceUnder18 = 161,  Type = "Bus", Seats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[19], Start = DateTime.UtcNow.AddDays(79).AddHours(21), 
        End = DateTime.UtcNow.AddDays(79).AddHours(23), 
        PriceAdult = 71, PriceUnder3 = 14, PriceUnder10 = 35, PriceUnder18 = 63,  Type = "Plane", Seats = 177,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[20], Start = DateTime.UtcNow.AddDays(52).AddHours(10), 
        End = DateTime.UtcNow.AddDays(52).AddHours(20), 
        PriceAdult = 269, PriceUnder3 = 53, PriceUnder10 = 134, PriceUnder18 = 242,  Type = "Plane", Seats = 125,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[21], Start = DateTime.UtcNow.AddDays(81).AddHours(15), 
        End = DateTime.UtcNow.AddDays(81).AddHours(20), 
        PriceAdult = 190, PriceUnder3 = 38, PriceUnder10 = 95, PriceUnder18 = 171,  Type = "Train", Seats = 105,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[22], Start = DateTime.UtcNow.AddDays(14).AddHours(16), 
        End = DateTime.UtcNow.AddDays(14).AddHours(21), 
        PriceAdult = 67, PriceUnder3 = 13, PriceUnder10 = 33, PriceUnder18 = 60,  Type = "Train", Seats = 194,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[23], Start = DateTime.UtcNow.AddDays(86).AddHours(12), 
        End = DateTime.UtcNow.AddDays(86).AddHours(18), 
        PriceAdult = 299, PriceUnder3 = 59, PriceUnder10 = 149, PriceUnder18 = 269,  Type = "Bus", Seats = 64,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[24], Start = DateTime.UtcNow.AddDays(18).AddHours(6), 
        End = DateTime.UtcNow.AddDays(18).AddHours(16), 
        PriceAdult = 127, PriceUnder3 = 25, PriceUnder10 = 63, PriceUnder18 = 114,  Type = "Train", Seats = 154,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[25], Start = DateTime.UtcNow.AddDays(79).AddHours(23), 
        End = DateTime.UtcNow.AddDays(80).AddHours(5), 
        PriceAdult = 82, PriceUnder3 = 16, PriceUnder10 = 41, PriceUnder18 = 73,  Type = "Plane", Seats = 98,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[26], Start = DateTime.UtcNow.AddDays(8).AddHours(15), 
        End = DateTime.UtcNow.AddDays(8).AddHours(17), 
        PriceAdult = 266, PriceUnder3 = 53, PriceUnder10 = 133, PriceUnder18 = 239,  Type = "Train", Seats = 168,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[27], Start = DateTime.UtcNow.AddDays(68).AddHours(0), 
        End = DateTime.UtcNow.AddDays(68).AddHours(6), 
        PriceAdult = 94, PriceUnder3 = 18, PriceUnder10 = 47, PriceUnder18 = 84,  Type = "Bus", Seats = 74,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[28], Start = DateTime.UtcNow.AddDays(48).AddHours(19), 
        End = DateTime.UtcNow.AddDays(49).AddHours(2), 
        PriceAdult = 126, PriceUnder3 = 25, PriceUnder10 = 63, PriceUnder18 = 113,  Type = "Train", Seats = 131,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[29], Start = DateTime.UtcNow.AddDays(20).AddHours(17), 
        End = DateTime.UtcNow.AddDays(20).AddHours(24), 
        PriceAdult = 242, PriceUnder3 = 48, PriceUnder10 = 121, PriceUnder18 = 217,  Type = "Train", Seats = 191,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[30], Start = DateTime.UtcNow.AddDays(65).AddHours(3), 
        End = DateTime.UtcNow.AddDays(65).AddHours(7), 
        PriceAdult = 182, PriceUnder3 = 36, PriceUnder10 = 91, PriceUnder18 = 163,  Type = "Train", Seats = 142,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[31], Start = DateTime.UtcNow.AddDays(52).AddHours(18), 
        End = DateTime.UtcNow.AddDays(53).AddHours(1), 
        PriceAdult = 108, PriceUnder3 = 21, PriceUnder10 = 54, PriceUnder18 = 97,  Type = "Train", Seats = 112,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[32], Start = DateTime.UtcNow.AddDays(62).AddHours(13), 
        End = DateTime.UtcNow.AddDays(62).AddHours(22), 
        PriceAdult = 106, PriceUnder3 = 21, PriceUnder10 = 53, PriceUnder18 = 95,  Type = "Train", Seats = 163,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[33], Start = DateTime.UtcNow.AddDays(6).AddHours(8), 
        End = DateTime.UtcNow.AddDays(6).AddHours(10), 
        PriceAdult = 66, PriceUnder3 = 13, PriceUnder10 = 33, PriceUnder18 = 59,  Type = "Bus", Seats = 180,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[34], Start = DateTime.UtcNow.AddDays(26).AddHours(15), 
        End = DateTime.UtcNow.AddDays(26).AddHours(21), 
        PriceAdult = 185, PriceUnder3 = 37, PriceUnder10 = 92, PriceUnder18 = 166,  Type = "Train", Seats = 184,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[35], Start = DateTime.UtcNow.AddDays(62).AddHours(1), 
        End = DateTime.UtcNow.AddDays(62).AddHours(11), 
        PriceAdult = 63, PriceUnder3 = 12, PriceUnder10 = 31, PriceUnder18 = 56,  Type = "Train", Seats = 97,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[36], Start = DateTime.UtcNow.AddDays(12).AddHours(17), 
        End = DateTime.UtcNow.AddDays(13).AddHours(5), 
        PriceAdult = 278, PriceUnder3 = 55, PriceUnder10 = 139, PriceUnder18 = 250,  Type = "Bus", Seats = 60,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[37], Start = DateTime.UtcNow.AddDays(5).AddHours(17), 
        End = DateTime.UtcNow.AddDays(6).AddHours(5), 
        PriceAdult = 170, PriceUnder3 = 34, PriceUnder10 = 85, PriceUnder18 = 153,  Type = "Plane", Seats = 57,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[38], Start = DateTime.UtcNow.AddDays(88).AddHours(6), 
        End = DateTime.UtcNow.AddDays(88).AddHours(10), 
        PriceAdult = 109, PriceUnder3 = 21, PriceUnder10 = 54, PriceUnder18 = 98,  Type = "Bus", Seats = 166,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[39], Start = DateTime.UtcNow.AddDays(31).AddHours(6), 
        End = DateTime.UtcNow.AddDays(31).AddHours(15), 
        PriceAdult = 78, PriceUnder3 = 15, PriceUnder10 = 39, PriceUnder18 = 70,  Type = "Bus", Seats = 92,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[40], Start = DateTime.UtcNow.AddDays(25).AddHours(4), 
        End = DateTime.UtcNow.AddDays(25).AddHours(9), 
        PriceAdult = 206, PriceUnder3 = 41, PriceUnder10 = 103, PriceUnder18 = 185,  Type = "Bus", Seats = 137,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[41], Start = DateTime.UtcNow.AddDays(61).AddHours(18), 
        End = DateTime.UtcNow.AddDays(61).AddHours(22), 
        PriceAdult = 151, PriceUnder3 = 30, PriceUnder10 = 75, PriceUnder18 = 135,  Type = "Bus", Seats = 190,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[42], Start = DateTime.UtcNow.AddDays(46).AddHours(7), 
        End = DateTime.UtcNow.AddDays(46).AddHours(10), 
        PriceAdult = 208, PriceUnder3 = 41, PriceUnder10 = 104, PriceUnder18 = 187,  Type = "Train", Seats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[43], Start = DateTime.UtcNow.AddDays(31).AddHours(21), 
        End = DateTime.UtcNow.AddDays(32).AddHours(4), 
        PriceAdult = 67, PriceUnder3 = 13, PriceUnder10 = 33, PriceUnder18 = 60,  Type = "Train", Seats = 195,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[44], Start = DateTime.UtcNow.AddDays(11).AddHours(14), 
        End = DateTime.UtcNow.AddDays(12).AddHours(1), 
        PriceAdult = 54, PriceUnder3 = 10, PriceUnder10 = 27, PriceUnder18 = 48,  Type = "Plane", Seats = 197,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[45], Start = DateTime.UtcNow.AddDays(78).AddHours(7), 
        End = DateTime.UtcNow.AddDays(78).AddHours(13), 
        PriceAdult = 110, PriceUnder3 = 22, PriceUnder10 = 55, PriceUnder18 = 99,  Type = "Bus", Seats = 120,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[46], Start = DateTime.UtcNow.AddDays(28).AddHours(22), 
        End = DateTime.UtcNow.AddDays(29).AddHours(2), 
        PriceAdult = 194, PriceUnder3 = 38, PriceUnder10 = 97, PriceUnder18 = 174,  Type = "Train", Seats = 79,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[47], Start = DateTime.UtcNow.AddDays(7).AddHours(15), 
        End = DateTime.UtcNow.AddDays(7).AddHours(19), 
        PriceAdult = 169, PriceUnder3 = 33, PriceUnder10 = 84, PriceUnder18 = 152,  Type = "Bus", Seats = 136,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[48], Start = DateTime.UtcNow.AddDays(34).AddHours(7), 
        End = DateTime.UtcNow.AddDays(34).AddHours(9), 
        PriceAdult = 187, PriceUnder3 = 37, PriceUnder10 = 93, PriceUnder18 = 168,  Type = "Train", Seats = 143,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[49], Start = DateTime.UtcNow.AddDays(10).AddHours(9), 
        End = DateTime.UtcNow.AddDays(10).AddHours(15), 
        PriceAdult = 295, PriceUnder3 = 59, PriceUnder10 = 147, PriceUnder18 = 265,  Type = "Train", Seats = 142,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[50], Start = DateTime.UtcNow.AddDays(78).AddHours(23), 
        End = DateTime.UtcNow.AddDays(79).AddHours(11), 
        PriceAdult = 231, PriceUnder3 = 46, PriceUnder10 = 115, PriceUnder18 = 207,  Type = "Plane", Seats = 79,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[51], Start = DateTime.UtcNow.AddDays(48).AddHours(11), 
        End = DateTime.UtcNow.AddDays(48).AddHours(21), 
        PriceAdult = 81, PriceUnder3 = 16, PriceUnder10 = 40, PriceUnder18 = 72,  Type = "Bus", Seats = 162,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[52], Start = DateTime.UtcNow.AddDays(87).AddHours(21), 
        End = DateTime.UtcNow.AddDays(88).AddHours(4), 
        PriceAdult = 143, PriceUnder3 = 28, PriceUnder10 = 71, PriceUnder18 = 128,  Type = "Train", Seats = 79,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[53], Start = DateTime.UtcNow.AddDays(63).AddHours(6), 
        End = DateTime.UtcNow.AddDays(63).AddHours(17), 
        PriceAdult = 195, PriceUnder3 = 39, PriceUnder10 = 97, PriceUnder18 = 175,  Type = "Train", Seats = 62,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[54], Start = DateTime.UtcNow.AddDays(85).AddHours(8), 
        End = DateTime.UtcNow.AddDays(85).AddHours(10), 
        PriceAdult = 226, PriceUnder3 = 45, PriceUnder10 = 113, PriceUnder18 = 203,  Type = "Plane", Seats = 97,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[55], Start = DateTime.UtcNow.AddDays(28).AddHours(16), 
        End = DateTime.UtcNow.AddDays(28).AddHours(19), 
        PriceAdult = 124, PriceUnder3 = 24, PriceUnder10 = 62, PriceUnder18 = 111,  Type = "Bus", Seats = 115,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[56], Start = DateTime.UtcNow.AddDays(55).AddHours(23), 
        End = DateTime.UtcNow.AddDays(56).AddHours(7), 
        PriceAdult = 183, PriceUnder3 = 36, PriceUnder10 = 91, PriceUnder18 = 164,  Type = "Bus", Seats = 187,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[57], Start = DateTime.UtcNow.AddDays(22).AddHours(16), 
        End = DateTime.UtcNow.AddDays(22).AddHours(19), 
        PriceAdult = 123, PriceUnder3 = 24, PriceUnder10 = 61, PriceUnder18 = 110,  Type = "Plane", Seats = 175,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[58], Start = DateTime.UtcNow.AddDays(5).AddHours(8), 
        End = DateTime.UtcNow.AddDays(5).AddHours(18), 
        PriceAdult = 238, PriceUnder3 = 47, PriceUnder10 = 119, PriceUnder18 = 214,  Type = "Plane", Seats = 151,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[59], Start = DateTime.UtcNow.AddDays(53).AddHours(21), 
        End = DateTime.UtcNow.AddDays(53).AddHours(23), 
        PriceAdult = 226, PriceUnder3 = 45, PriceUnder10 = 113, PriceUnder18 = 203,  Type = "Plane", Seats = 160,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[60], Start = DateTime.UtcNow.AddDays(17).AddHours(10), 
        End = DateTime.UtcNow.AddDays(17).AddHours(15), 
        PriceAdult = 139, PriceUnder3 = 27, PriceUnder10 = 69, PriceUnder18 = 125,  Type = "Train", Seats = 116,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[61], Start = DateTime.UtcNow.AddDays(72).AddHours(7), 
        End = DateTime.UtcNow.AddDays(72).AddHours(13), 
        PriceAdult = 269, PriceUnder3 = 53, PriceUnder10 = 134, PriceUnder18 = 242,  Type = "Bus", Seats = 92,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[62], Start = DateTime.UtcNow.AddDays(25).AddHours(7), 
        End = DateTime.UtcNow.AddDays(25).AddHours(15), 
        PriceAdult = 81, PriceUnder3 = 16, PriceUnder10 = 40, PriceUnder18 = 72,  Type = "Bus", Seats = 194,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[63], Start = DateTime.UtcNow.AddDays(24).AddHours(17), 
        End = DateTime.UtcNow.AddDays(24).AddHours(22), 
        PriceAdult = 241, PriceUnder3 = 48, PriceUnder10 = 120, PriceUnder18 = 216,  Type = "Bus", Seats = 88,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[64], Start = DateTime.UtcNow.AddDays(25).AddHours(9), 
        End = DateTime.UtcNow.AddDays(25).AddHours(15), 
        PriceAdult = 122, PriceUnder3 = 24, PriceUnder10 = 61, PriceUnder18 = 109,  Type = "Bus", Seats = 175,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[65], Start = DateTime.UtcNow.AddDays(86).AddHours(5), 
        End = DateTime.UtcNow.AddDays(86).AddHours(14), 
        PriceAdult = 256, PriceUnder3 = 51, PriceUnder10 = 128, PriceUnder18 = 230,  Type = "Plane", Seats = 132,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[66], Start = DateTime.UtcNow.AddDays(12).AddHours(9), 
        End = DateTime.UtcNow.AddDays(12).AddHours(19), 
        PriceAdult = 131, PriceUnder3 = 26, PriceUnder10 = 65, PriceUnder18 = 117,  Type = "Bus", Seats = 121,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[67], Start = DateTime.UtcNow.AddDays(51).AddHours(19), 
        End = DateTime.UtcNow.AddDays(51).AddHours(23), 
        PriceAdult = 238, PriceUnder3 = 47, PriceUnder10 = 119, PriceUnder18 = 214,  Type = "Bus", Seats = 103,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[68], Start = DateTime.UtcNow.AddDays(14).AddHours(17), 
        End = DateTime.UtcNow.AddDays(15).AddHours(1), 
        PriceAdult = 112, PriceUnder3 = 22, PriceUnder10 = 56, PriceUnder18 = 100,  Type = "Plane", Seats = 83,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[69], Start = DateTime.UtcNow.AddDays(77).AddHours(23), 
        End = DateTime.UtcNow.AddDays(78).AddHours(7), 
        PriceAdult = 265, PriceUnder3 = 53, PriceUnder10 = 132, PriceUnder18 = 238,  Type = "Train", Seats = 105,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[70], Start = DateTime.UtcNow.AddDays(37).AddHours(23), 
        End = DateTime.UtcNow.AddDays(38).AddHours(5), 
        PriceAdult = 161, PriceUnder3 = 32, PriceUnder10 = 80, PriceUnder18 = 144,  Type = "Train", Seats = 53,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[71], Start = DateTime.UtcNow.AddDays(66).AddHours(4), 
        End = DateTime.UtcNow.AddDays(66).AddHours(11), 
        PriceAdult = 286, PriceUnder3 = 57, PriceUnder10 = 143, PriceUnder18 = 257,  Type = "Plane", Seats = 136,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[72], Start = DateTime.UtcNow.AddDays(11).AddHours(11), 
        End = DateTime.UtcNow.AddDays(11).AddHours(13), 
        PriceAdult = 97, PriceUnder3 = 19, PriceUnder10 = 48, PriceUnder18 = 87,  Type = "Plane", Seats = 200,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[73], Start = DateTime.UtcNow.AddDays(34).AddHours(21), 
        End = DateTime.UtcNow.AddDays(35).AddHours(7), 
        PriceAdult = 269, PriceUnder3 = 53, PriceUnder10 = 134, PriceUnder18 = 242,  Type = "Bus", Seats = 79,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[74], Start = DateTime.UtcNow.AddDays(67).AddHours(11), 
        End = DateTime.UtcNow.AddDays(67).AddHours(16), 
        PriceAdult = 162, PriceUnder3 = 32, PriceUnder10 = 81, PriceUnder18 = 145,  Type = "Train", Seats = 101,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[75], Start = DateTime.UtcNow.AddDays(29).AddHours(6), 
        End = DateTime.UtcNow.AddDays(29).AddHours(17), 
        PriceAdult = 113, PriceUnder3 = 22, PriceUnder10 = 56, PriceUnder18 = 101,  Type = "Train", Seats = 65,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[76], Start = DateTime.UtcNow.AddDays(11).AddHours(6), 
        End = DateTime.UtcNow.AddDays(11).AddHours(18), 
        PriceAdult = 99, PriceUnder3 = 19, PriceUnder10 = 49, PriceUnder18 = 89,  Type = "Plane", Seats = 154,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[77], Start = DateTime.UtcNow.AddDays(51).AddHours(12), 
        End = DateTime.UtcNow.AddDays(51).AddHours(17), 
        PriceAdult = 265, PriceUnder3 = 53, PriceUnder10 = 132, PriceUnder18 = 238,  Type = "Bus", Seats = 105,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[78], Start = DateTime.UtcNow.AddDays(19).AddHours(17), 
        End = DateTime.UtcNow.AddDays(19).AddHours(20), 
        PriceAdult = 91, PriceUnder3 = 18, PriceUnder10 = 45, PriceUnder18 = 81,  Type = "Train", Seats = 82,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[79], Start = DateTime.UtcNow.AddDays(56).AddHours(15), 
        End = DateTime.UtcNow.AddDays(57).AddHours(2), 
        PriceAdult = 62, PriceUnder3 = 12, PriceUnder10 = 31, PriceUnder18 = 55,  Type = "Train", Seats = 175,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[80], Start = DateTime.UtcNow.AddDays(35).AddHours(4), 
        End = DateTime.UtcNow.AddDays(35).AddHours(10), 
        PriceAdult = 225, PriceUnder3 = 45, PriceUnder10 = 112, PriceUnder18 = 202,  Type = "Plane", Seats = 174,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[81], Start = DateTime.UtcNow.AddDays(53).AddHours(11), 
        End = DateTime.UtcNow.AddDays(53).AddHours(19), 
        PriceAdult = 201, PriceUnder3 = 40, PriceUnder10 = 100, PriceUnder18 = 180,  Type = "Bus", Seats = 72,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[82], Start = DateTime.UtcNow.AddDays(90).AddHours(16), 
        End = DateTime.UtcNow.AddDays(91).AddHours(4), 
        PriceAdult = 142, PriceUnder3 = 28, PriceUnder10 = 71, PriceUnder18 = 127,  Type = "Train", Seats = 63,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[83], Start = DateTime.UtcNow.AddDays(85).AddHours(0), 
        End = DateTime.UtcNow.AddDays(85).AddHours(5), 
        PriceAdult = 234, PriceUnder3 = 46, PriceUnder10 = 117, PriceUnder18 = 210,  Type = "Train", Seats = 198,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[84], Start = DateTime.UtcNow.AddDays(57).AddHours(14), 
        End = DateTime.UtcNow.AddDays(57).AddHours(19), 
        PriceAdult = 221, PriceUnder3 = 44, PriceUnder10 = 110, PriceUnder18 = 198,  Type = "Plane", Seats = 185,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[85], Start = DateTime.UtcNow.AddDays(14).AddHours(23), 
        End = DateTime.UtcNow.AddDays(15).AddHours(5), 
        PriceAdult = 122, PriceUnder3 = 24, PriceUnder10 = 61, PriceUnder18 = 109,  Type = "Plane", Seats = 67,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[86], Start = DateTime.UtcNow.AddDays(34).AddHours(3), 
        End = DateTime.UtcNow.AddDays(34).AddHours(5), 
        PriceAdult = 207, PriceUnder3 = 41, PriceUnder10 = 103, PriceUnder18 = 186,  Type = "Train", Seats = 89,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[87], Start = DateTime.UtcNow.AddDays(17).AddHours(16), 
        End = DateTime.UtcNow.AddDays(17).AddHours(24), 
        PriceAdult = 210, PriceUnder3 = 42, PriceUnder10 = 105, PriceUnder18 = 189,  Type = "Train", Seats = 79,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[88], Start = DateTime.UtcNow.AddDays(82).AddHours(15), 
        End = DateTime.UtcNow.AddDays(82).AddHours(24), 
        PriceAdult = 170, PriceUnder3 = 34, PriceUnder10 = 85, PriceUnder18 = 153,  Type = "Plane", Seats = 68,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[89], Start = DateTime.UtcNow.AddDays(32).AddHours(12), 
        End = DateTime.UtcNow.AddDays(32).AddHours(14), 
        PriceAdult = 292, PriceUnder3 = 58, PriceUnder10 = 146, PriceUnder18 = 262,  Type = "Plane", Seats = 85,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[90], Start = DateTime.UtcNow.AddDays(66).AddHours(11), 
        End = DateTime.UtcNow.AddDays(66).AddHours(20), 
        PriceAdult = 230, PriceUnder3 = 46, PriceUnder10 = 115, PriceUnder18 = 207,  Type = "Plane", Seats = 157,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[91], Start = DateTime.UtcNow.AddDays(90).AddHours(4), 
        End = DateTime.UtcNow.AddDays(90).AddHours(6), 
        PriceAdult = 189, PriceUnder3 = 37, PriceUnder10 = 94, PriceUnder18 = 170,  Type = "Plane", Seats = 93,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[92], Start = DateTime.UtcNow.AddDays(11).AddHours(0), 
        End = DateTime.UtcNow.AddDays(11).AddHours(10), 
        PriceAdult = 214, PriceUnder3 = 42, PriceUnder10 = 107, PriceUnder18 = 192,  Type = "Train", Seats = 116,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[93], Start = DateTime.UtcNow.AddDays(51).AddHours(8), 
        End = DateTime.UtcNow.AddDays(51).AddHours(17), 
        PriceAdult = 104, PriceUnder3 = 20, PriceUnder10 = 52, PriceUnder18 = 93,  Type = "Train", Seats = 184,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[94], Start = DateTime.UtcNow.AddDays(14).AddHours(1), 
        End = DateTime.UtcNow.AddDays(14).AddHours(9), 
        PriceAdult = 186, PriceUnder3 = 37, PriceUnder10 = 93, PriceUnder18 = 167,  Type = "Bus", Seats = 100,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[95], Start = DateTime.UtcNow.AddDays(45).AddHours(23), 
        End = DateTime.UtcNow.AddDays(46).AddHours(1), 
        PriceAdult = 244, PriceUnder3 = 48, PriceUnder10 = 122, PriceUnder18 = 219,  Type = "Bus", Seats = 71,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[96], Start = DateTime.UtcNow.AddDays(88).AddHours(10), 
        End = DateTime.UtcNow.AddDays(88).AddHours(15), 
        PriceAdult = 78, PriceUnder3 = 15, PriceUnder10 = 39, PriceUnder18 = 70,  Type = "Train", Seats = 52,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[97], Start = DateTime.UtcNow.AddDays(59).AddHours(20), 
        End = DateTime.UtcNow.AddDays(60).AddHours(6), 
        PriceAdult = 134, PriceUnder3 = 26, PriceUnder10 = 67, PriceUnder18 = 120,  Type = "Train", Seats = 171,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[98], Start = DateTime.UtcNow.AddDays(14).AddHours(17), 
        End = DateTime.UtcNow.AddDays(14).AddHours(21), 
        PriceAdult = 220, PriceUnder3 = 44, PriceUnder10 = 110, PriceUnder18 = 198,  Type = "Plane", Seats = 70,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[99], Start = DateTime.UtcNow.AddDays(63).AddHours(5), 
        End = DateTime.UtcNow.AddDays(63).AddHours(17), 
        PriceAdult = 144, PriceUnder3 = 28, PriceUnder10 = 72, PriceUnder18 = 129,  Type = "Bus", Seats = 134,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[100], Start = DateTime.UtcNow.AddDays(74).AddHours(18), 
        End = DateTime.UtcNow.AddDays(75).AddHours(4), 
        PriceAdult = 217, PriceUnder3 = 43, PriceUnder10 = 108, PriceUnder18 = 195,  Type = "Bus", Seats = 54,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[101], Start = DateTime.UtcNow.AddDays(42).AddHours(16), 
        End = DateTime.UtcNow.AddDays(43).AddHours(1), 
        PriceAdult = 155, PriceUnder3 = 31, PriceUnder10 = 77, PriceUnder18 = 139,  Type = "Train", Seats = 73,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[102], Start = DateTime.UtcNow.AddDays(45).AddHours(1), 
        End = DateTime.UtcNow.AddDays(45).AddHours(3), 
        PriceAdult = 54, PriceUnder3 = 10, PriceUnder10 = 27, PriceUnder18 = 48,  Type = "Plane", Seats = 194,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[103], Start = DateTime.UtcNow.AddDays(16).AddHours(15), 
        End = DateTime.UtcNow.AddDays(16).AddHours(19), 
        PriceAdult = 299, PriceUnder3 = 59, PriceUnder10 = 149, PriceUnder18 = 269,  Type = "Plane", Seats = 197,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[104], Start = DateTime.UtcNow.AddDays(45).AddHours(12), 
        End = DateTime.UtcNow.AddDays(45).AddHours(18), 
        PriceAdult = 125, PriceUnder3 = 25, PriceUnder10 = 62, PriceUnder18 = 112,  Type = "Plane", Seats = 167,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[105], Start = DateTime.UtcNow.AddDays(66).AddHours(3), 
        End = DateTime.UtcNow.AddDays(66).AddHours(11), 
        PriceAdult = 169, PriceUnder3 = 33, PriceUnder10 = 84, PriceUnder18 = 152,  Type = "Bus", Seats = 51,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[106], Start = DateTime.UtcNow.AddDays(67).AddHours(1), 
        End = DateTime.UtcNow.AddDays(67).AddHours(10), 
        PriceAdult = 135, PriceUnder3 = 27, PriceUnder10 = 67, PriceUnder18 = 121,  Type = "Bus", Seats = 161,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[107], Start = DateTime.UtcNow.AddDays(59).AddHours(22), 
        End = DateTime.UtcNow.AddDays(60).AddHours(1), 
        PriceAdult = 109, PriceUnder3 = 21, PriceUnder10 = 54, PriceUnder18 = 98,  Type = "Bus", Seats = 200,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[108], Start = DateTime.UtcNow.AddDays(35).AddHours(1), 
        End = DateTime.UtcNow.AddDays(35).AddHours(7), 
        PriceAdult = 138, PriceUnder3 = 27, PriceUnder10 = 69, PriceUnder18 = 124,  Type = "Plane", Seats = 99,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[109], Start = DateTime.UtcNow.AddDays(48).AddHours(21), 
        End = DateTime.UtcNow.AddDays(49).AddHours(6), 
        PriceAdult = 182, PriceUnder3 = 36, PriceUnder10 = 91, PriceUnder18 = 163,  Type = "Plane", Seats = 164,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[110], Start = DateTime.UtcNow.AddDays(29).AddHours(8), 
        End = DateTime.UtcNow.AddDays(29).AddHours(17), 
        PriceAdult = 161, PriceUnder3 = 32, PriceUnder10 = 80, PriceUnder18 = 144,  Type = "Bus", Seats = 123,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[111], Start = DateTime.UtcNow.AddDays(37).AddHours(23), 
        End = DateTime.UtcNow.AddDays(38).AddHours(6), 
        PriceAdult = 54, PriceUnder3 = 10, PriceUnder10 = 27, PriceUnder18 = 48,  Type = "Bus", Seats = 184,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[112], Start = DateTime.UtcNow.AddDays(82).AddHours(0), 
        End = DateTime.UtcNow.AddDays(82).AddHours(10), 
        PriceAdult = 259, PriceUnder3 = 51, PriceUnder10 = 129, PriceUnder18 = 233,  Type = "Plane", Seats = 191,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[113], Start = DateTime.UtcNow.AddDays(26).AddHours(22), 
        End = DateTime.UtcNow.AddDays(27).AddHours(8), 
        PriceAdult = 156, PriceUnder3 = 31, PriceUnder10 = 78, PriceUnder18 = 140,  Type = "Train", Seats = 66,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[114], Start = DateTime.UtcNow.AddDays(25).AddHours(22), 
        End = DateTime.UtcNow.AddDays(25).AddHours(24), 
        PriceAdult = 175, PriceUnder3 = 35, PriceUnder10 = 87, PriceUnder18 = 157,  Type = "Train", Seats = 194,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[115], Start = DateTime.UtcNow.AddDays(64).AddHours(23), 
        End = DateTime.UtcNow.AddDays(65).AddHours(11), 
        PriceAdult = 215, PriceUnder3 = 43, PriceUnder10 = 107, PriceUnder18 = 193,  Type = "Plane", Seats = 107,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[116], Start = DateTime.UtcNow.AddDays(64).AddHours(22), 
        End = DateTime.UtcNow.AddDays(65).AddHours(4), 
        PriceAdult = 239, PriceUnder3 = 47, PriceUnder10 = 119, PriceUnder18 = 215,  Type = "Plane", Seats = 182,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[117], Start = DateTime.UtcNow.AddDays(36).AddHours(12), 
        End = DateTime.UtcNow.AddDays(36).AddHours(14), 
        PriceAdult = 283, PriceUnder3 = 56, PriceUnder10 = 141, PriceUnder18 = 254,  Type = "Plane", Seats = 164,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[118], Start = DateTime.UtcNow.AddDays(28).AddHours(9), 
        End = DateTime.UtcNow.AddDays(28).AddHours(13), 
        PriceAdult = 189, PriceUnder3 = 37, PriceUnder10 = 94, PriceUnder18 = 170,  Type = "Train", Seats = 165,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[119], Start = DateTime.UtcNow.AddDays(40).AddHours(4), 
        End = DateTime.UtcNow.AddDays(40).AddHours(16), 
        PriceAdult = 107, PriceUnder3 = 21, PriceUnder10 = 53, PriceUnder18 = 96,  Type = "Train", Seats = 90,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[120], Start = DateTime.UtcNow.AddDays(2).AddHours(3), 
        End = DateTime.UtcNow.AddDays(2).AddHours(9), 
        PriceAdult = 134, PriceUnder3 = 26, PriceUnder10 = 67, PriceUnder18 = 120,  Type = "Train", Seats = 84,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[121], Start = DateTime.UtcNow.AddDays(35).AddHours(12), 
        End = DateTime.UtcNow.AddDays(35).AddHours(23), 
        PriceAdult = 248, PriceUnder3 = 49, PriceUnder10 = 124, PriceUnder18 = 223,  Type = "Plane", Seats = 93,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[122], Start = DateTime.UtcNow.AddDays(52).AddHours(9), 
        End = DateTime.UtcNow.AddDays(52).AddHours(14), 
        PriceAdult = 171, PriceUnder3 = 34, PriceUnder10 = 85, PriceUnder18 = 153,  Type = "Train", Seats = 112,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[123], Start = DateTime.UtcNow.AddDays(37).AddHours(16), 
        End = DateTime.UtcNow.AddDays(38).AddHours(3), 
        PriceAdult = 248, PriceUnder3 = 49, PriceUnder10 = 124, PriceUnder18 = 223,  Type = "Plane", Seats = 126,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[124], Start = DateTime.UtcNow.AddDays(31).AddHours(19), 
        End = DateTime.UtcNow.AddDays(32).AddHours(2), 
        PriceAdult = 231, PriceUnder3 = 46, PriceUnder10 = 115, PriceUnder18 = 207,  Type = "Train", Seats = 115,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[125], Start = DateTime.UtcNow.AddDays(35).AddHours(1), 
        End = DateTime.UtcNow.AddDays(35).AddHours(4), 
        PriceAdult = 115, PriceUnder3 = 23, PriceUnder10 = 57, PriceUnder18 = 103,  Type = "Plane", Seats = 162,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[126], Start = DateTime.UtcNow.AddDays(32).AddHours(5), 
        End = DateTime.UtcNow.AddDays(32).AddHours(13), 
        PriceAdult = 140, PriceUnder3 = 28, PriceUnder10 = 70, PriceUnder18 = 126,  Type = "Train", Seats = 123,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[127], Start = DateTime.UtcNow.AddDays(45).AddHours(4), 
        End = DateTime.UtcNow.AddDays(45).AddHours(16), 
        PriceAdult = 180, PriceUnder3 = 36, PriceUnder10 = 90, PriceUnder18 = 162,  Type = "Train", Seats = 138,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[128], Start = DateTime.UtcNow.AddDays(40).AddHours(2), 
        End = DateTime.UtcNow.AddDays(40).AddHours(7), 
        PriceAdult = 293, PriceUnder3 = 58, PriceUnder10 = 146, PriceUnder18 = 263,  Type = "Train", Seats = 147,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[129], Start = DateTime.UtcNow.AddDays(12).AddHours(3), 
        End = DateTime.UtcNow.AddDays(12).AddHours(15), 
        PriceAdult = 174, PriceUnder3 = 34, PriceUnder10 = 87, PriceUnder18 = 156,  Type = "Plane", Seats = 173,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[130], Start = DateTime.UtcNow.AddDays(84).AddHours(3), 
        End = DateTime.UtcNow.AddDays(84).AddHours(15), 
        PriceAdult = 108, PriceUnder3 = 21, PriceUnder10 = 54, PriceUnder18 = 97,  Type = "Bus", Seats = 84,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[131], Start = DateTime.UtcNow.AddDays(64).AddHours(20), 
        End = DateTime.UtcNow.AddDays(65).AddHours(6), 
        PriceAdult = 145, PriceUnder3 = 29, PriceUnder10 = 72, PriceUnder18 = 130,  Type = "Plane", Seats = 109,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[132], Start = DateTime.UtcNow.AddDays(76).AddHours(4), 
        End = DateTime.UtcNow.AddDays(76).AddHours(14), 
        PriceAdult = 212, PriceUnder3 = 42, PriceUnder10 = 106, PriceUnder18 = 190,  Type = "Plane", Seats = 192,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[133], Start = DateTime.UtcNow.AddDays(44).AddHours(6), 
        End = DateTime.UtcNow.AddDays(44).AddHours(16), 
        PriceAdult = 159, PriceUnder3 = 31, PriceUnder10 = 79, PriceUnder18 = 143,  Type = "Train", Seats = 65,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[134], Start = DateTime.UtcNow.AddDays(15).AddHours(20), 
        End = DateTime.UtcNow.AddDays(15).AddHours(24), 
        PriceAdult = 288, PriceUnder3 = 57, PriceUnder10 = 144, PriceUnder18 = 259,  Type = "Bus", Seats = 195,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[135], Start = DateTime.UtcNow.AddDays(65).AddHours(6), 
        End = DateTime.UtcNow.AddDays(65).AddHours(13), 
        PriceAdult = 82, PriceUnder3 = 16, PriceUnder10 = 41, PriceUnder18 = 73,  Type = "Train", Seats = 136,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[136], Start = DateTime.UtcNow.AddDays(82).AddHours(1), 
        End = DateTime.UtcNow.AddDays(82).AddHours(12), 
        PriceAdult = 217, PriceUnder3 = 43, PriceUnder10 = 108, PriceUnder18 = 195,  Type = "Train", Seats = 160,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[137], Start = DateTime.UtcNow.AddDays(48).AddHours(7), 
        End = DateTime.UtcNow.AddDays(48).AddHours(14), 
        PriceAdult = 70, PriceUnder3 = 14, PriceUnder10 = 35, PriceUnder18 = 63,  Type = "Plane", Seats = 149,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[138], Start = DateTime.UtcNow.AddDays(75).AddHours(23), 
        End = DateTime.UtcNow.AddDays(76).AddHours(1), 
        PriceAdult = 265, PriceUnder3 = 53, PriceUnder10 = 132, PriceUnder18 = 238,  Type = "Train", Seats = 126,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[139], Start = DateTime.UtcNow.AddDays(78).AddHours(10), 
        End = DateTime.UtcNow.AddDays(78).AddHours(18), 
        PriceAdult = 256, PriceUnder3 = 51, PriceUnder10 = 128, PriceUnder18 = 230,  Type = "Train", Seats = 103,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[140], Start = DateTime.UtcNow.AddDays(8).AddHours(2), 
        End = DateTime.UtcNow.AddDays(8).AddHours(6), 
        PriceAdult = 264, PriceUnder3 = 52, PriceUnder10 = 132, PriceUnder18 = 237,  Type = "Plane", Seats = 104,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[141], Start = DateTime.UtcNow.AddDays(30).AddHours(5), 
        End = DateTime.UtcNow.AddDays(30).AddHours(13), 
        PriceAdult = 269, PriceUnder3 = 53, PriceUnder10 = 134, PriceUnder18 = 242,  Type = "Train", Seats = 50,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[142], Start = DateTime.UtcNow.AddDays(24).AddHours(17), 
        End = DateTime.UtcNow.AddDays(24).AddHours(20), 
        PriceAdult = 168, PriceUnder3 = 33, PriceUnder10 = 84, PriceUnder18 = 151,  Type = "Plane", Seats = 153,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[143], Start = DateTime.UtcNow.AddDays(17).AddHours(16), 
        End = DateTime.UtcNow.AddDays(17).AddHours(22), 
        PriceAdult = 175, PriceUnder3 = 35, PriceUnder10 = 87, PriceUnder18 = 157,  Type = "Bus", Seats = 200,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[144], Start = DateTime.UtcNow.AddDays(47).AddHours(0), 
        End = DateTime.UtcNow.AddDays(47).AddHours(5), 
        PriceAdult = 83, PriceUnder3 = 16, PriceUnder10 = 41, PriceUnder18 = 74,  Type = "Train", Seats = 153,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[145], Start = DateTime.UtcNow.AddDays(61).AddHours(17), 
        End = DateTime.UtcNow.AddDays(62).AddHours(5), 
        PriceAdult = 170, PriceUnder3 = 34, PriceUnder10 = 85, PriceUnder18 = 153,  Type = "Plane", Seats = 167,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[146], Start = DateTime.UtcNow.AddDays(16).AddHours(21), 
        End = DateTime.UtcNow.AddDays(16).AddHours(24), 
        PriceAdult = 104, PriceUnder3 = 20, PriceUnder10 = 52, PriceUnder18 = 93,  Type = "Plane", Seats = 170,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[147], Start = DateTime.UtcNow.AddDays(55).AddHours(12), 
        End = DateTime.UtcNow.AddDays(55).AddHours(14), 
        PriceAdult = 268, PriceUnder3 = 53, PriceUnder10 = 134, PriceUnder18 = 241,  Type = "Plane", Seats = 132,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[148], Start = DateTime.UtcNow.AddDays(22).AddHours(15), 
        End = DateTime.UtcNow.AddDays(23).AddHours(3), 
        PriceAdult = 110, PriceUnder3 = 22, PriceUnder10 = 55, PriceUnder18 = 99,  Type = "Bus", Seats = 165,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[149], Start = DateTime.UtcNow.AddDays(12).AddHours(11), 
        End = DateTime.UtcNow.AddDays(12).AddHours(14), 
        PriceAdult = 91, PriceUnder3 = 18, PriceUnder10 = 45, PriceUnder18 = 81,  Type = "Bus", Seats = 187,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[150], Start = DateTime.UtcNow.AddDays(54).AddHours(1), 
        End = DateTime.UtcNow.AddDays(54).AddHours(8), 
        PriceAdult = 89, PriceUnder3 = 17, PriceUnder10 = 44, PriceUnder18 = 80,  Type = "Plane", Seats = 162,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[151], Start = DateTime.UtcNow.AddDays(79).AddHours(23), 
        End = DateTime.UtcNow.AddDays(80).AddHours(11), 
        PriceAdult = 68, PriceUnder3 = 13, PriceUnder10 = 34, PriceUnder18 = 61,  Type = "Plane", Seats = 91,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[152], Start = DateTime.UtcNow.AddDays(1).AddHours(22), 
        End = DateTime.UtcNow.AddDays(2).AddHours(8), 
        PriceAdult = 78, PriceUnder3 = 15, PriceUnder10 = 39, PriceUnder18 = 70,  Type = "Train", Seats = 187,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[153], Start = DateTime.UtcNow.AddDays(20).AddHours(3), 
        End = DateTime.UtcNow.AddDays(20).AddHours(8), 
        PriceAdult = 131, PriceUnder3 = 26, PriceUnder10 = 65, PriceUnder18 = 117,  Type = "Train", Seats = 70,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[154], Start = DateTime.UtcNow.AddDays(32).AddHours(6), 
        End = DateTime.UtcNow.AddDays(32).AddHours(10), 
        PriceAdult = 272, PriceUnder3 = 54, PriceUnder10 = 136, PriceUnder18 = 244,  Type = "Train", Seats = 73,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[155], Start = DateTime.UtcNow.AddDays(40).AddHours(4), 
        End = DateTime.UtcNow.AddDays(40).AddHours(12), 
        PriceAdult = 126, PriceUnder3 = 25, PriceUnder10 = 63, PriceUnder18 = 113,  Type = "Bus", Seats = 184,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[156], Start = DateTime.UtcNow.AddDays(43).AddHours(6), 
        End = DateTime.UtcNow.AddDays(43).AddHours(11), 
        PriceAdult = 289, PriceUnder3 = 57, PriceUnder10 = 144, PriceUnder18 = 260,  Type = "Train", Seats = 131,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[157], Start = DateTime.UtcNow.AddDays(4).AddHours(20), 
        End = DateTime.UtcNow.AddDays(5).AddHours(3), 
        PriceAdult = 140, PriceUnder3 = 28, PriceUnder10 = 70, PriceUnder18 = 126,  Type = "Train", Seats = 57,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[158], Start = DateTime.UtcNow.AddDays(78).AddHours(16), 
        End = DateTime.UtcNow.AddDays(78).AddHours(19), 
        PriceAdult = 242, PriceUnder3 = 48, PriceUnder10 = 121, PriceUnder18 = 217,  Type = "Bus", Seats = 168,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[159], Start = DateTime.UtcNow.AddDays(29).AddHours(11), 
        End = DateTime.UtcNow.AddDays(29).AddHours(18), 
        PriceAdult = 247, PriceUnder3 = 49, PriceUnder10 = 123, PriceUnder18 = 222,  Type = "Train", Seats = 85,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[160], Start = DateTime.UtcNow.AddDays(49).AddHours(0), 
        End = DateTime.UtcNow.AddDays(49).AddHours(9), 
        PriceAdult = 197, PriceUnder3 = 39, PriceUnder10 = 98, PriceUnder18 = 177,  Type = "Plane", Seats = 112,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[161], Start = DateTime.UtcNow.AddDays(51).AddHours(2), 
        End = DateTime.UtcNow.AddDays(51).AddHours(8), 
        PriceAdult = 146, PriceUnder3 = 29, PriceUnder10 = 73, PriceUnder18 = 131,  Type = "Bus", Seats = 154,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[162], Start = DateTime.UtcNow.AddDays(30).AddHours(19), 
        End = DateTime.UtcNow.AddDays(31).AddHours(7), 
        PriceAdult = 179, PriceUnder3 = 35, PriceUnder10 = 89, PriceUnder18 = 161,  Type = "Plane", Seats = 171,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[163], Start = DateTime.UtcNow.AddDays(90).AddHours(15), 
        End = DateTime.UtcNow.AddDays(90).AddHours(21), 
        PriceAdult = 188, PriceUnder3 = 37, PriceUnder10 = 94, PriceUnder18 = 169,  Type = "Plane", Seats = 110,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[164], Start = DateTime.UtcNow.AddDays(63).AddHours(1), 
        End = DateTime.UtcNow.AddDays(63).AddHours(8), 
        PriceAdult = 212, PriceUnder3 = 42, PriceUnder10 = 106, PriceUnder18 = 190,  Type = "Plane", Seats = 181,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[165], Start = DateTime.UtcNow.AddDays(89).AddHours(7), 
        End = DateTime.UtcNow.AddDays(89).AddHours(9), 
        PriceAdult = 95, PriceUnder3 = 19, PriceUnder10 = 47, PriceUnder18 = 85,  Type = "Train", Seats = 165,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[166], Start = DateTime.UtcNow.AddDays(43).AddHours(0), 
        End = DateTime.UtcNow.AddDays(43).AddHours(10), 
        PriceAdult = 264, PriceUnder3 = 52, PriceUnder10 = 132, PriceUnder18 = 237,  Type = "Plane", Seats = 180,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[167], Start = DateTime.UtcNow.AddDays(32).AddHours(21), 
        End = DateTime.UtcNow.AddDays(32).AddHours(23), 
        PriceAdult = 191, PriceUnder3 = 38, PriceUnder10 = 95, PriceUnder18 = 171,  Type = "Plane", Seats = 137,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[168], Start = DateTime.UtcNow.AddDays(68).AddHours(15), 
        End = DateTime.UtcNow.AddDays(68).AddHours(19), 
        PriceAdult = 105, PriceUnder3 = 21, PriceUnder10 = 52, PriceUnder18 = 94,  Type = "Plane", Seats = 94,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[169], Start = DateTime.UtcNow.AddDays(23).AddHours(9), 
        End = DateTime.UtcNow.AddDays(23).AddHours(15), 
        PriceAdult = 101, PriceUnder3 = 20, PriceUnder10 = 50, PriceUnder18 = 90,  Type = "Bus", Seats = 74,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[170], Start = DateTime.UtcNow.AddDays(77).AddHours(17), 
        End = DateTime.UtcNow.AddDays(78).AddHours(3), 
        PriceAdult = 158, PriceUnder3 = 31, PriceUnder10 = 79, PriceUnder18 = 142,  Type = "Bus", Seats = 100,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[171], Start = DateTime.UtcNow.AddDays(84).AddHours(4), 
        End = DateTime.UtcNow.AddDays(84).AddHours(16), 
        PriceAdult = 128, PriceUnder3 = 25, PriceUnder10 = 64, PriceUnder18 = 115,  Type = "Train", Seats = 175,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[172], Start = DateTime.UtcNow.AddDays(34).AddHours(7), 
        End = DateTime.UtcNow.AddDays(34).AddHours(17), 
        PriceAdult = 181, PriceUnder3 = 36, PriceUnder10 = 90, PriceUnder18 = 162,  Type = "Train", Seats = 60,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[173], Start = DateTime.UtcNow.AddDays(89).AddHours(5), 
        End = DateTime.UtcNow.AddDays(89).AddHours(8), 
        PriceAdult = 109, PriceUnder3 = 21, PriceUnder10 = 54, PriceUnder18 = 98,  Type = "Plane", Seats = 107,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[174], Start = DateTime.UtcNow.AddDays(32).AddHours(3), 
        End = DateTime.UtcNow.AddDays(32).AddHours(9), 
        PriceAdult = 223, PriceUnder3 = 44, PriceUnder10 = 111, PriceUnder18 = 200,  Type = "Train", Seats = 173,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[175], Start = DateTime.UtcNow.AddDays(2).AddHours(11), 
        End = DateTime.UtcNow.AddDays(2).AddHours(17), 
        PriceAdult = 75, PriceUnder3 = 15, PriceUnder10 = 37, PriceUnder18 = 67,  Type = "Bus", Seats = 185,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[176], Start = DateTime.UtcNow.AddDays(34).AddHours(10), 
        End = DateTime.UtcNow.AddDays(34).AddHours(15), 
        PriceAdult = 191, PriceUnder3 = 38, PriceUnder10 = 95, PriceUnder18 = 171,  Type = "Bus", Seats = 183,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[177], Start = DateTime.UtcNow.AddDays(30).AddHours(0), 
        End = DateTime.UtcNow.AddDays(30).AddHours(12), 
        PriceAdult = 82, PriceUnder3 = 16, PriceUnder10 = 41, PriceUnder18 = 73,  Type = "Bus", Seats = 51,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[178], Start = DateTime.UtcNow.AddDays(86).AddHours(3), 
        End = DateTime.UtcNow.AddDays(86).AddHours(6), 
        PriceAdult = 293, PriceUnder3 = 58, PriceUnder10 = 146, PriceUnder18 = 263,  Type = "Train", Seats = 165,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[179], Start = DateTime.UtcNow.AddDays(51).AddHours(0), 
        End = DateTime.UtcNow.AddDays(51).AddHours(2), 
        PriceAdult = 199, PriceUnder3 = 39, PriceUnder10 = 99, PriceUnder18 = 179,  Type = "Train", Seats = 178,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[180], Start = DateTime.UtcNow.AddDays(42).AddHours(14), 
        End = DateTime.UtcNow.AddDays(42).AddHours(20), 
        PriceAdult = 64, PriceUnder3 = 12, PriceUnder10 = 32, PriceUnder18 = 57,  Type = "Plane", Seats = 154,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[181], Start = DateTime.UtcNow.AddDays(83).AddHours(22), 
        End = DateTime.UtcNow.AddDays(84).AddHours(8), 
        PriceAdult = 74, PriceUnder3 = 14, PriceUnder10 = 37, PriceUnder18 = 66,  Type = "Train", Seats = 93,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[182], Start = DateTime.UtcNow.AddDays(67).AddHours(3), 
        End = DateTime.UtcNow.AddDays(67).AddHours(6), 
        PriceAdult = 197, PriceUnder3 = 39, PriceUnder10 = 98, PriceUnder18 = 177,  Type = "Train", Seats = 74,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[183], Start = DateTime.UtcNow.AddDays(13).AddHours(7), 
        End = DateTime.UtcNow.AddDays(13).AddHours(15), 
        PriceAdult = 289, PriceUnder3 = 57, PriceUnder10 = 144, PriceUnder18 = 260,  Type = "Bus", Seats = 125,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[184], Start = DateTime.UtcNow.AddDays(4).AddHours(20), 
        End = DateTime.UtcNow.AddDays(5).AddHours(2), 
        PriceAdult = 61, PriceUnder3 = 12, PriceUnder10 = 30, PriceUnder18 = 54,  Type = "Bus", Seats = 183,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[185], Start = DateTime.UtcNow.AddDays(23).AddHours(11), 
        End = DateTime.UtcNow.AddDays(23).AddHours(15), 
        PriceAdult = 137, PriceUnder3 = 27, PriceUnder10 = 68, PriceUnder18 = 123,  Type = "Plane", Seats = 132,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[186], Start = DateTime.UtcNow.AddDays(78).AddHours(23), 
        End = DateTime.UtcNow.AddDays(79).AddHours(10), 
        PriceAdult = 234, PriceUnder3 = 46, PriceUnder10 = 117, PriceUnder18 = 210,  Type = "Bus", Seats = 86,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[187], Start = DateTime.UtcNow.AddDays(26).AddHours(9), 
        End = DateTime.UtcNow.AddDays(26).AddHours(14), 
        PriceAdult = 227, PriceUnder3 = 45, PriceUnder10 = 113, PriceUnder18 = 204,  Type = "Plane", Seats = 169,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[188], Start = DateTime.UtcNow.AddDays(88).AddHours(13), 
        End = DateTime.UtcNow.AddDays(88).AddHours(19), 
        PriceAdult = 123, PriceUnder3 = 24, PriceUnder10 = 61, PriceUnder18 = 110,  Type = "Plane", Seats = 143,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[189], Start = DateTime.UtcNow.AddDays(19).AddHours(15), 
        End = DateTime.UtcNow.AddDays(19).AddHours(20), 
        PriceAdult = 256, PriceUnder3 = 51, PriceUnder10 = 128, PriceUnder18 = 230,  Type = "Train", Seats = 56,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[190], Start = DateTime.UtcNow.AddDays(31).AddHours(9), 
        End = DateTime.UtcNow.AddDays(31).AddHours(20), 
        PriceAdult = 277, PriceUnder3 = 55, PriceUnder10 = 138, PriceUnder18 = 249,  Type = "Train", Seats = 158,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[191], Start = DateTime.UtcNow.AddDays(18).AddHours(6), 
        End = DateTime.UtcNow.AddDays(18).AddHours(14), 
        PriceAdult = 192, PriceUnder3 = 38, PriceUnder10 = 96, PriceUnder18 = 172,  Type = "Plane", Seats = 174,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[192], Start = DateTime.UtcNow.AddDays(29).AddHours(16), 
        End = DateTime.UtcNow.AddDays(29).AddHours(23), 
        PriceAdult = 278, PriceUnder3 = 55, PriceUnder10 = 139, PriceUnder18 = 250,  Type = "Bus", Seats = 54,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[193], Start = DateTime.UtcNow.AddDays(47).AddHours(20), 
        End = DateTime.UtcNow.AddDays(48).AddHours(5), 
        PriceAdult = 295, PriceUnder3 = 59, PriceUnder10 = 147, PriceUnder18 = 265,  Type = "Bus", Seats = 112,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[194], Start = DateTime.UtcNow.AddDays(7).AddHours(8), 
        End = DateTime.UtcNow.AddDays(7).AddHours(13), 
        PriceAdult = 194, PriceUnder3 = 38, PriceUnder10 = 97, PriceUnder18 = 174,  Type = "Plane", Seats = 52,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[195], Start = DateTime.UtcNow.AddDays(32).AddHours(1), 
        End = DateTime.UtcNow.AddDays(32).AddHours(10), 
        PriceAdult = 188, PriceUnder3 = 37, PriceUnder10 = 94, PriceUnder18 = 169,  Type = "Bus", Seats = 122,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[196], Start = DateTime.UtcNow.AddDays(17).AddHours(9), 
        End = DateTime.UtcNow.AddDays(17).AddHours(20), 
        PriceAdult = 211, PriceUnder3 = 42, PriceUnder10 = 105, PriceUnder18 = 189,  Type = "Train", Seats = 130,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[197], Start = DateTime.UtcNow.AddDays(20).AddHours(5), 
        End = DateTime.UtcNow.AddDays(20).AddHours(17), 
        PriceAdult = 130, PriceUnder3 = 26, PriceUnder10 = 65, PriceUnder18 = 117,  Type = "Plane", Seats = 55,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[198], Start = DateTime.UtcNow.AddDays(78).AddHours(6), 
        End = DateTime.UtcNow.AddDays(78).AddHours(14), 
        PriceAdult = 227, PriceUnder3 = 45, PriceUnder10 = 113, PriceUnder18 = 204,  Type = "Bus", Seats = 129,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QueryTransportOption
    {
        Id = TransportIds[199], Start = DateTime.UtcNow.AddDays(6).AddHours(8), 
        End = DateTime.UtcNow.AddDays(6).AddHours(10), 
        PriceAdult = 239, PriceUnder3 = 47, PriceUnder10 = 119, PriceUnder18 = 215,  Type = "Plane", Seats = 127,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
                                };
                modelBuilder.Entity<QueryTransportOption>().HasData(queryTransportOptions);
            }
        }
    }
                        