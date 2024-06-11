ď»żusing Microsoft.EntityFrameworkCore;
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

            Guid[] TransportIds = new Guid[200];
                    for (int i = 0; i < TransportIds.Length; i++)
                    {
                        TransportIds[i] = Guid.NewGuid();
                    }

        
        var transportOptions = new[]
            {
                
    new CommandTransportOption
    {
        Id = TransportIds[0], Start = DateTime.UtcNow.AddDays(36).AddHours(10), 
        End = DateTime.UtcNow.AddDays(36).AddHours(18), 
        PriceAdult = 58, Type = "Bus", InitialSeats = 183,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[1], Start = DateTime.UtcNow.AddDays(89).AddHours(0), 
        End = DateTime.UtcNow.AddDays(89).AddHours(6), 
        PriceAdult = 90, Type = "Bus", InitialSeats = 99,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[2], Start = DateTime.UtcNow.AddDays(29).AddHours(2), 
        End = DateTime.UtcNow.AddDays(29).AddHours(5), 
        PriceAdult = 153, Type = "Plane", InitialSeats = 71,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[3], Start = DateTime.UtcNow.AddDays(73).AddHours(2), 
        End = DateTime.UtcNow.AddDays(73).AddHours(10), 
        PriceAdult = 226, Type = "Plane", InitialSeats = 74,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[4], Start = DateTime.UtcNow.AddDays(3).AddHours(15), 
        End = DateTime.UtcNow.AddDays(3).AddHours(18), 
        PriceAdult = 236, Type = "Plane", InitialSeats = 84,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[5], Start = DateTime.UtcNow.AddDays(33).AddHours(21), 
        End = DateTime.UtcNow.AddDays(34).AddHours(1), 
        PriceAdult = 134, Type = "Train", InitialSeats = 151,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[6], Start = DateTime.UtcNow.AddDays(62).AddHours(12), 
        End = DateTime.UtcNow.AddDays(62).AddHours(22), 
        PriceAdult = 295, Type = "Bus", InitialSeats = 56,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[7], Start = DateTime.UtcNow.AddDays(58).AddHours(5), 
        End = DateTime.UtcNow.AddDays(58).AddHours(10), 
        PriceAdult = 50, Type = "Train", InitialSeats = 157,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[8], Start = DateTime.UtcNow.AddDays(69).AddHours(12), 
        End = DateTime.UtcNow.AddDays(69).AddHours(24), 
        PriceAdult = 56, Type = "Train", InitialSeats = 186,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[9], Start = DateTime.UtcNow.AddDays(67).AddHours(6), 
        End = DateTime.UtcNow.AddDays(67).AddHours(15), 
        PriceAdult = 169, Type = "Bus", InitialSeats = 156,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[10], Start = DateTime.UtcNow.AddDays(53).AddHours(19), 
        End = DateTime.UtcNow.AddDays(54).AddHours(4), 
        PriceAdult = 154, Type = "Plane", InitialSeats = 125,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[11], Start = DateTime.UtcNow.AddDays(77).AddHours(11), 
        End = DateTime.UtcNow.AddDays(77).AddHours(23), 
        PriceAdult = 120, Type = "Train", InitialSeats = 123,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[12], Start = DateTime.UtcNow.AddDays(6).AddHours(22), 
        End = DateTime.UtcNow.AddDays(7).AddHours(2), 
        PriceAdult = 70, Type = "Train", InitialSeats = 84,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[13], Start = DateTime.UtcNow.AddDays(36).AddHours(2), 
        End = DateTime.UtcNow.AddDays(36).AddHours(13), 
        PriceAdult = 133, Type = "Train", InitialSeats = 130,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[14], Start = DateTime.UtcNow.AddDays(89).AddHours(17), 
        End = DateTime.UtcNow.AddDays(89).AddHours(19), 
        PriceAdult = 174, Type = "Train", InitialSeats = 141,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[15], Start = DateTime.UtcNow.AddDays(42).AddHours(5), 
        End = DateTime.UtcNow.AddDays(42).AddHours(9), 
        PriceAdult = 55, Type = "Plane", InitialSeats = 93,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[16], Start = DateTime.UtcNow.AddDays(87).AddHours(10), 
        End = DateTime.UtcNow.AddDays(87).AddHours(13), 
        PriceAdult = 217, Type = "Bus", InitialSeats = 161,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[17], Start = DateTime.UtcNow.AddDays(28).AddHours(9), 
        End = DateTime.UtcNow.AddDays(28).AddHours(16), 
        PriceAdult = 230, Type = "Plane", InitialSeats = 168,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[18], Start = DateTime.UtcNow.AddDays(18).AddHours(13), 
        End = DateTime.UtcNow.AddDays(18).AddHours(20), 
        PriceAdult = 116, Type = "Plane", InitialSeats = 71,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[19], Start = DateTime.UtcNow.AddDays(61).AddHours(7), 
        End = DateTime.UtcNow.AddDays(61).AddHours(13), 
        PriceAdult = 297, Type = "Bus", InitialSeats = 107,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[20], Start = DateTime.UtcNow.AddDays(63).AddHours(6), 
        End = DateTime.UtcNow.AddDays(63).AddHours(13), 
        PriceAdult = 147, Type = "Plane", InitialSeats = 116,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[21], Start = DateTime.UtcNow.AddDays(18).AddHours(5), 
        End = DateTime.UtcNow.AddDays(18).AddHours(11), 
        PriceAdult = 172, Type = "Bus", InitialSeats = 114,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[22], Start = DateTime.UtcNow.AddDays(3).AddHours(2), 
        End = DateTime.UtcNow.AddDays(3).AddHours(13), 
        PriceAdult = 175, Type = "Train", InitialSeats = 110,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[23], Start = DateTime.UtcNow.AddDays(36).AddHours(21), 
        End = DateTime.UtcNow.AddDays(37).AddHours(8), 
        PriceAdult = 99, Type = "Plane", InitialSeats = 190,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[24], Start = DateTime.UtcNow.AddDays(79).AddHours(10), 
        End = DateTime.UtcNow.AddDays(79).AddHours(14), 
        PriceAdult = 277, Type = "Plane", InitialSeats = 167,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[25], Start = DateTime.UtcNow.AddDays(44).AddHours(0), 
        End = DateTime.UtcNow.AddDays(44).AddHours(12), 
        PriceAdult = 220, Type = "Bus", InitialSeats = 136,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[26], Start = DateTime.UtcNow.AddDays(7).AddHours(0), 
        End = DateTime.UtcNow.AddDays(7).AddHours(12), 
        PriceAdult = 262, Type = "Train", InitialSeats = 139,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[27], Start = DateTime.UtcNow.AddDays(87).AddHours(13), 
        End = DateTime.UtcNow.AddDays(87).AddHours(18), 
        PriceAdult = 289, Type = "Bus", InitialSeats = 61,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[28], Start = DateTime.UtcNow.AddDays(18).AddHours(21), 
        End = DateTime.UtcNow.AddDays(18).AddHours(24), 
        PriceAdult = 279, Type = "Bus", InitialSeats = 164,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[29], Start = DateTime.UtcNow.AddDays(86).AddHours(12), 
        End = DateTime.UtcNow.AddDays(86).AddHours(18), 
        PriceAdult = 95, Type = "Plane", InitialSeats = 106,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[30], Start = DateTime.UtcNow.AddDays(89).AddHours(2), 
        End = DateTime.UtcNow.AddDays(89).AddHours(4), 
        PriceAdult = 250, Type = "Bus", InitialSeats = 71,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[31], Start = DateTime.UtcNow.AddDays(69).AddHours(2), 
        End = DateTime.UtcNow.AddDays(69).AddHours(4), 
        PriceAdult = 119, Type = "Train", InitialSeats = 184,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[32], Start = DateTime.UtcNow.AddDays(51).AddHours(1), 
        End = DateTime.UtcNow.AddDays(51).AddHours(10), 
        PriceAdult = 112, Type = "Bus", InitialSeats = 59,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[33], Start = DateTime.UtcNow.AddDays(90).AddHours(2), 
        End = DateTime.UtcNow.AddDays(90).AddHours(8), 
        PriceAdult = 200, Type = "Plane", InitialSeats = 120,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[34], Start = DateTime.UtcNow.AddDays(45).AddHours(0), 
        End = DateTime.UtcNow.AddDays(45).AddHours(7), 
        PriceAdult = 300, Type = "Bus", InitialSeats = 138,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[35], Start = DateTime.UtcNow.AddDays(25).AddHours(14), 
        End = DateTime.UtcNow.AddDays(25).AddHours(17), 
        PriceAdult = 65, Type = "Plane", InitialSeats = 103,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[36], Start = DateTime.UtcNow.AddDays(2).AddHours(18), 
        End = DateTime.UtcNow.AddDays(3).AddHours(5), 
        PriceAdult = 286, Type = "Train", InitialSeats = 102,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[37], Start = DateTime.UtcNow.AddDays(73).AddHours(2), 
        End = DateTime.UtcNow.AddDays(73).AddHours(12), 
        PriceAdult = 50, Type = "Bus", InitialSeats = 195,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[38], Start = DateTime.UtcNow.AddDays(75).AddHours(15), 
        End = DateTime.UtcNow.AddDays(76).AddHours(1), 
        PriceAdult = 256, Type = "Train", InitialSeats = 174,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[39], Start = DateTime.UtcNow.AddDays(4).AddHours(14), 
        End = DateTime.UtcNow.AddDays(4).AddHours(22), 
        PriceAdult = 189, Type = "Bus", InitialSeats = 96,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[40], Start = DateTime.UtcNow.AddDays(3).AddHours(20), 
        End = DateTime.UtcNow.AddDays(3).AddHours(22), 
        PriceAdult = 155, Type = "Plane", InitialSeats = 133,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[41], Start = DateTime.UtcNow.AddDays(80).AddHours(18), 
        End = DateTime.UtcNow.AddDays(81).AddHours(3), 
        PriceAdult = 172, Type = "Bus", InitialSeats = 120,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[42], Start = DateTime.UtcNow.AddDays(6).AddHours(22), 
        End = DateTime.UtcNow.AddDays(7).AddHours(8), 
        PriceAdult = 127, Type = "Train", InitialSeats = 117,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[43], Start = DateTime.UtcNow.AddDays(76).AddHours(20), 
        End = DateTime.UtcNow.AddDays(77).AddHours(2), 
        PriceAdult = 115, Type = "Plane", InitialSeats = 123,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[44], Start = DateTime.UtcNow.AddDays(28).AddHours(18), 
        End = DateTime.UtcNow.AddDays(29).AddHours(6), 
        PriceAdult = 127, Type = "Train", InitialSeats = 132,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[45], Start = DateTime.UtcNow.AddDays(67).AddHours(1), 
        End = DateTime.UtcNow.AddDays(67).AddHours(8), 
        PriceAdult = 162, Type = "Plane", InitialSeats = 129,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[46], Start = DateTime.UtcNow.AddDays(60).AddHours(2), 
        End = DateTime.UtcNow.AddDays(60).AddHours(8), 
        PriceAdult = 165, Type = "Plane", InitialSeats = 119,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[47], Start = DateTime.UtcNow.AddDays(80).AddHours(11), 
        End = DateTime.UtcNow.AddDays(80).AddHours(18), 
        PriceAdult = 287, Type = "Train", InitialSeats = 182,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[48], Start = DateTime.UtcNow.AddDays(6).AddHours(6), 
        End = DateTime.UtcNow.AddDays(6).AddHours(17), 
        PriceAdult = 78, Type = "Bus", InitialSeats = 156,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[49], Start = DateTime.UtcNow.AddDays(58).AddHours(16), 
        End = DateTime.UtcNow.AddDays(58).AddHours(20), 
        PriceAdult = 134, Type = "Plane", InitialSeats = 87,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[50], Start = DateTime.UtcNow.AddDays(21).AddHours(23), 
        End = DateTime.UtcNow.AddDays(22).AddHours(8), 
        PriceAdult = 135, Type = "Plane", InitialSeats = 77,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[51], Start = DateTime.UtcNow.AddDays(51).AddHours(19), 
        End = DateTime.UtcNow.AddDays(52).AddHours(2), 
        PriceAdult = 168, Type = "Plane", InitialSeats = 168,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[52], Start = DateTime.UtcNow.AddDays(70).AddHours(18), 
        End = DateTime.UtcNow.AddDays(71).AddHours(5), 
        PriceAdult = 206, Type = "Train", InitialSeats = 172,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[53], Start = DateTime.UtcNow.AddDays(27).AddHours(13), 
        End = DateTime.UtcNow.AddDays(27).AddHours(21), 
        PriceAdult = 80, Type = "Train", InitialSeats = 54,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[54], Start = DateTime.UtcNow.AddDays(89).AddHours(8), 
        End = DateTime.UtcNow.AddDays(89).AddHours(11), 
        PriceAdult = 117, Type = "Plane", InitialSeats = 121,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[55], Start = DateTime.UtcNow.AddDays(32).AddHours(13), 
        End = DateTime.UtcNow.AddDays(32).AddHours(22), 
        PriceAdult = 268, Type = "Train", InitialSeats = 191,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[56], Start = DateTime.UtcNow.AddDays(37).AddHours(20), 
        End = DateTime.UtcNow.AddDays(38).AddHours(6), 
        PriceAdult = 79, Type = "Plane", InitialSeats = 118,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[57], Start = DateTime.UtcNow.AddDays(90).AddHours(2), 
        End = DateTime.UtcNow.AddDays(90).AddHours(5), 
        PriceAdult = 142, Type = "Train", InitialSeats = 88,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[58], Start = DateTime.UtcNow.AddDays(50).AddHours(17), 
        End = DateTime.UtcNow.AddDays(51).AddHours(2), 
        PriceAdult = 285, Type = "Bus", InitialSeats = 126,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[59], Start = DateTime.UtcNow.AddDays(71).AddHours(12), 
        End = DateTime.UtcNow.AddDays(71).AddHours(17), 
        PriceAdult = 128, Type = "Bus", InitialSeats = 88,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[60], Start = DateTime.UtcNow.AddDays(86).AddHours(15), 
        End = DateTime.UtcNow.AddDays(86).AddHours(18), 
        PriceAdult = 206, Type = "Train", InitialSeats = 138,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[61], Start = DateTime.UtcNow.AddDays(39).AddHours(0), 
        End = DateTime.UtcNow.AddDays(39).AddHours(6), 
        PriceAdult = 104, Type = "Train", InitialSeats = 171,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[62], Start = DateTime.UtcNow.AddDays(64).AddHours(16), 
        End = DateTime.UtcNow.AddDays(64).AddHours(19), 
        PriceAdult = 294, Type = "Train", InitialSeats = 97,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[63], Start = DateTime.UtcNow.AddDays(39).AddHours(10), 
        End = DateTime.UtcNow.AddDays(39).AddHours(14), 
        PriceAdult = 181, Type = "Train", InitialSeats = 95,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[64], Start = DateTime.UtcNow.AddDays(6).AddHours(12), 
        End = DateTime.UtcNow.AddDays(6).AddHours(22), 
        PriceAdult = 62, Type = "Plane", InitialSeats = 188,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[65], Start = DateTime.UtcNow.AddDays(53).AddHours(21), 
        End = DateTime.UtcNow.AddDays(53).AddHours(23), 
        PriceAdult = 164, Type = "Plane", InitialSeats = 155,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[66], Start = DateTime.UtcNow.AddDays(46).AddHours(21), 
        End = DateTime.UtcNow.AddDays(47).AddHours(3), 
        PriceAdult = 194, Type = "Plane", InitialSeats = 82,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[67], Start = DateTime.UtcNow.AddDays(89).AddHours(10), 
        End = DateTime.UtcNow.AddDays(89).AddHours(20), 
        PriceAdult = 265, Type = "Bus", InitialSeats = 112,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[68], Start = DateTime.UtcNow.AddDays(13).AddHours(20), 
        End = DateTime.UtcNow.AddDays(14).AddHours(6), 
        PriceAdult = 92, Type = "Plane", InitialSeats = 180,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[69], Start = DateTime.UtcNow.AddDays(14).AddHours(3), 
        End = DateTime.UtcNow.AddDays(14).AddHours(9), 
        PriceAdult = 176, Type = "Train", InitialSeats = 97,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[70], Start = DateTime.UtcNow.AddDays(61).AddHours(10), 
        End = DateTime.UtcNow.AddDays(61).AddHours(20), 
        PriceAdult = 88, Type = "Train", InitialSeats = 54,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[71], Start = DateTime.UtcNow.AddDays(9).AddHours(8), 
        End = DateTime.UtcNow.AddDays(9).AddHours(12), 
        PriceAdult = 237, Type = "Plane", InitialSeats = 81,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[72], Start = DateTime.UtcNow.AddDays(67).AddHours(19), 
        End = DateTime.UtcNow.AddDays(68).AddHours(1), 
        PriceAdult = 268, Type = "Train", InitialSeats = 130,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[73], Start = DateTime.UtcNow.AddDays(74).AddHours(18), 
        End = DateTime.UtcNow.AddDays(74).AddHours(22), 
        PriceAdult = 217, Type = "Plane", InitialSeats = 54,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[74], Start = DateTime.UtcNow.AddDays(30).AddHours(7), 
        End = DateTime.UtcNow.AddDays(30).AddHours(9), 
        PriceAdult = 223, Type = "Bus", InitialSeats = 114,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[75], Start = DateTime.UtcNow.AddDays(84).AddHours(7), 
        End = DateTime.UtcNow.AddDays(84).AddHours(11), 
        PriceAdult = 220, Type = "Plane", InitialSeats = 178,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[76], Start = DateTime.UtcNow.AddDays(42).AddHours(0), 
        End = DateTime.UtcNow.AddDays(42).AddHours(8), 
        PriceAdult = 258, Type = "Train", InitialSeats = 92,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[77], Start = DateTime.UtcNow.AddDays(21).AddHours(12), 
        End = DateTime.UtcNow.AddDays(21).AddHours(14), 
        PriceAdult = 237, Type = "Train", InitialSeats = 152,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[78], Start = DateTime.UtcNow.AddDays(69).AddHours(2), 
        End = DateTime.UtcNow.AddDays(69).AddHours(9), 
        PriceAdult = 271, Type = "Plane", InitialSeats = 171,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[79], Start = DateTime.UtcNow.AddDays(24).AddHours(1), 
        End = DateTime.UtcNow.AddDays(24).AddHours(6), 
        PriceAdult = 130, Type = "Train", InitialSeats = 101,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[80], Start = DateTime.UtcNow.AddDays(47).AddHours(20), 
        End = DateTime.UtcNow.AddDays(48).AddHours(1), 
        PriceAdult = 159, Type = "Bus", InitialSeats = 138,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[81], Start = DateTime.UtcNow.AddDays(67).AddHours(14), 
        End = DateTime.UtcNow.AddDays(68).AddHours(2), 
        PriceAdult = 222, Type = "Train", InitialSeats = 116,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[82], Start = DateTime.UtcNow.AddDays(31).AddHours(12), 
        End = DateTime.UtcNow.AddDays(31).AddHours(14), 
        PriceAdult = 108, Type = "Bus", InitialSeats = 153,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[83], Start = DateTime.UtcNow.AddDays(70).AddHours(7), 
        End = DateTime.UtcNow.AddDays(70).AddHours(16), 
        PriceAdult = 174, Type = "Plane", InitialSeats = 81,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[84], Start = DateTime.UtcNow.AddDays(14).AddHours(12), 
        End = DateTime.UtcNow.AddDays(14).AddHours(21), 
        PriceAdult = 245, Type = "Train", InitialSeats = 148,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[85], Start = DateTime.UtcNow.AddDays(48).AddHours(0), 
        End = DateTime.UtcNow.AddDays(48).AddHours(12), 
        PriceAdult = 109, Type = "Train", InitialSeats = 104,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[86], Start = DateTime.UtcNow.AddDays(60).AddHours(6), 
        End = DateTime.UtcNow.AddDays(60).AddHours(11), 
        PriceAdult = 58, Type = "Train", InitialSeats = 75,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[87], Start = DateTime.UtcNow.AddDays(38).AddHours(11), 
        End = DateTime.UtcNow.AddDays(38).AddHours(20), 
        PriceAdult = 63, Type = "Train", InitialSeats = 171,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[88], Start = DateTime.UtcNow.AddDays(2).AddHours(0), 
        End = DateTime.UtcNow.AddDays(2).AddHours(2), 
        PriceAdult = 297, Type = "Bus", InitialSeats = 168,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[89], Start = DateTime.UtcNow.AddDays(21).AddHours(7), 
        End = DateTime.UtcNow.AddDays(21).AddHours(19), 
        PriceAdult = 118, Type = "Bus", InitialSeats = 198,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[90], Start = DateTime.UtcNow.AddDays(85).AddHours(10), 
        End = DateTime.UtcNow.AddDays(85).AddHours(14), 
        PriceAdult = 182, Type = "Train", InitialSeats = 124,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[91], Start = DateTime.UtcNow.AddDays(60).AddHours(1), 
        End = DateTime.UtcNow.AddDays(60).AddHours(10), 
        PriceAdult = 176, Type = "Plane", InitialSeats = 182,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[92], Start = DateTime.UtcNow.AddDays(6).AddHours(12), 
        End = DateTime.UtcNow.AddDays(6).AddHours(14), 
        PriceAdult = 287, Type = "Train", InitialSeats = 78,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[93], Start = DateTime.UtcNow.AddDays(16).AddHours(8), 
        End = DateTime.UtcNow.AddDays(16).AddHours(16), 
        PriceAdult = 110, Type = "Bus", InitialSeats = 89,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[94], Start = DateTime.UtcNow.AddDays(37).AddHours(6), 
        End = DateTime.UtcNow.AddDays(37).AddHours(10), 
        PriceAdult = 110, Type = "Bus", InitialSeats = 175,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[95], Start = DateTime.UtcNow.AddDays(56).AddHours(1), 
        End = DateTime.UtcNow.AddDays(56).AddHours(13), 
        PriceAdult = 141, Type = "Plane", InitialSeats = 186,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[96], Start = DateTime.UtcNow.AddDays(89).AddHours(7), 
        End = DateTime.UtcNow.AddDays(89).AddHours(19), 
        PriceAdult = 162, Type = "Plane", InitialSeats = 69,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[97], Start = DateTime.UtcNow.AddDays(5).AddHours(9), 
        End = DateTime.UtcNow.AddDays(5).AddHours(14), 
        PriceAdult = 124, Type = "Bus", InitialSeats = 158,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[98], Start = DateTime.UtcNow.AddDays(18).AddHours(19), 
        End = DateTime.UtcNow.AddDays(18).AddHours(22), 
        PriceAdult = 115, Type = "Train", InitialSeats = 87,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[99], Start = DateTime.UtcNow.AddDays(71).AddHours(9), 
        End = DateTime.UtcNow.AddDays(71).AddHours(12), 
        PriceAdult = 262, Type = "Train", InitialSeats = 57,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[100], Start = DateTime.UtcNow.AddDays(4).AddHours(11), 
        End = DateTime.UtcNow.AddDays(4).AddHours(19), 
        PriceAdult = 293, Type = "Plane", InitialSeats = 161,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[101], Start = DateTime.UtcNow.AddDays(60).AddHours(2), 
        End = DateTime.UtcNow.AddDays(60).AddHours(13), 
        PriceAdult = 206, Type = "Plane", InitialSeats = 63,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[102], Start = DateTime.UtcNow.AddDays(64).AddHours(16), 
        End = DateTime.UtcNow.AddDays(65).AddHours(1), 
        PriceAdult = 141, Type = "Plane", InitialSeats = 100,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[103], Start = DateTime.UtcNow.AddDays(50).AddHours(2), 
        End = DateTime.UtcNow.AddDays(50).AddHours(8), 
        PriceAdult = 191, Type = "Bus", InitialSeats = 95,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[104], Start = DateTime.UtcNow.AddDays(15).AddHours(10), 
        End = DateTime.UtcNow.AddDays(15).AddHours(16), 
        PriceAdult = 185, Type = "Bus", InitialSeats = 154,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[105], Start = DateTime.UtcNow.AddDays(50).AddHours(15), 
        End = DateTime.UtcNow.AddDays(50).AddHours(17), 
        PriceAdult = 74, Type = "Train", InitialSeats = 86,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[106], Start = DateTime.UtcNow.AddDays(42).AddHours(11), 
        End = DateTime.UtcNow.AddDays(42).AddHours(23), 
        PriceAdult = 167, Type = "Bus", InitialSeats = 177,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[107], Start = DateTime.UtcNow.AddDays(79).AddHours(4), 
        End = DateTime.UtcNow.AddDays(79).AddHours(16), 
        PriceAdult = 194, Type = "Plane", InitialSeats = 142,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[108], Start = DateTime.UtcNow.AddDays(10).AddHours(16), 
        End = DateTime.UtcNow.AddDays(10).AddHours(22), 
        PriceAdult = 87, Type = "Plane", InitialSeats = 176,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[109], Start = DateTime.UtcNow.AddDays(13).AddHours(9), 
        End = DateTime.UtcNow.AddDays(13).AddHours(11), 
        PriceAdult = 271, Type = "Train", InitialSeats = 148,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[110], Start = DateTime.UtcNow.AddDays(42).AddHours(5), 
        End = DateTime.UtcNow.AddDays(42).AddHours(9), 
        PriceAdult = 254, Type = "Bus", InitialSeats = 156,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[111], Start = DateTime.UtcNow.AddDays(4).AddHours(3), 
        End = DateTime.UtcNow.AddDays(4).AddHours(12), 
        PriceAdult = 286, Type = "Train", InitialSeats = 186,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[112], Start = DateTime.UtcNow.AddDays(50).AddHours(23), 
        End = DateTime.UtcNow.AddDays(51).AddHours(1), 
        PriceAdult = 138, Type = "Train", InitialSeats = 135,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[113], Start = DateTime.UtcNow.AddDays(49).AddHours(22), 
        End = DateTime.UtcNow.AddDays(50).AddHours(4), 
        PriceAdult = 259, Type = "Plane", InitialSeats = 71,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[114], Start = DateTime.UtcNow.AddDays(24).AddHours(14), 
        End = DateTime.UtcNow.AddDays(25).AddHours(1), 
        PriceAdult = 84, Type = "Bus", InitialSeats = 59,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[115], Start = DateTime.UtcNow.AddDays(75).AddHours(17), 
        End = DateTime.UtcNow.AddDays(75).AddHours(21), 
        PriceAdult = 276, Type = "Bus", InitialSeats = 57,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[116], Start = DateTime.UtcNow.AddDays(39).AddHours(9), 
        End = DateTime.UtcNow.AddDays(39).AddHours(15), 
        PriceAdult = 133, Type = "Plane", InitialSeats = 78,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[117], Start = DateTime.UtcNow.AddDays(6).AddHours(9), 
        End = DateTime.UtcNow.AddDays(6).AddHours(14), 
        PriceAdult = 172, Type = "Plane", InitialSeats = 158,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[118], Start = DateTime.UtcNow.AddDays(22).AddHours(3), 
        End = DateTime.UtcNow.AddDays(22).AddHours(13), 
        PriceAdult = 166, Type = "Train", InitialSeats = 84,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[119], Start = DateTime.UtcNow.AddDays(20).AddHours(8), 
        End = DateTime.UtcNow.AddDays(20).AddHours(15), 
        PriceAdult = 125, Type = "Train", InitialSeats = 61,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[120], Start = DateTime.UtcNow.AddDays(88).AddHours(17), 
        End = DateTime.UtcNow.AddDays(88).AddHours(22), 
        PriceAdult = 168, Type = "Train", InitialSeats = 155,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[121], Start = DateTime.UtcNow.AddDays(24).AddHours(13), 
        End = DateTime.UtcNow.AddDays(24).AddHours(18), 
        PriceAdult = 276, Type = "Bus", InitialSeats = 52,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[122], Start = DateTime.UtcNow.AddDays(86).AddHours(12), 
        End = DateTime.UtcNow.AddDays(86).AddHours(16), 
        PriceAdult = 230, Type = "Train", InitialSeats = 178,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[123], Start = DateTime.UtcNow.AddDays(20).AddHours(15), 
        End = DateTime.UtcNow.AddDays(20).AddHours(18), 
        PriceAdult = 125, Type = "Plane", InitialSeats = 113,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[124], Start = DateTime.UtcNow.AddDays(17).AddHours(6), 
        End = DateTime.UtcNow.AddDays(17).AddHours(10), 
        PriceAdult = 57, Type = "Bus", InitialSeats = 178,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[125], Start = DateTime.UtcNow.AddDays(77).AddHours(1), 
        End = DateTime.UtcNow.AddDays(77).AddHours(7), 
        PriceAdult = 179, Type = "Train", InitialSeats = 51,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[126], Start = DateTime.UtcNow.AddDays(2).AddHours(2), 
        End = DateTime.UtcNow.AddDays(2).AddHours(9), 
        PriceAdult = 252, Type = "Train", InitialSeats = 172,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[127], Start = DateTime.UtcNow.AddDays(8).AddHours(20), 
        End = DateTime.UtcNow.AddDays(8).AddHours(24), 
        PriceAdult = 274, Type = "Train", InitialSeats = 176,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[128], Start = DateTime.UtcNow.AddDays(87).AddHours(6), 
        End = DateTime.UtcNow.AddDays(87).AddHours(13), 
        PriceAdult = 161, Type = "Bus", InitialSeats = 186,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[129], Start = DateTime.UtcNow.AddDays(67).AddHours(20), 
        End = DateTime.UtcNow.AddDays(68).AddHours(3), 
        PriceAdult = 252, Type = "Plane", InitialSeats = 193,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[130], Start = DateTime.UtcNow.AddDays(27).AddHours(18), 
        End = DateTime.UtcNow.AddDays(28).AddHours(1), 
        PriceAdult = 79, Type = "Train", InitialSeats = 80,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[131], Start = DateTime.UtcNow.AddDays(70).AddHours(0), 
        End = DateTime.UtcNow.AddDays(70).AddHours(12), 
        PriceAdult = 246, Type = "Bus", InitialSeats = 167,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[132], Start = DateTime.UtcNow.AddDays(39).AddHours(13), 
        End = DateTime.UtcNow.AddDays(39).AddHours(21), 
        PriceAdult = 87, Type = "Train", InitialSeats = 119,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[133], Start = DateTime.UtcNow.AddDays(9).AddHours(7), 
        End = DateTime.UtcNow.AddDays(9).AddHours(19), 
        PriceAdult = 199, Type = "Plane", InitialSeats = 172,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[134], Start = DateTime.UtcNow.AddDays(27).AddHours(14), 
        End = DateTime.UtcNow.AddDays(27).AddHours(21), 
        PriceAdult = 54, Type = "Bus", InitialSeats = 66,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[135], Start = DateTime.UtcNow.AddDays(71).AddHours(16), 
        End = DateTime.UtcNow.AddDays(72).AddHours(4), 
        PriceAdult = 161, Type = "Bus", InitialSeats = 57,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[136], Start = DateTime.UtcNow.AddDays(38).AddHours(23), 
        End = DateTime.UtcNow.AddDays(39).AddHours(3), 
        PriceAdult = 97, Type = "Train", InitialSeats = 150,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[137], Start = DateTime.UtcNow.AddDays(1).AddHours(22), 
        End = DateTime.UtcNow.AddDays(2).AddHours(7), 
        PriceAdult = 265, Type = "Train", InitialSeats = 151,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[138], Start = DateTime.UtcNow.AddDays(13).AddHours(15), 
        End = DateTime.UtcNow.AddDays(13).AddHours(21), 
        PriceAdult = 276, Type = "Bus", InitialSeats = 193,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[139], Start = DateTime.UtcNow.AddDays(69).AddHours(10), 
        End = DateTime.UtcNow.AddDays(69).AddHours(15), 
        PriceAdult = 161, Type = "Bus", InitialSeats = 171,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[140], Start = DateTime.UtcNow.AddDays(59).AddHours(19), 
        End = DateTime.UtcNow.AddDays(60).AddHours(3), 
        PriceAdult = 203, Type = "Bus", InitialSeats = 160,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[141], Start = DateTime.UtcNow.AddDays(22).AddHours(20), 
        End = DateTime.UtcNow.AddDays(23).AddHours(6), 
        PriceAdult = 162, Type = "Train", InitialSeats = 126,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[142], Start = DateTime.UtcNow.AddDays(14).AddHours(23), 
        End = DateTime.UtcNow.AddDays(15).AddHours(5), 
        PriceAdult = 76, Type = "Bus", InitialSeats = 199,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[143], Start = DateTime.UtcNow.AddDays(15).AddHours(14), 
        End = DateTime.UtcNow.AddDays(15).AddHours(19), 
        PriceAdult = 191, Type = "Bus", InitialSeats = 79,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[144], Start = DateTime.UtcNow.AddDays(46).AddHours(23), 
        End = DateTime.UtcNow.AddDays(47).AddHours(8), 
        PriceAdult = 120, Type = "Plane", InitialSeats = 155,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[145], Start = DateTime.UtcNow.AddDays(67).AddHours(0), 
        End = DateTime.UtcNow.AddDays(67).AddHours(12), 
        PriceAdult = 218, Type = "Bus", InitialSeats = 77,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[146], Start = DateTime.UtcNow.AddDays(49).AddHours(21), 
        End = DateTime.UtcNow.AddDays(50).AddHours(3), 
        PriceAdult = 195, Type = "Bus", InitialSeats = 193,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[147], Start = DateTime.UtcNow.AddDays(62).AddHours(13), 
        End = DateTime.UtcNow.AddDays(62).AddHours(22), 
        PriceAdult = 193, Type = "Train", InitialSeats = 143,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[148], Start = DateTime.UtcNow.AddDays(17).AddHours(3), 
        End = DateTime.UtcNow.AddDays(17).AddHours(9), 
        PriceAdult = 152, Type = "Train", InitialSeats = 63,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[149], Start = DateTime.UtcNow.AddDays(18).AddHours(4), 
        End = DateTime.UtcNow.AddDays(18).AddHours(15), 
        PriceAdult = 148, Type = "Bus", InitialSeats = 142,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[150], Start = DateTime.UtcNow.AddDays(52).AddHours(4), 
        End = DateTime.UtcNow.AddDays(52).AddHours(10), 
        PriceAdult = 239, Type = "Plane", InitialSeats = 98,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[151], Start = DateTime.UtcNow.AddDays(71).AddHours(10), 
        End = DateTime.UtcNow.AddDays(71).AddHours(13), 
        PriceAdult = 274, Type = "Plane", InitialSeats = 107,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[152], Start = DateTime.UtcNow.AddDays(4).AddHours(3), 
        End = DateTime.UtcNow.AddDays(4).AddHours(14), 
        PriceAdult = 67, Type = "Plane", InitialSeats = 112,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[153], Start = DateTime.UtcNow.AddDays(66).AddHours(16), 
        End = DateTime.UtcNow.AddDays(67).AddHours(4), 
        PriceAdult = 127, Type = "Train", InitialSeats = 73,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[154], Start = DateTime.UtcNow.AddDays(35).AddHours(2), 
        End = DateTime.UtcNow.AddDays(35).AddHours(9), 
        PriceAdult = 193, Type = "Train", InitialSeats = 184,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[155], Start = DateTime.UtcNow.AddDays(49).AddHours(19), 
        End = DateTime.UtcNow.AddDays(50).AddHours(5), 
        PriceAdult = 250, Type = "Plane", InitialSeats = 127,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[156], Start = DateTime.UtcNow.AddDays(89).AddHours(12), 
        End = DateTime.UtcNow.AddDays(89).AddHours(15), 
        PriceAdult = 79, Type = "Plane", InitialSeats = 140,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[157], Start = DateTime.UtcNow.AddDays(14).AddHours(21), 
        End = DateTime.UtcNow.AddDays(15).AddHours(7), 
        PriceAdult = 200, Type = "Bus", InitialSeats = 163,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[158], Start = DateTime.UtcNow.AddDays(35).AddHours(4), 
        End = DateTime.UtcNow.AddDays(35).AddHours(8), 
        PriceAdult = 247, Type = "Train", InitialSeats = 93,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[159], Start = DateTime.UtcNow.AddDays(9).AddHours(7), 
        End = DateTime.UtcNow.AddDays(9).AddHours(19), 
        PriceAdult = 151, Type = "Plane", InitialSeats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[160], Start = DateTime.UtcNow.AddDays(20).AddHours(16), 
        End = DateTime.UtcNow.AddDays(20).AddHours(22), 
        PriceAdult = 143, Type = "Plane", InitialSeats = 175,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[161], Start = DateTime.UtcNow.AddDays(51).AddHours(16), 
        End = DateTime.UtcNow.AddDays(51).AddHours(18), 
        PriceAdult = 285, Type = "Train", InitialSeats = 148,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[162], Start = DateTime.UtcNow.AddDays(57).AddHours(18), 
        End = DateTime.UtcNow.AddDays(57).AddHours(23), 
        PriceAdult = 253, Type = "Train", InitialSeats = 182,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[163], Start = DateTime.UtcNow.AddDays(41).AddHours(15), 
        End = DateTime.UtcNow.AddDays(42).AddHours(3), 
        PriceAdult = 254, Type = "Plane", InitialSeats = 166,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[164], Start = DateTime.UtcNow.AddDays(24).AddHours(18), 
        End = DateTime.UtcNow.AddDays(25).AddHours(5), 
        PriceAdult = 213, Type = "Plane", InitialSeats = 66,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[165], Start = DateTime.UtcNow.AddDays(9).AddHours(13), 
        End = DateTime.UtcNow.AddDays(9).AddHours(21), 
        PriceAdult = 58, Type = "Plane", InitialSeats = 94,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[166], Start = DateTime.UtcNow.AddDays(47).AddHours(15), 
        End = DateTime.UtcNow.AddDays(47).AddHours(18), 
        PriceAdult = 248, Type = "Bus", InitialSeats = 72,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[167], Start = DateTime.UtcNow.AddDays(37).AddHours(23), 
        End = DateTime.UtcNow.AddDays(38).AddHours(6), 
        PriceAdult = 258, Type = "Bus", InitialSeats = 158,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[168], Start = DateTime.UtcNow.AddDays(19).AddHours(11), 
        End = DateTime.UtcNow.AddDays(19).AddHours(14), 
        PriceAdult = 276, Type = "Plane", InitialSeats = 151,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[169], Start = DateTime.UtcNow.AddDays(10).AddHours(9), 
        End = DateTime.UtcNow.AddDays(10).AddHours(12), 
        PriceAdult = 238, Type = "Bus", InitialSeats = 108,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[170], Start = DateTime.UtcNow.AddDays(41).AddHours(9), 
        End = DateTime.UtcNow.AddDays(41).AddHours(17), 
        PriceAdult = 102, Type = "Bus", InitialSeats = 157,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[171], Start = DateTime.UtcNow.AddDays(7).AddHours(4), 
        End = DateTime.UtcNow.AddDays(7).AddHours(16), 
        PriceAdult = 238, Type = "Train", InitialSeats = 142,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[172], Start = DateTime.UtcNow.AddDays(28).AddHours(20), 
        End = DateTime.UtcNow.AddDays(29).AddHours(7), 
        PriceAdult = 158, Type = "Train", InitialSeats = 155,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[173], Start = DateTime.UtcNow.AddDays(6).AddHours(20), 
        End = DateTime.UtcNow.AddDays(7).AddHours(4), 
        PriceAdult = 247, Type = "Bus", InitialSeats = 69,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[174], Start = DateTime.UtcNow.AddDays(37).AddHours(15), 
        End = DateTime.UtcNow.AddDays(37).AddHours(17), 
        PriceAdult = 248, Type = "Train", InitialSeats = 94,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[175], Start = DateTime.UtcNow.AddDays(44).AddHours(15), 
        End = DateTime.UtcNow.AddDays(44).AddHours(21), 
        PriceAdult = 140, Type = "Plane", InitialSeats = 61,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[176], Start = DateTime.UtcNow.AddDays(9).AddHours(16), 
        End = DateTime.UtcNow.AddDays(9).AddHours(20), 
        PriceAdult = 224, Type = "Train", InitialSeats = 194,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[177], Start = DateTime.UtcNow.AddDays(28).AddHours(3), 
        End = DateTime.UtcNow.AddDays(28).AddHours(13), 
        PriceAdult = 257, Type = "Plane", InitialSeats = 102,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[178], Start = DateTime.UtcNow.AddDays(70).AddHours(10), 
        End = DateTime.UtcNow.AddDays(70).AddHours(22), 
        PriceAdult = 104, Type = "Train", InitialSeats = 73,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[179], Start = DateTime.UtcNow.AddDays(49).AddHours(13), 
        End = DateTime.UtcNow.AddDays(49).AddHours(24), 
        PriceAdult = 254, Type = "Train", InitialSeats = 192,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[180], Start = DateTime.UtcNow.AddDays(36).AddHours(5), 
        End = DateTime.UtcNow.AddDays(36).AddHours(17), 
        PriceAdult = 137, Type = "Plane", InitialSeats = 51,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[181], Start = DateTime.UtcNow.AddDays(11).AddHours(7), 
        End = DateTime.UtcNow.AddDays(11).AddHours(13), 
        PriceAdult = 128, Type = "Bus", InitialSeats = 80,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[182], Start = DateTime.UtcNow.AddDays(30).AddHours(18), 
        End = DateTime.UtcNow.AddDays(31).AddHours(4), 
        PriceAdult = 292, Type = "Bus", InitialSeats = 95,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[183], Start = DateTime.UtcNow.AddDays(48).AddHours(13), 
        End = DateTime.UtcNow.AddDays(49).AddHours(1), 
        PriceAdult = 60, Type = "Bus", InitialSeats = 147,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[184], Start = DateTime.UtcNow.AddDays(86).AddHours(6), 
        End = DateTime.UtcNow.AddDays(86).AddHours(12), 
        PriceAdult = 216, Type = "Bus", InitialSeats = 91,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[185], Start = DateTime.UtcNow.AddDays(84).AddHours(18), 
        End = DateTime.UtcNow.AddDays(84).AddHours(24), 
        PriceAdult = 126, Type = "Bus", InitialSeats = 125,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[186], Start = DateTime.UtcNow.AddDays(24).AddHours(16), 
        End = DateTime.UtcNow.AddDays(24).AddHours(19), 
        PriceAdult = 102, Type = "Train", InitialSeats = 55,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[187], Start = DateTime.UtcNow.AddDays(48).AddHours(19), 
        End = DateTime.UtcNow.AddDays(49).AddHours(2), 
        PriceAdult = 134, Type = "Train", InitialSeats = 120,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[188], Start = DateTime.UtcNow.AddDays(19).AddHours(6), 
        End = DateTime.UtcNow.AddDays(19).AddHours(8), 
        PriceAdult = 107, Type = "Plane", InitialSeats = 55,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[189], Start = DateTime.UtcNow.AddDays(7).AddHours(2), 
        End = DateTime.UtcNow.AddDays(7).AddHours(13), 
        PriceAdult = 246, Type = "Plane", InitialSeats = 81,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[190], Start = DateTime.UtcNow.AddDays(7).AddHours(20), 
        End = DateTime.UtcNow.AddDays(8).AddHours(6), 
        PriceAdult = 207, Type = "Plane", InitialSeats = 77,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[191], Start = DateTime.UtcNow.AddDays(46).AddHours(1), 
        End = DateTime.UtcNow.AddDays(46).AddHours(6), 
        PriceAdult = 162, Type = "Bus", InitialSeats = 162,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[192], Start = DateTime.UtcNow.AddDays(39).AddHours(10), 
        End = DateTime.UtcNow.AddDays(39).AddHours(12), 
        PriceAdult = 286, Type = "Plane", InitialSeats = 144,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[193], Start = DateTime.UtcNow.AddDays(33).AddHours(4), 
        End = DateTime.UtcNow.AddDays(33).AddHours(6), 
        PriceAdult = 259, Type = "Bus", InitialSeats = 143,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[194], Start = DateTime.UtcNow.AddDays(72).AddHours(1), 
        End = DateTime.UtcNow.AddDays(72).AddHours(5), 
        PriceAdult = 262, Type = "Plane", InitialSeats = 140,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[195], Start = DateTime.UtcNow.AddDays(13).AddHours(3), 
        End = DateTime.UtcNow.AddDays(13).AddHours(8), 
        PriceAdult = 163, Type = "Train", InitialSeats = 58,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[196], Start = DateTime.UtcNow.AddDays(79).AddHours(7), 
        End = DateTime.UtcNow.AddDays(79).AddHours(19), 
        PriceAdult = 222, Type = "Plane", InitialSeats = 114,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[197], Start = DateTime.UtcNow.AddDays(84).AddHours(9), 
        End = DateTime.UtcNow.AddDays(84).AddHours(13), 
        PriceAdult = 191, Type = "Plane", InitialSeats = 74,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[198], Start = DateTime.UtcNow.AddDays(89).AddHours(12), 
        End = DateTime.UtcNow.AddDays(89).AddHours(15), 
        PriceAdult = 288, Type = "Plane", InitialSeats = 63,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = TransportIds[199], Start = DateTime.UtcNow.AddDays(4).AddHours(2), 
        End = DateTime.UtcNow.AddDays(4).AddHours(14), 
        PriceAdult = 66, Type = "Train", InitialSeats = 115,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
                                };
                modelBuilder.Entity<CommandTransportOption>().HasData(transportOptions);
            }
        }
    }
                        
        var queryTransportOptions = new[]
                    {
            
    new QuerryTransportOption
    {
        Id = TransportIds[0], Start = DateTime.UtcNow.AddDays(36).AddHours(10), 
        End = DateTime.UtcNow.AddDays(36).AddHours(18), 
        PriceAdult = 58, Type = "Bus", Seats = 183,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[1], Start = DateTime.UtcNow.AddDays(89).AddHours(0), 
        End = DateTime.UtcNow.AddDays(89).AddHours(6), 
        PriceAdult = 90, Type = "Bus", Seats = 99,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[2], Start = DateTime.UtcNow.AddDays(29).AddHours(2), 
        End = DateTime.UtcNow.AddDays(29).AddHours(5), 
        PriceAdult = 153, Type = "Plane", Seats = 71,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[3], Start = DateTime.UtcNow.AddDays(73).AddHours(2), 
        End = DateTime.UtcNow.AddDays(73).AddHours(10), 
        PriceAdult = 226, Type = "Plane", Seats = 74,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[4], Start = DateTime.UtcNow.AddDays(3).AddHours(15), 
        End = DateTime.UtcNow.AddDays(3).AddHours(18), 
        PriceAdult = 236, Type = "Plane", Seats = 84,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[5], Start = DateTime.UtcNow.AddDays(33).AddHours(21), 
        End = DateTime.UtcNow.AddDays(34).AddHours(1), 
        PriceAdult = 134, Type = "Train", Seats = 151,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[6], Start = DateTime.UtcNow.AddDays(62).AddHours(12), 
        End = DateTime.UtcNow.AddDays(62).AddHours(22), 
        PriceAdult = 295, Type = "Bus", Seats = 56,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[7], Start = DateTime.UtcNow.AddDays(58).AddHours(5), 
        End = DateTime.UtcNow.AddDays(58).AddHours(10), 
        PriceAdult = 50, Type = "Train", Seats = 157,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[8], Start = DateTime.UtcNow.AddDays(69).AddHours(12), 
        End = DateTime.UtcNow.AddDays(69).AddHours(24), 
        PriceAdult = 56, Type = "Train", Seats = 186,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[9], Start = DateTime.UtcNow.AddDays(67).AddHours(6), 
        End = DateTime.UtcNow.AddDays(67).AddHours(15), 
        PriceAdult = 169, Type = "Bus", Seats = 156,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[10], Start = DateTime.UtcNow.AddDays(53).AddHours(19), 
        End = DateTime.UtcNow.AddDays(54).AddHours(4), 
        PriceAdult = 154, Type = "Plane", Seats = 125,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[11], Start = DateTime.UtcNow.AddDays(77).AddHours(11), 
        End = DateTime.UtcNow.AddDays(77).AddHours(23), 
        PriceAdult = 120, Type = "Train", Seats = 123,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[12], Start = DateTime.UtcNow.AddDays(6).AddHours(22), 
        End = DateTime.UtcNow.AddDays(7).AddHours(2), 
        PriceAdult = 70, Type = "Train", Seats = 84,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[13], Start = DateTime.UtcNow.AddDays(36).AddHours(2), 
        End = DateTime.UtcNow.AddDays(36).AddHours(13), 
        PriceAdult = 133, Type = "Train", Seats = 130,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[14], Start = DateTime.UtcNow.AddDays(89).AddHours(17), 
        End = DateTime.UtcNow.AddDays(89).AddHours(19), 
        PriceAdult = 174, Type = "Train", Seats = 141,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[15], Start = DateTime.UtcNow.AddDays(42).AddHours(5), 
        End = DateTime.UtcNow.AddDays(42).AddHours(9), 
        PriceAdult = 55, Type = "Plane", Seats = 93,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[16], Start = DateTime.UtcNow.AddDays(87).AddHours(10), 
        End = DateTime.UtcNow.AddDays(87).AddHours(13), 
        PriceAdult = 217, Type = "Bus", Seats = 161,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[17], Start = DateTime.UtcNow.AddDays(28).AddHours(9), 
        End = DateTime.UtcNow.AddDays(28).AddHours(16), 
        PriceAdult = 230, Type = "Plane", Seats = 168,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[18], Start = DateTime.UtcNow.AddDays(18).AddHours(13), 
        End = DateTime.UtcNow.AddDays(18).AddHours(20), 
        PriceAdult = 116, Type = "Plane", Seats = 71,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[19], Start = DateTime.UtcNow.AddDays(61).AddHours(7), 
        End = DateTime.UtcNow.AddDays(61).AddHours(13), 
        PriceAdult = 297, Type = "Bus", Seats = 107,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[20], Start = DateTime.UtcNow.AddDays(63).AddHours(6), 
        End = DateTime.UtcNow.AddDays(63).AddHours(13), 
        PriceAdult = 147, Type = "Plane", Seats = 116,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[21], Start = DateTime.UtcNow.AddDays(18).AddHours(5), 
        End = DateTime.UtcNow.AddDays(18).AddHours(11), 
        PriceAdult = 172, Type = "Bus", Seats = 114,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[22], Start = DateTime.UtcNow.AddDays(3).AddHours(2), 
        End = DateTime.UtcNow.AddDays(3).AddHours(13), 
        PriceAdult = 175, Type = "Train", Seats = 110,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[23], Start = DateTime.UtcNow.AddDays(36).AddHours(21), 
        End = DateTime.UtcNow.AddDays(37).AddHours(8), 
        PriceAdult = 99, Type = "Plane", Seats = 190,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[24], Start = DateTime.UtcNow.AddDays(79).AddHours(10), 
        End = DateTime.UtcNow.AddDays(79).AddHours(14), 
        PriceAdult = 277, Type = "Plane", Seats = 167,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[25], Start = DateTime.UtcNow.AddDays(44).AddHours(0), 
        End = DateTime.UtcNow.AddDays(44).AddHours(12), 
        PriceAdult = 220, Type = "Bus", Seats = 136,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[26], Start = DateTime.UtcNow.AddDays(7).AddHours(0), 
        End = DateTime.UtcNow.AddDays(7).AddHours(12), 
        PriceAdult = 262, Type = "Train", Seats = 139,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[27], Start = DateTime.UtcNow.AddDays(87).AddHours(13), 
        End = DateTime.UtcNow.AddDays(87).AddHours(18), 
        PriceAdult = 289, Type = "Bus", Seats = 61,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[28], Start = DateTime.UtcNow.AddDays(18).AddHours(21), 
        End = DateTime.UtcNow.AddDays(18).AddHours(24), 
        PriceAdult = 279, Type = "Bus", Seats = 164,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[29], Start = DateTime.UtcNow.AddDays(86).AddHours(12), 
        End = DateTime.UtcNow.AddDays(86).AddHours(18), 
        PriceAdult = 95, Type = "Plane", Seats = 106,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[30], Start = DateTime.UtcNow.AddDays(89).AddHours(2), 
        End = DateTime.UtcNow.AddDays(89).AddHours(4), 
        PriceAdult = 250, Type = "Bus", Seats = 71,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[31], Start = DateTime.UtcNow.AddDays(69).AddHours(2), 
        End = DateTime.UtcNow.AddDays(69).AddHours(4), 
        PriceAdult = 119, Type = "Train", Seats = 184,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[32], Start = DateTime.UtcNow.AddDays(51).AddHours(1), 
        End = DateTime.UtcNow.AddDays(51).AddHours(10), 
        PriceAdult = 112, Type = "Bus", Seats = 59,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[33], Start = DateTime.UtcNow.AddDays(90).AddHours(2), 
        End = DateTime.UtcNow.AddDays(90).AddHours(8), 
        PriceAdult = 200, Type = "Plane", Seats = 120,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[34], Start = DateTime.UtcNow.AddDays(45).AddHours(0), 
        End = DateTime.UtcNow.AddDays(45).AddHours(7), 
        PriceAdult = 300, Type = "Bus", Seats = 138,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[35], Start = DateTime.UtcNow.AddDays(25).AddHours(14), 
        End = DateTime.UtcNow.AddDays(25).AddHours(17), 
        PriceAdult = 65, Type = "Plane", Seats = 103,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[36], Start = DateTime.UtcNow.AddDays(2).AddHours(18), 
        End = DateTime.UtcNow.AddDays(3).AddHours(5), 
        PriceAdult = 286, Type = "Train", Seats = 102,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[37], Start = DateTime.UtcNow.AddDays(73).AddHours(2), 
        End = DateTime.UtcNow.AddDays(73).AddHours(12), 
        PriceAdult = 50, Type = "Bus", Seats = 195,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[38], Start = DateTime.UtcNow.AddDays(75).AddHours(15), 
        End = DateTime.UtcNow.AddDays(76).AddHours(1), 
        PriceAdult = 256, Type = "Train", Seats = 174,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[39], Start = DateTime.UtcNow.AddDays(4).AddHours(14), 
        End = DateTime.UtcNow.AddDays(4).AddHours(22), 
        PriceAdult = 189, Type = "Bus", Seats = 96,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[40], Start = DateTime.UtcNow.AddDays(3).AddHours(20), 
        End = DateTime.UtcNow.AddDays(3).AddHours(22), 
        PriceAdult = 155, Type = "Plane", Seats = 133,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[41], Start = DateTime.UtcNow.AddDays(80).AddHours(18), 
        End = DateTime.UtcNow.AddDays(81).AddHours(3), 
        PriceAdult = 172, Type = "Bus", Seats = 120,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[42], Start = DateTime.UtcNow.AddDays(6).AddHours(22), 
        End = DateTime.UtcNow.AddDays(7).AddHours(8), 
        PriceAdult = 127, Type = "Train", Seats = 117,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[43], Start = DateTime.UtcNow.AddDays(76).AddHours(20), 
        End = DateTime.UtcNow.AddDays(77).AddHours(2), 
        PriceAdult = 115, Type = "Plane", Seats = 123,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[44], Start = DateTime.UtcNow.AddDays(28).AddHours(18), 
        End = DateTime.UtcNow.AddDays(29).AddHours(6), 
        PriceAdult = 127, Type = "Train", Seats = 132,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[45], Start = DateTime.UtcNow.AddDays(67).AddHours(1), 
        End = DateTime.UtcNow.AddDays(67).AddHours(8), 
        PriceAdult = 162, Type = "Plane", Seats = 129,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[46], Start = DateTime.UtcNow.AddDays(60).AddHours(2), 
        End = DateTime.UtcNow.AddDays(60).AddHours(8), 
        PriceAdult = 165, Type = "Plane", Seats = 119,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[47], Start = DateTime.UtcNow.AddDays(80).AddHours(11), 
        End = DateTime.UtcNow.AddDays(80).AddHours(18), 
        PriceAdult = 287, Type = "Train", Seats = 182,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[48], Start = DateTime.UtcNow.AddDays(6).AddHours(6), 
        End = DateTime.UtcNow.AddDays(6).AddHours(17), 
        PriceAdult = 78, Type = "Bus", Seats = 156,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[49], Start = DateTime.UtcNow.AddDays(58).AddHours(16), 
        End = DateTime.UtcNow.AddDays(58).AddHours(20), 
        PriceAdult = 134, Type = "Plane", Seats = 87,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[50], Start = DateTime.UtcNow.AddDays(21).AddHours(23), 
        End = DateTime.UtcNow.AddDays(22).AddHours(8), 
        PriceAdult = 135, Type = "Plane", Seats = 77,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[51], Start = DateTime.UtcNow.AddDays(51).AddHours(19), 
        End = DateTime.UtcNow.AddDays(52).AddHours(2), 
        PriceAdult = 168, Type = "Plane", Seats = 168,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[52], Start = DateTime.UtcNow.AddDays(70).AddHours(18), 
        End = DateTime.UtcNow.AddDays(71).AddHours(5), 
        PriceAdult = 206, Type = "Train", Seats = 172,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[53], Start = DateTime.UtcNow.AddDays(27).AddHours(13), 
        End = DateTime.UtcNow.AddDays(27).AddHours(21), 
        PriceAdult = 80, Type = "Train", Seats = 54,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[54], Start = DateTime.UtcNow.AddDays(89).AddHours(8), 
        End = DateTime.UtcNow.AddDays(89).AddHours(11), 
        PriceAdult = 117, Type = "Plane", Seats = 121,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[55], Start = DateTime.UtcNow.AddDays(32).AddHours(13), 
        End = DateTime.UtcNow.AddDays(32).AddHours(22), 
        PriceAdult = 268, Type = "Train", Seats = 191,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[56], Start = DateTime.UtcNow.AddDays(37).AddHours(20), 
        End = DateTime.UtcNow.AddDays(38).AddHours(6), 
        PriceAdult = 79, Type = "Plane", Seats = 118,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[57], Start = DateTime.UtcNow.AddDays(90).AddHours(2), 
        End = DateTime.UtcNow.AddDays(90).AddHours(5), 
        PriceAdult = 142, Type = "Train", Seats = 88,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[58], Start = DateTime.UtcNow.AddDays(50).AddHours(17), 
        End = DateTime.UtcNow.AddDays(51).AddHours(2), 
        PriceAdult = 285, Type = "Bus", Seats = 126,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[59], Start = DateTime.UtcNow.AddDays(71).AddHours(12), 
        End = DateTime.UtcNow.AddDays(71).AddHours(17), 
        PriceAdult = 128, Type = "Bus", Seats = 88,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[60], Start = DateTime.UtcNow.AddDays(86).AddHours(15), 
        End = DateTime.UtcNow.AddDays(86).AddHours(18), 
        PriceAdult = 206, Type = "Train", Seats = 138,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[61], Start = DateTime.UtcNow.AddDays(39).AddHours(0), 
        End = DateTime.UtcNow.AddDays(39).AddHours(6), 
        PriceAdult = 104, Type = "Train", Seats = 171,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[62], Start = DateTime.UtcNow.AddDays(64).AddHours(16), 
        End = DateTime.UtcNow.AddDays(64).AddHours(19), 
        PriceAdult = 294, Type = "Train", Seats = 97,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[63], Start = DateTime.UtcNow.AddDays(39).AddHours(10), 
        End = DateTime.UtcNow.AddDays(39).AddHours(14), 
        PriceAdult = 181, Type = "Train", Seats = 95,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[64], Start = DateTime.UtcNow.AddDays(6).AddHours(12), 
        End = DateTime.UtcNow.AddDays(6).AddHours(22), 
        PriceAdult = 62, Type = "Plane", Seats = 188,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[65], Start = DateTime.UtcNow.AddDays(53).AddHours(21), 
        End = DateTime.UtcNow.AddDays(53).AddHours(23), 
        PriceAdult = 164, Type = "Plane", Seats = 155,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[66], Start = DateTime.UtcNow.AddDays(46).AddHours(21), 
        End = DateTime.UtcNow.AddDays(47).AddHours(3), 
        PriceAdult = 194, Type = "Plane", Seats = 82,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[67], Start = DateTime.UtcNow.AddDays(89).AddHours(10), 
        End = DateTime.UtcNow.AddDays(89).AddHours(20), 
        PriceAdult = 265, Type = "Bus", Seats = 112,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[68], Start = DateTime.UtcNow.AddDays(13).AddHours(20), 
        End = DateTime.UtcNow.AddDays(14).AddHours(6), 
        PriceAdult = 92, Type = "Plane", Seats = 180,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[69], Start = DateTime.UtcNow.AddDays(14).AddHours(3), 
        End = DateTime.UtcNow.AddDays(14).AddHours(9), 
        PriceAdult = 176, Type = "Train", Seats = 97,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[70], Start = DateTime.UtcNow.AddDays(61).AddHours(10), 
        End = DateTime.UtcNow.AddDays(61).AddHours(20), 
        PriceAdult = 88, Type = "Train", Seats = 54,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[71], Start = DateTime.UtcNow.AddDays(9).AddHours(8), 
        End = DateTime.UtcNow.AddDays(9).AddHours(12), 
        PriceAdult = 237, Type = "Plane", Seats = 81,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[72], Start = DateTime.UtcNow.AddDays(67).AddHours(19), 
        End = DateTime.UtcNow.AddDays(68).AddHours(1), 
        PriceAdult = 268, Type = "Train", Seats = 130,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[73], Start = DateTime.UtcNow.AddDays(74).AddHours(18), 
        End = DateTime.UtcNow.AddDays(74).AddHours(22), 
        PriceAdult = 217, Type = "Plane", Seats = 54,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[74], Start = DateTime.UtcNow.AddDays(30).AddHours(7), 
        End = DateTime.UtcNow.AddDays(30).AddHours(9), 
        PriceAdult = 223, Type = "Bus", Seats = 114,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[75], Start = DateTime.UtcNow.AddDays(84).AddHours(7), 
        End = DateTime.UtcNow.AddDays(84).AddHours(11), 
        PriceAdult = 220, Type = "Plane", Seats = 178,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[76], Start = DateTime.UtcNow.AddDays(42).AddHours(0), 
        End = DateTime.UtcNow.AddDays(42).AddHours(8), 
        PriceAdult = 258, Type = "Train", Seats = 92,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[77], Start = DateTime.UtcNow.AddDays(21).AddHours(12), 
        End = DateTime.UtcNow.AddDays(21).AddHours(14), 
        PriceAdult = 237, Type = "Train", Seats = 152,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[78], Start = DateTime.UtcNow.AddDays(69).AddHours(2), 
        End = DateTime.UtcNow.AddDays(69).AddHours(9), 
        PriceAdult = 271, Type = "Plane", Seats = 171,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[79], Start = DateTime.UtcNow.AddDays(24).AddHours(1), 
        End = DateTime.UtcNow.AddDays(24).AddHours(6), 
        PriceAdult = 130, Type = "Train", Seats = 101,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[80], Start = DateTime.UtcNow.AddDays(47).AddHours(20), 
        End = DateTime.UtcNow.AddDays(48).AddHours(1), 
        PriceAdult = 159, Type = "Bus", Seats = 138,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[81], Start = DateTime.UtcNow.AddDays(67).AddHours(14), 
        End = DateTime.UtcNow.AddDays(68).AddHours(2), 
        PriceAdult = 222, Type = "Train", Seats = 116,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[82], Start = DateTime.UtcNow.AddDays(31).AddHours(12), 
        End = DateTime.UtcNow.AddDays(31).AddHours(14), 
        PriceAdult = 108, Type = "Bus", Seats = 153,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[83], Start = DateTime.UtcNow.AddDays(70).AddHours(7), 
        End = DateTime.UtcNow.AddDays(70).AddHours(16), 
        PriceAdult = 174, Type = "Plane", Seats = 81,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[84], Start = DateTime.UtcNow.AddDays(14).AddHours(12), 
        End = DateTime.UtcNow.AddDays(14).AddHours(21), 
        PriceAdult = 245, Type = "Train", Seats = 148,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[85], Start = DateTime.UtcNow.AddDays(48).AddHours(0), 
        End = DateTime.UtcNow.AddDays(48).AddHours(12), 
        PriceAdult = 109, Type = "Train", Seats = 104,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[86], Start = DateTime.UtcNow.AddDays(60).AddHours(6), 
        End = DateTime.UtcNow.AddDays(60).AddHours(11), 
        PriceAdult = 58, Type = "Train", Seats = 75,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[87], Start = DateTime.UtcNow.AddDays(38).AddHours(11), 
        End = DateTime.UtcNow.AddDays(38).AddHours(20), 
        PriceAdult = 63, Type = "Train", Seats = 171,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[88], Start = DateTime.UtcNow.AddDays(2).AddHours(0), 
        End = DateTime.UtcNow.AddDays(2).AddHours(2), 
        PriceAdult = 297, Type = "Bus", Seats = 168,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[89], Start = DateTime.UtcNow.AddDays(21).AddHours(7), 
        End = DateTime.UtcNow.AddDays(21).AddHours(19), 
        PriceAdult = 118, Type = "Bus", Seats = 198,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[90], Start = DateTime.UtcNow.AddDays(85).AddHours(10), 
        End = DateTime.UtcNow.AddDays(85).AddHours(14), 
        PriceAdult = 182, Type = "Train", Seats = 124,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[91], Start = DateTime.UtcNow.AddDays(60).AddHours(1), 
        End = DateTime.UtcNow.AddDays(60).AddHours(10), 
        PriceAdult = 176, Type = "Plane", Seats = 182,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[92], Start = DateTime.UtcNow.AddDays(6).AddHours(12), 
        End = DateTime.UtcNow.AddDays(6).AddHours(14), 
        PriceAdult = 287, Type = "Train", Seats = 78,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[93], Start = DateTime.UtcNow.AddDays(16).AddHours(8), 
        End = DateTime.UtcNow.AddDays(16).AddHours(16), 
        PriceAdult = 110, Type = "Bus", Seats = 89,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[94], Start = DateTime.UtcNow.AddDays(37).AddHours(6), 
        End = DateTime.UtcNow.AddDays(37).AddHours(10), 
        PriceAdult = 110, Type = "Bus", Seats = 175,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[95], Start = DateTime.UtcNow.AddDays(56).AddHours(1), 
        End = DateTime.UtcNow.AddDays(56).AddHours(13), 
        PriceAdult = 141, Type = "Plane", Seats = 186,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[96], Start = DateTime.UtcNow.AddDays(89).AddHours(7), 
        End = DateTime.UtcNow.AddDays(89).AddHours(19), 
        PriceAdult = 162, Type = "Plane", Seats = 69,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[97], Start = DateTime.UtcNow.AddDays(5).AddHours(9), 
        End = DateTime.UtcNow.AddDays(5).AddHours(14), 
        PriceAdult = 124, Type = "Bus", Seats = 158,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[98], Start = DateTime.UtcNow.AddDays(18).AddHours(19), 
        End = DateTime.UtcNow.AddDays(18).AddHours(22), 
        PriceAdult = 115, Type = "Train", Seats = 87,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[99], Start = DateTime.UtcNow.AddDays(71).AddHours(9), 
        End = DateTime.UtcNow.AddDays(71).AddHours(12), 
        PriceAdult = 262, Type = "Train", Seats = 57,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[100], Start = DateTime.UtcNow.AddDays(4).AddHours(11), 
        End = DateTime.UtcNow.AddDays(4).AddHours(19), 
        PriceAdult = 293, Type = "Plane", Seats = 161,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[101], Start = DateTime.UtcNow.AddDays(60).AddHours(2), 
        End = DateTime.UtcNow.AddDays(60).AddHours(13), 
        PriceAdult = 206, Type = "Plane", Seats = 63,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[102], Start = DateTime.UtcNow.AddDays(64).AddHours(16), 
        End = DateTime.UtcNow.AddDays(65).AddHours(1), 
        PriceAdult = 141, Type = "Plane", Seats = 100,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[103], Start = DateTime.UtcNow.AddDays(50).AddHours(2), 
        End = DateTime.UtcNow.AddDays(50).AddHours(8), 
        PriceAdult = 191, Type = "Bus", Seats = 95,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[104], Start = DateTime.UtcNow.AddDays(15).AddHours(10), 
        End = DateTime.UtcNow.AddDays(15).AddHours(16), 
        PriceAdult = 185, Type = "Bus", Seats = 154,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[105], Start = DateTime.UtcNow.AddDays(50).AddHours(15), 
        End = DateTime.UtcNow.AddDays(50).AddHours(17), 
        PriceAdult = 74, Type = "Train", Seats = 86,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[106], Start = DateTime.UtcNow.AddDays(42).AddHours(11), 
        End = DateTime.UtcNow.AddDays(42).AddHours(23), 
        PriceAdult = 167, Type = "Bus", Seats = 177,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[107], Start = DateTime.UtcNow.AddDays(79).AddHours(4), 
        End = DateTime.UtcNow.AddDays(79).AddHours(16), 
        PriceAdult = 194, Type = "Plane", Seats = 142,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[108], Start = DateTime.UtcNow.AddDays(10).AddHours(16), 
        End = DateTime.UtcNow.AddDays(10).AddHours(22), 
        PriceAdult = 87, Type = "Plane", Seats = 176,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[109], Start = DateTime.UtcNow.AddDays(13).AddHours(9), 
        End = DateTime.UtcNow.AddDays(13).AddHours(11), 
        PriceAdult = 271, Type = "Train", Seats = 148,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[110], Start = DateTime.UtcNow.AddDays(42).AddHours(5), 
        End = DateTime.UtcNow.AddDays(42).AddHours(9), 
        PriceAdult = 254, Type = "Bus", Seats = 156,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[111], Start = DateTime.UtcNow.AddDays(4).AddHours(3), 
        End = DateTime.UtcNow.AddDays(4).AddHours(12), 
        PriceAdult = 286, Type = "Train", Seats = 186,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[112], Start = DateTime.UtcNow.AddDays(50).AddHours(23), 
        End = DateTime.UtcNow.AddDays(51).AddHours(1), 
        PriceAdult = 138, Type = "Train", Seats = 135,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[113], Start = DateTime.UtcNow.AddDays(49).AddHours(22), 
        End = DateTime.UtcNow.AddDays(50).AddHours(4), 
        PriceAdult = 259, Type = "Plane", Seats = 71,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[114], Start = DateTime.UtcNow.AddDays(24).AddHours(14), 
        End = DateTime.UtcNow.AddDays(25).AddHours(1), 
        PriceAdult = 84, Type = "Bus", Seats = 59,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[115], Start = DateTime.UtcNow.AddDays(75).AddHours(17), 
        End = DateTime.UtcNow.AddDays(75).AddHours(21), 
        PriceAdult = 276, Type = "Bus", Seats = 57,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[116], Start = DateTime.UtcNow.AddDays(39).AddHours(9), 
        End = DateTime.UtcNow.AddDays(39).AddHours(15), 
        PriceAdult = 133, Type = "Plane", Seats = 78,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[117], Start = DateTime.UtcNow.AddDays(6).AddHours(9), 
        End = DateTime.UtcNow.AddDays(6).AddHours(14), 
        PriceAdult = 172, Type = "Plane", Seats = 158,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[118], Start = DateTime.UtcNow.AddDays(22).AddHours(3), 
        End = DateTime.UtcNow.AddDays(22).AddHours(13), 
        PriceAdult = 166, Type = "Train", Seats = 84,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[119], Start = DateTime.UtcNow.AddDays(20).AddHours(8), 
        End = DateTime.UtcNow.AddDays(20).AddHours(15), 
        PriceAdult = 125, Type = "Train", Seats = 61,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[120], Start = DateTime.UtcNow.AddDays(88).AddHours(17), 
        End = DateTime.UtcNow.AddDays(88).AddHours(22), 
        PriceAdult = 168, Type = "Train", Seats = 155,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[121], Start = DateTime.UtcNow.AddDays(24).AddHours(13), 
        End = DateTime.UtcNow.AddDays(24).AddHours(18), 
        PriceAdult = 276, Type = "Bus", Seats = 52,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[122], Start = DateTime.UtcNow.AddDays(86).AddHours(12), 
        End = DateTime.UtcNow.AddDays(86).AddHours(16), 
        PriceAdult = 230, Type = "Train", Seats = 178,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[123], Start = DateTime.UtcNow.AddDays(20).AddHours(15), 
        End = DateTime.UtcNow.AddDays(20).AddHours(18), 
        PriceAdult = 125, Type = "Plane", Seats = 113,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[124], Start = DateTime.UtcNow.AddDays(17).AddHours(6), 
        End = DateTime.UtcNow.AddDays(17).AddHours(10), 
        PriceAdult = 57, Type = "Bus", Seats = 178,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[125], Start = DateTime.UtcNow.AddDays(77).AddHours(1), 
        End = DateTime.UtcNow.AddDays(77).AddHours(7), 
        PriceAdult = 179, Type = "Train", Seats = 51,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[126], Start = DateTime.UtcNow.AddDays(2).AddHours(2), 
        End = DateTime.UtcNow.AddDays(2).AddHours(9), 
        PriceAdult = 252, Type = "Train", Seats = 172,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[127], Start = DateTime.UtcNow.AddDays(8).AddHours(20), 
        End = DateTime.UtcNow.AddDays(8).AddHours(24), 
        PriceAdult = 274, Type = "Train", Seats = 176,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[128], Start = DateTime.UtcNow.AddDays(87).AddHours(6), 
        End = DateTime.UtcNow.AddDays(87).AddHours(13), 
        PriceAdult = 161, Type = "Bus", Seats = 186,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[129], Start = DateTime.UtcNow.AddDays(67).AddHours(20), 
        End = DateTime.UtcNow.AddDays(68).AddHours(3), 
        PriceAdult = 252, Type = "Plane", Seats = 193,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[130], Start = DateTime.UtcNow.AddDays(27).AddHours(18), 
        End = DateTime.UtcNow.AddDays(28).AddHours(1), 
        PriceAdult = 79, Type = "Train", Seats = 80,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[131], Start = DateTime.UtcNow.AddDays(70).AddHours(0), 
        End = DateTime.UtcNow.AddDays(70).AddHours(12), 
        PriceAdult = 246, Type = "Bus", Seats = 167,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[132], Start = DateTime.UtcNow.AddDays(39).AddHours(13), 
        End = DateTime.UtcNow.AddDays(39).AddHours(21), 
        PriceAdult = 87, Type = "Train", Seats = 119,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[133], Start = DateTime.UtcNow.AddDays(9).AddHours(7), 
        End = DateTime.UtcNow.AddDays(9).AddHours(19), 
        PriceAdult = 199, Type = "Plane", Seats = 172,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[134], Start = DateTime.UtcNow.AddDays(27).AddHours(14), 
        End = DateTime.UtcNow.AddDays(27).AddHours(21), 
        PriceAdult = 54, Type = "Bus", Seats = 66,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[135], Start = DateTime.UtcNow.AddDays(71).AddHours(16), 
        End = DateTime.UtcNow.AddDays(72).AddHours(4), 
        PriceAdult = 161, Type = "Bus", Seats = 57,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[136], Start = DateTime.UtcNow.AddDays(38).AddHours(23), 
        End = DateTime.UtcNow.AddDays(39).AddHours(3), 
        PriceAdult = 97, Type = "Train", Seats = 150,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[137], Start = DateTime.UtcNow.AddDays(1).AddHours(22), 
        End = DateTime.UtcNow.AddDays(2).AddHours(7), 
        PriceAdult = 265, Type = "Train", Seats = 151,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[138], Start = DateTime.UtcNow.AddDays(13).AddHours(15), 
        End = DateTime.UtcNow.AddDays(13).AddHours(21), 
        PriceAdult = 276, Type = "Bus", Seats = 193,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[139], Start = DateTime.UtcNow.AddDays(69).AddHours(10), 
        End = DateTime.UtcNow.AddDays(69).AddHours(15), 
        PriceAdult = 161, Type = "Bus", Seats = 171,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[140], Start = DateTime.UtcNow.AddDays(59).AddHours(19), 
        End = DateTime.UtcNow.AddDays(60).AddHours(3), 
        PriceAdult = 203, Type = "Bus", Seats = 160,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[141], Start = DateTime.UtcNow.AddDays(22).AddHours(20), 
        End = DateTime.UtcNow.AddDays(23).AddHours(6), 
        PriceAdult = 162, Type = "Train", Seats = 126,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[142], Start = DateTime.UtcNow.AddDays(14).AddHours(23), 
        End = DateTime.UtcNow.AddDays(15).AddHours(5), 
        PriceAdult = 76, Type = "Bus", Seats = 199,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[143], Start = DateTime.UtcNow.AddDays(15).AddHours(14), 
        End = DateTime.UtcNow.AddDays(15).AddHours(19), 
        PriceAdult = 191, Type = "Bus", Seats = 79,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[144], Start = DateTime.UtcNow.AddDays(46).AddHours(23), 
        End = DateTime.UtcNow.AddDays(47).AddHours(8), 
        PriceAdult = 120, Type = "Plane", Seats = 155,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[145], Start = DateTime.UtcNow.AddDays(67).AddHours(0), 
        End = DateTime.UtcNow.AddDays(67).AddHours(12), 
        PriceAdult = 218, Type = "Bus", Seats = 77,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[146], Start = DateTime.UtcNow.AddDays(49).AddHours(21), 
        End = DateTime.UtcNow.AddDays(50).AddHours(3), 
        PriceAdult = 195, Type = "Bus", Seats = 193,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[147], Start = DateTime.UtcNow.AddDays(62).AddHours(13), 
        End = DateTime.UtcNow.AddDays(62).AddHours(22), 
        PriceAdult = 193, Type = "Train", Seats = 143,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[148], Start = DateTime.UtcNow.AddDays(17).AddHours(3), 
        End = DateTime.UtcNow.AddDays(17).AddHours(9), 
        PriceAdult = 152, Type = "Train", Seats = 63,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[149], Start = DateTime.UtcNow.AddDays(18).AddHours(4), 
        End = DateTime.UtcNow.AddDays(18).AddHours(15), 
        PriceAdult = 148, Type = "Bus", Seats = 142,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[150], Start = DateTime.UtcNow.AddDays(52).AddHours(4), 
        End = DateTime.UtcNow.AddDays(52).AddHours(10), 
        PriceAdult = 239, Type = "Plane", Seats = 98,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[151], Start = DateTime.UtcNow.AddDays(71).AddHours(10), 
        End = DateTime.UtcNow.AddDays(71).AddHours(13), 
        PriceAdult = 274, Type = "Plane", Seats = 107,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[152], Start = DateTime.UtcNow.AddDays(4).AddHours(3), 
        End = DateTime.UtcNow.AddDays(4).AddHours(14), 
        PriceAdult = 67, Type = "Plane", Seats = 112,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[153], Start = DateTime.UtcNow.AddDays(66).AddHours(16), 
        End = DateTime.UtcNow.AddDays(67).AddHours(4), 
        PriceAdult = 127, Type = "Train", Seats = 73,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[154], Start = DateTime.UtcNow.AddDays(35).AddHours(2), 
        End = DateTime.UtcNow.AddDays(35).AddHours(9), 
        PriceAdult = 193, Type = "Train", Seats = 184,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[155], Start = DateTime.UtcNow.AddDays(49).AddHours(19), 
        End = DateTime.UtcNow.AddDays(50).AddHours(5), 
        PriceAdult = 250, Type = "Plane", Seats = 127,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[156], Start = DateTime.UtcNow.AddDays(89).AddHours(12), 
        End = DateTime.UtcNow.AddDays(89).AddHours(15), 
        PriceAdult = 79, Type = "Plane", Seats = 140,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[157], Start = DateTime.UtcNow.AddDays(14).AddHours(21), 
        End = DateTime.UtcNow.AddDays(15).AddHours(7), 
        PriceAdult = 200, Type = "Bus", Seats = 163,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[158], Start = DateTime.UtcNow.AddDays(35).AddHours(4), 
        End = DateTime.UtcNow.AddDays(35).AddHours(8), 
        PriceAdult = 247, Type = "Train", Seats = 93,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[159], Start = DateTime.UtcNow.AddDays(9).AddHours(7), 
        End = DateTime.UtcNow.AddDays(9).AddHours(19), 
        PriceAdult = 151, Type = "Plane", Seats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[160], Start = DateTime.UtcNow.AddDays(20).AddHours(16), 
        End = DateTime.UtcNow.AddDays(20).AddHours(22), 
        PriceAdult = 143, Type = "Plane", Seats = 175,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[161], Start = DateTime.UtcNow.AddDays(51).AddHours(16), 
        End = DateTime.UtcNow.AddDays(51).AddHours(18), 
        PriceAdult = 285, Type = "Train", Seats = 148,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[162], Start = DateTime.UtcNow.AddDays(57).AddHours(18), 
        End = DateTime.UtcNow.AddDays(57).AddHours(23), 
        PriceAdult = 253, Type = "Train", Seats = 182,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[163], Start = DateTime.UtcNow.AddDays(41).AddHours(15), 
        End = DateTime.UtcNow.AddDays(42).AddHours(3), 
        PriceAdult = 254, Type = "Plane", Seats = 166,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[164], Start = DateTime.UtcNow.AddDays(24).AddHours(18), 
        End = DateTime.UtcNow.AddDays(25).AddHours(5), 
        PriceAdult = 213, Type = "Plane", Seats = 66,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[165], Start = DateTime.UtcNow.AddDays(9).AddHours(13), 
        End = DateTime.UtcNow.AddDays(9).AddHours(21), 
        PriceAdult = 58, Type = "Plane", Seats = 94,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[166], Start = DateTime.UtcNow.AddDays(47).AddHours(15), 
        End = DateTime.UtcNow.AddDays(47).AddHours(18), 
        PriceAdult = 248, Type = "Bus", Seats = 72,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[167], Start = DateTime.UtcNow.AddDays(37).AddHours(23), 
        End = DateTime.UtcNow.AddDays(38).AddHours(6), 
        PriceAdult = 258, Type = "Bus", Seats = 158,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[168], Start = DateTime.UtcNow.AddDays(19).AddHours(11), 
        End = DateTime.UtcNow.AddDays(19).AddHours(14), 
        PriceAdult = 276, Type = "Plane", Seats = 151,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[169], Start = DateTime.UtcNow.AddDays(10).AddHours(9), 
        End = DateTime.UtcNow.AddDays(10).AddHours(12), 
        PriceAdult = 238, Type = "Bus", Seats = 108,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[170], Start = DateTime.UtcNow.AddDays(41).AddHours(9), 
        End = DateTime.UtcNow.AddDays(41).AddHours(17), 
        PriceAdult = 102, Type = "Bus", Seats = 157,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[171], Start = DateTime.UtcNow.AddDays(7).AddHours(4), 
        End = DateTime.UtcNow.AddDays(7).AddHours(16), 
        PriceAdult = 238, Type = "Train", Seats = 142,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[172], Start = DateTime.UtcNow.AddDays(28).AddHours(20), 
        End = DateTime.UtcNow.AddDays(29).AddHours(7), 
        PriceAdult = 158, Type = "Train", Seats = 155,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[173], Start = DateTime.UtcNow.AddDays(6).AddHours(20), 
        End = DateTime.UtcNow.AddDays(7).AddHours(4), 
        PriceAdult = 247, Type = "Bus", Seats = 69,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[174], Start = DateTime.UtcNow.AddDays(37).AddHours(15), 
        End = DateTime.UtcNow.AddDays(37).AddHours(17), 
        PriceAdult = 248, Type = "Train", Seats = 94,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[175], Start = DateTime.UtcNow.AddDays(44).AddHours(15), 
        End = DateTime.UtcNow.AddDays(44).AddHours(21), 
        PriceAdult = 140, Type = "Plane", Seats = 61,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[176], Start = DateTime.UtcNow.AddDays(9).AddHours(16), 
        End = DateTime.UtcNow.AddDays(9).AddHours(20), 
        PriceAdult = 224, Type = "Train", Seats = 194,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[177], Start = DateTime.UtcNow.AddDays(28).AddHours(3), 
        End = DateTime.UtcNow.AddDays(28).AddHours(13), 
        PriceAdult = 257, Type = "Plane", Seats = 102,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[178], Start = DateTime.UtcNow.AddDays(70).AddHours(10), 
        End = DateTime.UtcNow.AddDays(70).AddHours(22), 
        PriceAdult = 104, Type = "Train", Seats = 73,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[179], Start = DateTime.UtcNow.AddDays(49).AddHours(13), 
        End = DateTime.UtcNow.AddDays(49).AddHours(24), 
        PriceAdult = 254, Type = "Train", Seats = 192,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[180], Start = DateTime.UtcNow.AddDays(36).AddHours(5), 
        End = DateTime.UtcNow.AddDays(36).AddHours(17), 
        PriceAdult = 137, Type = "Plane", Seats = 51,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[181], Start = DateTime.UtcNow.AddDays(11).AddHours(7), 
        End = DateTime.UtcNow.AddDays(11).AddHours(13), 
        PriceAdult = 128, Type = "Bus", Seats = 80,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[182], Start = DateTime.UtcNow.AddDays(30).AddHours(18), 
        End = DateTime.UtcNow.AddDays(31).AddHours(4), 
        PriceAdult = 292, Type = "Bus", Seats = 95,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[183], Start = DateTime.UtcNow.AddDays(48).AddHours(13), 
        End = DateTime.UtcNow.AddDays(49).AddHours(1), 
        PriceAdult = 60, Type = "Bus", Seats = 147,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[184], Start = DateTime.UtcNow.AddDays(86).AddHours(6), 
        End = DateTime.UtcNow.AddDays(86).AddHours(12), 
        PriceAdult = 216, Type = "Bus", Seats = 91,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[185], Start = DateTime.UtcNow.AddDays(84).AddHours(18), 
        End = DateTime.UtcNow.AddDays(84).AddHours(24), 
        PriceAdult = 126, Type = "Bus", Seats = 125,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[186], Start = DateTime.UtcNow.AddDays(24).AddHours(16), 
        End = DateTime.UtcNow.AddDays(24).AddHours(19), 
        PriceAdult = 102, Type = "Train", Seats = 55,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[187], Start = DateTime.UtcNow.AddDays(48).AddHours(19), 
        End = DateTime.UtcNow.AddDays(49).AddHours(2), 
        PriceAdult = 134, Type = "Train", Seats = 120,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[188], Start = DateTime.UtcNow.AddDays(19).AddHours(6), 
        End = DateTime.UtcNow.AddDays(19).AddHours(8), 
        PriceAdult = 107, Type = "Plane", Seats = 55,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[189], Start = DateTime.UtcNow.AddDays(7).AddHours(2), 
        End = DateTime.UtcNow.AddDays(7).AddHours(13), 
        PriceAdult = 246, Type = "Plane", Seats = 81,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[190], Start = DateTime.UtcNow.AddDays(7).AddHours(20), 
        End = DateTime.UtcNow.AddDays(8).AddHours(6), 
        PriceAdult = 207, Type = "Plane", Seats = 77,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[191], Start = DateTime.UtcNow.AddDays(46).AddHours(1), 
        End = DateTime.UtcNow.AddDays(46).AddHours(6), 
        PriceAdult = 162, Type = "Bus", Seats = 162,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[192], Start = DateTime.UtcNow.AddDays(39).AddHours(10), 
        End = DateTime.UtcNow.AddDays(39).AddHours(12), 
        PriceAdult = 286, Type = "Plane", Seats = 144,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[193], Start = DateTime.UtcNow.AddDays(33).AddHours(4), 
        End = DateTime.UtcNow.AddDays(33).AddHours(6), 
        PriceAdult = 259, Type = "Bus", Seats = 143,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[194], Start = DateTime.UtcNow.AddDays(72).AddHours(1), 
        End = DateTime.UtcNow.AddDays(72).AddHours(5), 
        PriceAdult = 262, Type = "Plane", Seats = 140,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[195], Start = DateTime.UtcNow.AddDays(13).AddHours(3), 
        End = DateTime.UtcNow.AddDays(13).AddHours(8), 
        PriceAdult = 163, Type = "Train", Seats = 58,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[196], Start = DateTime.UtcNow.AddDays(79).AddHours(7), 
        End = DateTime.UtcNow.AddDays(79).AddHours(19), 
        PriceAdult = 222, Type = "Plane", Seats = 114,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[197], Start = DateTime.UtcNow.AddDays(84).AddHours(9), 
        End = DateTime.UtcNow.AddDays(84).AddHours(13), 
        PriceAdult = 191, Type = "Plane", Seats = 74,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[198], Start = DateTime.UtcNow.AddDays(89).AddHours(12), 
        End = DateTime.UtcNow.AddDays(89).AddHours(15), 
        PriceAdult = 288, Type = "Plane", Seats = 63,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new QuerryTransportOption
    {
        Id = TransportIds[199], Start = DateTime.UtcNow.AddDays(4).AddHours(2), 
        End = DateTime.UtcNow.AddDays(4).AddHours(14), 
        PriceAdult = 66, Type = "Train", Seats = 115,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
                                };
                modelBuilder.Entity<QueryTransportOption>().HasData(queryTransportOptions);
            }
        }
    }
                        