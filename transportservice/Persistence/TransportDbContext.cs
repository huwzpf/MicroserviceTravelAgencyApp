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
            
            
    var transportOptions = new[]
        {
                
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(13), 
        End = DateTime.UtcNow.AddDays(37).AddHours(15), 
        PriceAdult = 262, Type = "Bus", InitialSeats = 60,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(17), 
        End = DateTime.UtcNow.AddDays(47).AddHours(19), 
        PriceAdult = 285, Type = "Plane", InitialSeats = 123,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(17), 
        End = DateTime.UtcNow.AddDays(7).AddHours(4), 
        PriceAdult = 149, Type = "Plane", InitialSeats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(78).AddHours(9), 
        End = DateTime.UtcNow.AddDays(78).AddHours(14), 
        PriceAdult = 122, Type = "Bus", InitialSeats = 106,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(1), 
        End = DateTime.UtcNow.AddDays(61).AddHours(10), 
        PriceAdult = 221, Type = "Bus", InitialSeats = 167,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(15), 
        End = DateTime.UtcNow.AddDays(42).AddHours(24), 
        PriceAdult = 62, Type = "Bus", InitialSeats = 156,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(88).AddHours(6), 
        End = DateTime.UtcNow.AddDays(88).AddHours(14), 
        PriceAdult = 64, Type = "Plane", InitialSeats = 189,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(3).AddHours(22), 
        End = DateTime.UtcNow.AddDays(4).AddHours(3), 
        PriceAdult = 90, Type = "Train", InitialSeats = 90,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(5), 
        End = DateTime.UtcNow.AddDays(90).AddHours(14), 
        PriceAdult = 65, Type = "Bus", InitialSeats = 135,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(72).AddHours(14), 
        End = DateTime.UtcNow.AddDays(72).AddHours(20), 
        PriceAdult = 225, Type = "Plane", InitialSeats = 59,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(9), 
        End = DateTime.UtcNow.AddDays(56).AddHours(15), 
        PriceAdult = 284, Type = "Plane", InitialSeats = 196,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(12), 
        End = DateTime.UtcNow.AddDays(90).AddHours(21), 
        PriceAdult = 118, Type = "Train", InitialSeats = 155,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(5), 
        End = DateTime.UtcNow.AddDays(26).AddHours(9), 
        PriceAdult = 108, Type = "Bus", InitialSeats = 150,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(72).AddHours(18), 
        End = DateTime.UtcNow.AddDays(73).AddHours(1), 
        PriceAdult = 149, Type = "Plane", InitialSeats = 125,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(21), 
        End = DateTime.UtcNow.AddDays(77).AddHours(1), 
        PriceAdult = 257, Type = "Train", InitialSeats = 131,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(10), 
        End = DateTime.UtcNow.AddDays(9).AddHours(20), 
        PriceAdult = 156, Type = "Bus", InitialSeats = 182,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(10), 
        End = DateTime.UtcNow.AddDays(45).AddHours(21), 
        PriceAdult = 75, Type = "Plane", InitialSeats = 86,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(16), 
        End = DateTime.UtcNow.AddDays(90).AddHours(18), 
        PriceAdult = 107, Type = "Plane", InitialSeats = 187,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(6), 
        End = DateTime.UtcNow.AddDays(27).AddHours(12), 
        PriceAdult = 271, Type = "Plane", InitialSeats = 158,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(8), 
        End = DateTime.UtcNow.AddDays(14).AddHours(15), 
        PriceAdult = 167, Type = "Plane", InitialSeats = 163,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(20), 
        End = DateTime.UtcNow.AddDays(48).AddHours(24), 
        PriceAdult = 91, Type = "Train", InitialSeats = 51,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(18), 
        End = DateTime.UtcNow.AddDays(81).AddHours(6), 
        PriceAdult = 127, Type = "Bus", InitialSeats = 172,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(21), 
        End = DateTime.UtcNow.AddDays(79).AddHours(23), 
        PriceAdult = 173, Type = "Plane", InitialSeats = 94,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(15), 
        End = DateTime.UtcNow.AddDays(15).AddHours(20), 
        PriceAdult = 160, Type = "Train", InitialSeats = 67,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(1), 
        End = DateTime.UtcNow.AddDays(31).AddHours(10), 
        PriceAdult = 79, Type = "Train", InitialSeats = 128,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(4), 
        End = DateTime.UtcNow.AddDays(42).AddHours(13), 
        PriceAdult = 180, Type = "Bus", InitialSeats = 178,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(16).AddHours(19), 
        End = DateTime.UtcNow.AddDays(17).AddHours(3), 
        PriceAdult = 227, Type = "Train", InitialSeats = 108,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(18), 
        End = DateTime.UtcNow.AddDays(18).AddHours(22), 
        PriceAdult = 79, Type = "Bus", InitialSeats = 181,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(5), 
        End = DateTime.UtcNow.AddDays(87).AddHours(8), 
        PriceAdult = 228, Type = "Plane", InitialSeats = 187,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(17), 
        End = DateTime.UtcNow.AddDays(28).AddHours(4), 
        PriceAdult = 193, Type = "Train", InitialSeats = 79,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(4), 
        End = DateTime.UtcNow.AddDays(6).AddHours(12), 
        PriceAdult = 84, Type = "Bus", InitialSeats = 86,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(75).AddHours(7), 
        End = DateTime.UtcNow.AddDays(75).AddHours(16), 
        PriceAdult = 227, Type = "Train", InitialSeats = 74,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(12), 
        End = DateTime.UtcNow.AddDays(54).AddHours(20), 
        PriceAdult = 60, Type = "Plane", InitialSeats = 107,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(4), 
        End = DateTime.UtcNow.AddDays(85).AddHours(6), 
        PriceAdult = 131, Type = "Plane", InitialSeats = 85,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(19), 
        End = DateTime.UtcNow.AddDays(65).AddHours(24), 
        PriceAdult = 152, Type = "Train", InitialSeats = 134,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(46).AddHours(4), 
        End = DateTime.UtcNow.AddDays(46).AddHours(10), 
        PriceAdult = 166, Type = "Plane", InitialSeats = 84,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(86).AddHours(15), 
        End = DateTime.UtcNow.AddDays(86).AddHours(23), 
        PriceAdult = 118, Type = "Plane", InitialSeats = 154,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(19), 
        End = DateTime.UtcNow.AddDays(84).AddHours(7), 
        PriceAdult = 135, Type = "Train", InitialSeats = 146,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(21), 
        End = DateTime.UtcNow.AddDays(78).AddHours(1), 
        PriceAdult = 199, Type = "Bus", InitialSeats = 51,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(25).AddHours(5), 
        End = DateTime.UtcNow.AddDays(25).AddHours(17), 
        PriceAdult = 239, Type = "Bus", InitialSeats = 129,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(2), 
        End = DateTime.UtcNow.AddDays(66).AddHours(8), 
        PriceAdult = 281, Type = "Train", InitialSeats = 50,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(7).AddHours(22), 
        End = DateTime.UtcNow.AddDays(8).AddHours(4), 
        PriceAdult = 197, Type = "Train", InitialSeats = 170,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(7), 
        End = DateTime.UtcNow.AddDays(6).AddHours(13), 
        PriceAdult = 127, Type = "Bus", InitialSeats = 101,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(62).AddHours(2), 
        End = DateTime.UtcNow.AddDays(62).AddHours(5), 
        PriceAdult = 193, Type = "Bus", InitialSeats = 115,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(9), 
        End = DateTime.UtcNow.AddDays(29).AddHours(17), 
        PriceAdult = 132, Type = "Bus", InitialSeats = 191,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(52).AddHours(23), 
        End = DateTime.UtcNow.AddDays(53).AddHours(1), 
        PriceAdult = 130, Type = "Bus", InitialSeats = 91,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(14), 
        End = DateTime.UtcNow.AddDays(9).AddHours(2), 
        PriceAdult = 101, Type = "Bus", InitialSeats = 68,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(22), 
        End = DateTime.UtcNow.AddDays(37).AddHours(6), 
        PriceAdult = 104, Type = "Train", InitialSeats = 50,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(9), 
        End = DateTime.UtcNow.AddDays(13).AddHours(14), 
        PriceAdult = 190, Type = "Bus", InitialSeats = 52,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(23).AddHours(23), 
        End = DateTime.UtcNow.AddDays(24).AddHours(6), 
        PriceAdult = 95, Type = "Bus", InitialSeats = 54,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(11), 
        End = DateTime.UtcNow.AddDays(27).AddHours(14), 
        PriceAdult = 97, Type = "Plane", InitialSeats = 160,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(21), 
        End = DateTime.UtcNow.AddDays(4).AddHours(23), 
        PriceAdult = 51, Type = "Train", InitialSeats = 98,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(14), 
        End = DateTime.UtcNow.AddDays(82).AddHours(24), 
        PriceAdult = 213, Type = "Plane", InitialSeats = 102,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(70).AddHours(15), 
        End = DateTime.UtcNow.AddDays(71).AddHours(2), 
        PriceAdult = 59, Type = "Plane", InitialSeats = 184,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(12), 
        End = DateTime.UtcNow.AddDays(2).AddHours(16), 
        PriceAdult = 126, Type = "Bus", InitialSeats = 60,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(10), 
        End = DateTime.UtcNow.AddDays(47).AddHours(15), 
        PriceAdult = 252, Type = "Train", InitialSeats = 184,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(18), 
        End = DateTime.UtcNow.AddDays(87).AddHours(22), 
        PriceAdult = 296, Type = "Train", InitialSeats = 143,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(7), 
        End = DateTime.UtcNow.AddDays(40).AddHours(9), 
        PriceAdult = 160, Type = "Train", InitialSeats = 126,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(6), 
        End = DateTime.UtcNow.AddDays(56).AddHours(16), 
        PriceAdult = 136, Type = "Bus", InitialSeats = 97,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(13), 
        End = DateTime.UtcNow.AddDays(5).AddHours(19), 
        PriceAdult = 148, Type = "Bus", InitialSeats = 151,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(3), 
        End = DateTime.UtcNow.AddDays(82).AddHours(8), 
        PriceAdult = 179, Type = "Bus", InitialSeats = 109,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(0), 
        End = DateTime.UtcNow.AddDays(29).AddHours(3), 
        PriceAdult = 244, Type = "Train", InitialSeats = 191,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(16), 
        End = DateTime.UtcNow.AddDays(9).AddHours(3), 
        PriceAdult = 114, Type = "Train", InitialSeats = 125,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(69).AddHours(20), 
        End = DateTime.UtcNow.AddDays(70).AddHours(3), 
        PriceAdult = 264, Type = "Train", InitialSeats = 107,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(2), 
        End = DateTime.UtcNow.AddDays(18).AddHours(4), 
        PriceAdult = 218, Type = "Plane", InitialSeats = 185,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(20), 
        End = DateTime.UtcNow.AddDays(5).AddHours(1), 
        PriceAdult = 252, Type = "Train", InitialSeats = 90,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(17), 
        End = DateTime.UtcNow.AddDays(50).AddHours(2), 
        PriceAdult = 189, Type = "Plane", InitialSeats = 193,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(15), 
        End = DateTime.UtcNow.AddDays(4).AddHours(22), 
        PriceAdult = 127, Type = "Plane", InitialSeats = 148,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(10).AddHours(4), 
        End = DateTime.UtcNow.AddDays(10).AddHours(14), 
        PriceAdult = 161, Type = "Plane", InitialSeats = 139,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(9), 
        End = DateTime.UtcNow.AddDays(42).AddHours(20), 
        PriceAdult = 166, Type = "Plane", InitialSeats = 173,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(14), 
        End = DateTime.UtcNow.AddDays(16).AddHours(2), 
        PriceAdult = 51, Type = "Plane", InitialSeats = 152,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(12), 
        End = DateTime.UtcNow.AddDays(53).AddHours(14), 
        PriceAdult = 184, Type = "Train", InitialSeats = 157,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(2), 
        End = DateTime.UtcNow.AddDays(79).AddHours(12), 
        PriceAdult = 225, Type = "Plane", InitialSeats = 142,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(21), 
        End = DateTime.UtcNow.AddDays(65).AddHours(24), 
        PriceAdult = 135, Type = "Plane", InitialSeats = 91,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(17), 
        End = DateTime.UtcNow.AddDays(16).AddHours(2), 
        PriceAdult = 247, Type = "Train", InitialSeats = 164,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(72).AddHours(15), 
        End = DateTime.UtcNow.AddDays(72).AddHours(21), 
        PriceAdult = 298, Type = "Plane", InitialSeats = 73,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(41).AddHours(5), 
        End = DateTime.UtcNow.AddDays(41).AddHours(17), 
        PriceAdult = 134, Type = "Bus", InitialSeats = 95,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(72).AddHours(13), 
        End = DateTime.UtcNow.AddDays(72).AddHours(22), 
        PriceAdult = 209, Type = "Train", InitialSeats = 169,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(8), 
        End = DateTime.UtcNow.AddDays(53).AddHours(13), 
        PriceAdult = 208, Type = "Train", InitialSeats = 195,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(2), 
        End = DateTime.UtcNow.AddDays(31).AddHours(13), 
        PriceAdult = 104, Type = "Train", InitialSeats = 164,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(13), 
        End = DateTime.UtcNow.AddDays(31).AddHours(20), 
        PriceAdult = 172, Type = "Bus", InitialSeats = 158,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(7), 
        End = DateTime.UtcNow.AddDays(43).AddHours(12), 
        PriceAdult = 64, Type = "Plane", InitialSeats = 156,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(6), 
        End = DateTime.UtcNow.AddDays(22).AddHours(18), 
        PriceAdult = 199, Type = "Plane", InitialSeats = 89,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(16), 
        End = DateTime.UtcNow.AddDays(85).AddHours(22), 
        PriceAdult = 236, Type = "Plane", InitialSeats = 175,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(11), 
        End = DateTime.UtcNow.AddDays(13).AddHours(13), 
        PriceAdult = 71, Type = "Train", InitialSeats = 140,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(11), 
        End = DateTime.UtcNow.AddDays(20).AddHours(20), 
        PriceAdult = 276, Type = "Train", InitialSeats = 124,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(10).AddHours(19), 
        End = DateTime.UtcNow.AddDays(11).AddHours(3), 
        PriceAdult = 273, Type = "Train", InitialSeats = 117,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(14), 
        End = DateTime.UtcNow.AddDays(15).AddHours(23), 
        PriceAdult = 207, Type = "Bus", InitialSeats = 83,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(14), 
        End = DateTime.UtcNow.AddDays(59).AddHours(19), 
        PriceAdult = 214, Type = "Bus", InitialSeats = 50,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(7).AddHours(5), 
        End = DateTime.UtcNow.AddDays(7).AddHours(14), 
        PriceAdult = 176, Type = "Train", InitialSeats = 95,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(67).AddHours(1), 
        End = DateTime.UtcNow.AddDays(67).AddHours(5), 
        PriceAdult = 134, Type = "Plane", InitialSeats = 83,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(21), 
        End = DateTime.UtcNow.AddDays(48).AddHours(23), 
        PriceAdult = 108, Type = "Train", InitialSeats = 185,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(86).AddHours(6), 
        End = DateTime.UtcNow.AddDays(86).AddHours(9), 
        PriceAdult = 140, Type = "Bus", InitialSeats = 200,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(2), 
        End = DateTime.UtcNow.AddDays(43).AddHours(13), 
        PriceAdult = 249, Type = "Bus", InitialSeats = 57,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(8), 
        End = DateTime.UtcNow.AddDays(8).AddHours(15), 
        PriceAdult = 72, Type = "Train", InitialSeats = 200,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(69).AddHours(20), 
        End = DateTime.UtcNow.AddDays(70).AddHours(1), 
        PriceAdult = 125, Type = "Plane", InitialSeats = 171,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(11), 
        End = DateTime.UtcNow.AddDays(64).AddHours(15), 
        PriceAdult = 110, Type = "Plane", InitialSeats = 125,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(22), 
        End = DateTime.UtcNow.AddDays(55).AddHours(3), 
        PriceAdult = 126, Type = "Bus", InitialSeats = 96,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(4), 
        End = DateTime.UtcNow.AddDays(66).AddHours(15), 
        PriceAdult = 231, Type = "Plane", InitialSeats = 115,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(69).AddHours(15), 
        End = DateTime.UtcNow.AddDays(69).AddHours(17), 
        PriceAdult = 89, Type = "Plane", InitialSeats = 133,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(13), 
        End = DateTime.UtcNow.AddDays(82).AddHours(15), 
        PriceAdult = 251, Type = "Plane", InitialSeats = 122,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(9), 
        End = DateTime.UtcNow.AddDays(79).AddHours(20), 
        PriceAdult = 283, Type = "Bus", InitialSeats = 79,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(10), 
        End = DateTime.UtcNow.AddDays(37).AddHours(20), 
        PriceAdult = 207, Type = "Train", InitialSeats = 112,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(10), 
        End = DateTime.UtcNow.AddDays(26).AddHours(19), 
        PriceAdult = 245, Type = "Plane", InitialSeats = 178,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(78).AddHours(2), 
        End = DateTime.UtcNow.AddDays(78).AddHours(7), 
        PriceAdult = 183, Type = "Bus", InitialSeats = 170,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(9), 
        End = DateTime.UtcNow.AddDays(56).AddHours(11), 
        PriceAdult = 78, Type = "Train", InitialSeats = 197,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(6), 
        End = DateTime.UtcNow.AddDays(35).AddHours(10), 
        PriceAdult = 67, Type = "Train", InitialSeats = 108,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(8), 
        End = DateTime.UtcNow.AddDays(30).AddHours(18), 
        PriceAdult = 167, Type = "Plane", InitialSeats = 155,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(17), 
        End = DateTime.UtcNow.AddDays(80).AddHours(1), 
        PriceAdult = 90, Type = "Train", InitialSeats = 97,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(16).AddHours(18), 
        End = DateTime.UtcNow.AddDays(17).AddHours(2), 
        PriceAdult = 297, Type = "Bus", InitialSeats = 80,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(13), 
        End = DateTime.UtcNow.AddDays(54).AddHours(17), 
        PriceAdult = 105, Type = "Bus", InitialSeats = 200,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(5), 
        End = DateTime.UtcNow.AddDays(22).AddHours(12), 
        PriceAdult = 260, Type = "Plane", InitialSeats = 179,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(16), 
        End = DateTime.UtcNow.AddDays(89).AddHours(22), 
        PriceAdult = 280, Type = "Train", InitialSeats = 59,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(10), 
        End = DateTime.UtcNow.AddDays(40).AddHours(21), 
        PriceAdult = 199, Type = "Plane", InitialSeats = 81,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(14), 
        End = DateTime.UtcNow.AddDays(87).AddHours(16), 
        PriceAdult = 276, Type = "Bus", InitialSeats = 162,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(14), 
        End = DateTime.UtcNow.AddDays(84).AddHours(17), 
        PriceAdult = 162, Type = "Bus", InitialSeats = 145,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(11).AddHours(7), 
        End = DateTime.UtcNow.AddDays(11).AddHours(9), 
        PriceAdult = 257, Type = "Train", InitialSeats = 90,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(33).AddHours(5), 
        End = DateTime.UtcNow.AddDays(33).AddHours(9), 
        PriceAdult = 203, Type = "Train", InitialSeats = 138,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(2), 
        End = DateTime.UtcNow.AddDays(81).AddHours(14), 
        PriceAdult = 265, Type = "Train", InitialSeats = 131,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(1), 
        End = DateTime.UtcNow.AddDays(22).AddHours(9), 
        PriceAdult = 254, Type = "Train", InitialSeats = 106,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(4), 
        End = DateTime.UtcNow.AddDays(53).AddHours(8), 
        PriceAdult = 108, Type = "Bus", InitialSeats = 177,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(67).AddHours(16), 
        End = DateTime.UtcNow.AddDays(67).AddHours(18), 
        PriceAdult = 175, Type = "Bus", InitialSeats = 172,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(21), 
        End = DateTime.UtcNow.AddDays(10).AddHours(7), 
        PriceAdult = 158, Type = "Bus", InitialSeats = 175,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(15), 
        End = DateTime.UtcNow.AddDays(27).AddHours(20), 
        PriceAdult = 135, Type = "Plane", InitialSeats = 68,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(16), 
        End = DateTime.UtcNow.AddDays(14).AddHours(3), 
        PriceAdult = 54, Type = "Bus", InitialSeats = 100,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(20), 
        End = DateTime.UtcNow.AddDays(37).AddHours(2), 
        PriceAdult = 118, Type = "Bus", InitialSeats = 82,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(33).AddHours(22), 
        End = DateTime.UtcNow.AddDays(34).AddHours(2), 
        PriceAdult = 242, Type = "Bus", InitialSeats = 172,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(14), 
        End = DateTime.UtcNow.AddDays(55).AddHours(23), 
        PriceAdult = 96, Type = "Train", InitialSeats = 116,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(8), 
        End = DateTime.UtcNow.AddDays(43).AddHours(16), 
        PriceAdult = 108, Type = "Plane", InitialSeats = 137,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(62).AddHours(11), 
        End = DateTime.UtcNow.AddDays(62).AddHours(14), 
        PriceAdult = 101, Type = "Plane", InitialSeats = 161,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(7), 
        End = DateTime.UtcNow.AddDays(35).AddHours(10), 
        PriceAdult = 204, Type = "Train", InitialSeats = 61,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(52).AddHours(4), 
        End = DateTime.UtcNow.AddDays(52).AddHours(16), 
        PriceAdult = 55, Type = "Bus", InitialSeats = 141,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(3).AddHours(12), 
        End = DateTime.UtcNow.AddDays(3).AddHours(21), 
        PriceAdult = 78, Type = "Bus", InitialSeats = 156,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(10), 
        End = DateTime.UtcNow.AddDays(77).AddHours(18), 
        PriceAdult = 223, Type = "Train", InitialSeats = 138,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(10), 
        End = DateTime.UtcNow.AddDays(83).AddHours(22), 
        PriceAdult = 123, Type = "Bus", InitialSeats = 164,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(0), 
        End = DateTime.UtcNow.AddDays(84).AddHours(2), 
        PriceAdult = 169, Type = "Plane", InitialSeats = 187,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(1).AddHours(22), 
        End = DateTime.UtcNow.AddDays(2).AddHours(4), 
        PriceAdult = 250, Type = "Train", InitialSeats = 195,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(22), 
        End = DateTime.UtcNow.AddDays(22).AddHours(6), 
        PriceAdult = 194, Type = "Train", InitialSeats = 134,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(9), 
        End = DateTime.UtcNow.AddDays(38).AddHours(17), 
        PriceAdult = 93, Type = "Bus", InitialSeats = 127,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(3), 
        End = DateTime.UtcNow.AddDays(56).AddHours(5), 
        PriceAdult = 259, Type = "Bus", InitialSeats = 152,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(41).AddHours(14), 
        End = DateTime.UtcNow.AddDays(41).AddHours(23), 
        PriceAdult = 294, Type = "Train", InitialSeats = 163,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(6), 
        End = DateTime.UtcNow.AddDays(8).AddHours(12), 
        PriceAdult = 275, Type = "Train", InitialSeats = 142,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(17), 
        End = DateTime.UtcNow.AddDays(77).AddHours(5), 
        PriceAdult = 123, Type = "Plane", InitialSeats = 105,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(18), 
        End = DateTime.UtcNow.AddDays(15).AddHours(21), 
        PriceAdult = 83, Type = "Train", InitialSeats = 194,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(16), 
        End = DateTime.UtcNow.AddDays(17).AddHours(20), 
        PriceAdult = 101, Type = "Plane", InitialSeats = 180,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(22), 
        End = DateTime.UtcNow.AddDays(38).AddHours(6), 
        PriceAdult = 254, Type = "Train", InitialSeats = 182,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(15), 
        End = DateTime.UtcNow.AddDays(83).AddHours(18), 
        PriceAdult = 179, Type = "Plane", InitialSeats = 150,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(12), 
        End = DateTime.UtcNow.AddDays(8).AddHours(14), 
        PriceAdult = 151, Type = "Bus", InitialSeats = 57,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(1), 
        End = DateTime.UtcNow.AddDays(6).AddHours(11), 
        PriceAdult = 151, Type = "Train", InitialSeats = 200,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(0), 
        End = DateTime.UtcNow.AddDays(12).AddHours(3), 
        PriceAdult = 101, Type = "Train", InitialSeats = 184,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(32).AddHours(22), 
        End = DateTime.UtcNow.AddDays(33).AddHours(2), 
        PriceAdult = 259, Type = "Train", InitialSeats = 166,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(8), 
        End = DateTime.UtcNow.AddDays(54).AddHours(14), 
        PriceAdult = 212, Type = "Plane", InitialSeats = 106,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(7), 
        End = DateTime.UtcNow.AddDays(40).AddHours(15), 
        PriceAdult = 153, Type = "Bus", InitialSeats = 147,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(21), 
        End = DateTime.UtcNow.AddDays(31).AddHours(9), 
        PriceAdult = 157, Type = "Bus", InitialSeats = 197,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(15), 
        End = DateTime.UtcNow.AddDays(90).AddHours(24), 
        PriceAdult = 140, Type = "Bus", InitialSeats = 71,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(5), 
        End = DateTime.UtcNow.AddDays(29).AddHours(12), 
        PriceAdult = 113, Type = "Train", InitialSeats = 189,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(41).AddHours(16), 
        End = DateTime.UtcNow.AddDays(41).AddHours(23), 
        PriceAdult = 183, Type = "Train", InitialSeats = 107,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(5), 
        End = DateTime.UtcNow.AddDays(13).AddHours(13), 
        PriceAdult = 131, Type = "Bus", InitialSeats = 129,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(13), 
        End = DateTime.UtcNow.AddDays(45).AddHours(19), 
        PriceAdult = 278, Type = "Plane", InitialSeats = 181,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(10), 
        End = DateTime.UtcNow.AddDays(42).AddHours(16), 
        PriceAdult = 100, Type = "Plane", InitialSeats = 69,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(15), 
        End = DateTime.UtcNow.AddDays(82).AddHours(23), 
        PriceAdult = 196, Type = "Plane", InitialSeats = 143,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(0), 
        End = DateTime.UtcNow.AddDays(37).AddHours(5), 
        PriceAdult = 51, Type = "Bus", InitialSeats = 131,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(10), 
        End = DateTime.UtcNow.AddDays(14).AddHours(12), 
        PriceAdult = 256, Type = "Plane", InitialSeats = 166,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(16).AddHours(8), 
        End = DateTime.UtcNow.AddDays(16).AddHours(10), 
        PriceAdult = 77, Type = "Train", InitialSeats = 172,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(4), 
        End = DateTime.UtcNow.AddDays(87).AddHours(9), 
        PriceAdult = 141, Type = "Plane", InitialSeats = 146,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(19).AddHours(16), 
        End = DateTime.UtcNow.AddDays(20).AddHours(1), 
        PriceAdult = 123, Type = "Plane", InitialSeats = 126,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(7), 
        End = DateTime.UtcNow.AddDays(6).AddHours(17), 
        PriceAdult = 179, Type = "Bus", InitialSeats = 132,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(17), 
        End = DateTime.UtcNow.AddDays(64).AddHours(4), 
        PriceAdult = 270, Type = "Bus", InitialSeats = 81,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(74).AddHours(13), 
        End = DateTime.UtcNow.AddDays(75).AddHours(1), 
        PriceAdult = 109, Type = "Bus", InitialSeats = 53,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(7), 
        End = DateTime.UtcNow.AddDays(51).AddHours(18), 
        PriceAdult = 246, Type = "Train", InitialSeats = 59,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(12), 
        End = DateTime.UtcNow.AddDays(65).AddHours(24), 
        PriceAdult = 141, Type = "Train", InitialSeats = 195,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(58).AddHours(12), 
        End = DateTime.UtcNow.AddDays(58).AddHours(17), 
        PriceAdult = 51, Type = "Plane", InitialSeats = 140,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(19), 
        End = DateTime.UtcNow.AddDays(31).AddHours(5), 
        PriceAdult = 88, Type = "Plane", InitialSeats = 151,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(7), 
        End = DateTime.UtcNow.AddDays(59).AddHours(9), 
        PriceAdult = 54, Type = "Train", InitialSeats = 102,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(11), 
        End = DateTime.UtcNow.AddDays(71).AddHours(19), 
        PriceAdult = 237, Type = "Train", InitialSeats = 184,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(12), 
        End = DateTime.UtcNow.AddDays(9).AddHours(15), 
        PriceAdult = 56, Type = "Plane", InitialSeats = 135,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(74).AddHours(22), 
        End = DateTime.UtcNow.AddDays(75).AddHours(7), 
        PriceAdult = 275, Type = "Train", InitialSeats = 164,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(88).AddHours(22), 
        End = DateTime.UtcNow.AddDays(89).AddHours(9), 
        PriceAdult = 137, Type = "Train", InitialSeats = 196,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(11), 
        End = DateTime.UtcNow.AddDays(80).AddHours(13), 
        PriceAdult = 276, Type = "Train", InitialSeats = 88,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(4), 
        End = DateTime.UtcNow.AddDays(6).AddHours(8), 
        PriceAdult = 249, Type = "Bus", InitialSeats = 179,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(4), 
        End = DateTime.UtcNow.AddDays(71).AddHours(15), 
        PriceAdult = 254, Type = "Bus", InitialSeats = 116,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(24).AddHours(4), 
        End = DateTime.UtcNow.AddDays(24).AddHours(13), 
        PriceAdult = 164, Type = "Train", InitialSeats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(12), 
        End = DateTime.UtcNow.AddDays(89).AddHours(22), 
        PriceAdult = 59, Type = "Train", InitialSeats = 191,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(18), 
        End = DateTime.UtcNow.AddDays(2).AddHours(23), 
        PriceAdult = 275, Type = "Bus", InitialSeats = 166,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(19), 
        End = DateTime.UtcNow.AddDays(20).AddHours(22), 
        PriceAdult = 190, Type = "Train", InitialSeats = 126,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(6), 
        End = DateTime.UtcNow.AddDays(84).AddHours(13), 
        PriceAdult = 127, Type = "Bus", InitialSeats = 170,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(14), 
        End = DateTime.UtcNow.AddDays(51).AddHours(20), 
        PriceAdult = 192, Type = "Train", InitialSeats = 191,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(3), 
        End = DateTime.UtcNow.AddDays(22).AddHours(7), 
        PriceAdult = 194, Type = "Train", InitialSeats = 68,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(4), 
        End = DateTime.UtcNow.AddDays(76).AddHours(7), 
        PriceAdult = 227, Type = "Train", InitialSeats = 189,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(5), 
        End = DateTime.UtcNow.AddDays(37).AddHours(9), 
        PriceAdult = 132, Type = "Bus", InitialSeats = 173,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(5), 
        End = DateTime.UtcNow.AddDays(22).AddHours(13), 
        PriceAdult = 90, Type = "Plane", InitialSeats = 94,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(73).AddHours(21), 
        End = DateTime.UtcNow.AddDays(74).AddHours(8), 
        PriceAdult = 291, Type = "Train", InitialSeats = 69,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(6), 
        End = DateTime.UtcNow.AddDays(38).AddHours(15), 
        PriceAdult = 256, Type = "Plane", InitialSeats = 157,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(15), 
        End = DateTime.UtcNow.AddDays(80).AddHours(17), 
        PriceAdult = 153, Type = "Plane", InitialSeats = 130,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(7).AddHours(4), 
        End = DateTime.UtcNow.AddDays(7).AddHours(14), 
        PriceAdult = 123, Type = "Train", InitialSeats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(8), 
        End = DateTime.UtcNow.AddDays(65).AddHours(19), 
        PriceAdult = 81, Type = "Plane", InitialSeats = 200,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(15), 
        End = DateTime.UtcNow.AddDays(76).AddHours(18), 
        PriceAdult = 274, Type = "Bus", InitialSeats = 64,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(68).AddHours(13), 
        End = DateTime.UtcNow.AddDays(68).AddHours(19), 
        PriceAdult = 118, Type = "Plane", InitialSeats = 79,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(10), 
        End = DateTime.UtcNow.AddDays(29).AddHours(12), 
        PriceAdult = 188, Type = "Plane", InitialSeats = 171,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(0), 
        End = DateTime.UtcNow.AddDays(61).AddHours(6), 
        PriceAdult = 126, Type = "Train", InitialSeats = 58,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(18), 
        End = DateTime.UtcNow.AddDays(21).AddHours(22), 
        PriceAdult = 211, Type = "Train", InitialSeats = 165,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(16), 
        End = DateTime.UtcNow.AddDays(71).AddHours(19), 
        PriceAdult = 65, Type = "Bus", InitialSeats = 184,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(23), 
        End = DateTime.UtcNow.AddDays(44).AddHours(2), 
        PriceAdult = 99, Type = "Plane", InitialSeats = 153,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(20), 
        End = DateTime.UtcNow.AddDays(14).AddHours(22), 
        PriceAdult = 159, Type = "Bus", InitialSeats = 113,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(58).AddHours(11), 
        End = DateTime.UtcNow.AddDays(58).AddHours(14), 
        PriceAdult = 129, Type = "Plane", InitialSeats = 144,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(70).AddHours(13), 
        End = DateTime.UtcNow.AddDays(70).AddHours(16), 
        PriceAdult = 118, Type = "Plane", InitialSeats = 58,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(12), 
        End = DateTime.UtcNow.AddDays(66).AddHours(16), 
        PriceAdult = 57, Type = "Plane", InitialSeats = 181,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(16), 
        End = DateTime.UtcNow.AddDays(38).AddHours(21), 
        PriceAdult = 263, Type = "Bus", InitialSeats = 180,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(23).AddHours(17), 
        End = DateTime.UtcNow.AddDays(23).AddHours(22), 
        PriceAdult = 103, Type = "Plane", InitialSeats = 158,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(9), 
        End = DateTime.UtcNow.AddDays(42).AddHours(16), 
        PriceAdult = 169, Type = "Train", InitialSeats = 125,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(12), 
        End = DateTime.UtcNow.AddDays(53).AddHours(22), 
        PriceAdult = 158, Type = "Plane", InitialSeats = 57,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(3), 
        End = DateTime.UtcNow.AddDays(38).AddHours(13), 
        PriceAdult = 236, Type = "Train", InitialSeats = 140,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(7), 
        End = DateTime.UtcNow.AddDays(53).AddHours(12), 
        PriceAdult = 145, Type = "Bus", InitialSeats = 161,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(5), 
        End = DateTime.UtcNow.AddDays(80).AddHours(10), 
        PriceAdult = 131, Type = "Plane", InitialSeats = 148,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(16), 
        End = DateTime.UtcNow.AddDays(37).AddHours(4), 
        PriceAdult = 228, Type = "Train", InitialSeats = 131,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(8), 
        End = DateTime.UtcNow.AddDays(15).AddHours(16), 
        PriceAdult = 215, Type = "Bus", InitialSeats = 92,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(10), 
        End = DateTime.UtcNow.AddDays(45).AddHours(13), 
        PriceAdult = 55, Type = "Train", InitialSeats = 191,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(21), 
        End = DateTime.UtcNow.AddDays(18).AddHours(1), 
        PriceAdult = 242, Type = "Bus", InitialSeats = 171,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(17), 
        End = DateTime.UtcNow.AddDays(89).AddHours(24), 
        PriceAdult = 151, Type = "Plane", InitialSeats = 155,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(0), 
        End = DateTime.UtcNow.AddDays(47).AddHours(4), 
        PriceAdult = 244, Type = "Bus", InitialSeats = 133,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(13), 
        End = DateTime.UtcNow.AddDays(54).AddHours(22), 
        PriceAdult = 243, Type = "Train", InitialSeats = 50,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(23), 
        End = DateTime.UtcNow.AddDays(7).AddHours(5), 
        PriceAdult = 171, Type = "Plane", InitialSeats = 99,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(15), 
        End = DateTime.UtcNow.AddDays(28).AddHours(2), 
        PriceAdult = 72, Type = "Plane", InitialSeats = 69,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(23).AddHours(4), 
        End = DateTime.UtcNow.AddDays(23).AddHours(8), 
        PriceAdult = 94, Type = "Train", InitialSeats = 104,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(3), 
        End = DateTime.UtcNow.AddDays(18).AddHours(13), 
        PriceAdult = 222, Type = "Bus", InitialSeats = 138,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(21), 
        End = DateTime.UtcNow.AddDays(82).AddHours(2), 
        PriceAdult = 150, Type = "Train", InitialSeats = 71,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(10), 
        End = DateTime.UtcNow.AddDays(44).AddHours(22), 
        PriceAdult = 187, Type = "Plane", InitialSeats = 99,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(12), 
        End = DateTime.UtcNow.AddDays(63).AddHours(22), 
        PriceAdult = 219, Type = "Train", InitialSeats = 126,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(21), 
        End = DateTime.UtcNow.AddDays(88).AddHours(8), 
        PriceAdult = 289, Type = "Bus", InitialSeats = 98,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(3), 
        End = DateTime.UtcNow.AddDays(79).AddHours(12), 
        PriceAdult = 238, Type = "Bus", InitialSeats = 181,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(78).AddHours(4), 
        End = DateTime.UtcNow.AddDays(78).AddHours(9), 
        PriceAdult = 135, Type = "Train", InitialSeats = 129,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(1), 
        End = DateTime.UtcNow.AddDays(84).AddHours(7), 
        PriceAdult = 78, Type = "Plane", InitialSeats = 145,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(23), 
        End = DateTime.UtcNow.AddDays(9).AddHours(10), 
        PriceAdult = 195, Type = "Plane", InitialSeats = 191,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(19), 
        End = DateTime.UtcNow.AddDays(23).AddHours(2), 
        PriceAdult = 147, Type = "Plane", InitialSeats = 151,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(4), 
        End = DateTime.UtcNow.AddDays(12).AddHours(15), 
        PriceAdult = 119, Type = "Train", InitialSeats = 65,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(0), 
        End = DateTime.UtcNow.AddDays(82).AddHours(5), 
        PriceAdult = 215, Type = "Plane", InitialSeats = 74,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(20), 
        End = DateTime.UtcNow.AddDays(64).AddHours(24), 
        PriceAdult = 279, Type = "Plane", InitialSeats = 144,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(4), 
        End = DateTime.UtcNow.AddDays(47).AddHours(11), 
        PriceAdult = 196, Type = "Bus", InitialSeats = 86,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(18), 
        End = DateTime.UtcNow.AddDays(59).AddHours(21), 
        PriceAdult = 187, Type = "Bus", InitialSeats = 140,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(1), 
        End = DateTime.UtcNow.AddDays(76).AddHours(13), 
        PriceAdult = 202, Type = "Bus", InitialSeats = 102,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(11), 
        End = DateTime.UtcNow.AddDays(44).AddHours(22), 
        PriceAdult = 271, Type = "Plane", InitialSeats = 116,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(11), 
        End = DateTime.UtcNow.AddDays(37).AddHours(13), 
        PriceAdult = 125, Type = "Train", InitialSeats = 183,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(17), 
        End = DateTime.UtcNow.AddDays(21).AddHours(20), 
        PriceAdult = 190, Type = "Bus", InitialSeats = 142,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(25).AddHours(12), 
        End = DateTime.UtcNow.AddDays(25).AddHours(18), 
        PriceAdult = 264, Type = "Bus", InitialSeats = 189,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(5), 
        End = DateTime.UtcNow.AddDays(8).AddHours(10), 
        PriceAdult = 169, Type = "Bus", InitialSeats = 81,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(7), 
        End = DateTime.UtcNow.AddDays(43).AddHours(15), 
        PriceAdult = 300, Type = "Plane", InitialSeats = 115,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(10).AddHours(11), 
        End = DateTime.UtcNow.AddDays(10).AddHours(15), 
        PriceAdult = 249, Type = "Train", InitialSeats = 155,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(10), 
        End = DateTime.UtcNow.AddDays(53).AddHours(22), 
        PriceAdult = 105, Type = "Plane", InitialSeats = 61,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(8), 
        End = DateTime.UtcNow.AddDays(85).AddHours(14), 
        PriceAdult = 242, Type = "Bus", InitialSeats = 62,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(7), 
        End = DateTime.UtcNow.AddDays(45).AddHours(11), 
        PriceAdult = 146, Type = "Bus", InitialSeats = 74,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(10), 
        End = DateTime.UtcNow.AddDays(44).AddHours(12), 
        PriceAdult = 136, Type = "Plane", InitialSeats = 147,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(19).AddHours(10), 
        End = DateTime.UtcNow.AddDays(19).AddHours(17), 
        PriceAdult = 168, Type = "Bus", InitialSeats = 111,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(4), 
        End = DateTime.UtcNow.AddDays(37).AddHours(6), 
        PriceAdult = 140, Type = "Train", InitialSeats = 98,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(11), 
        End = DateTime.UtcNow.AddDays(85).AddHours(23), 
        PriceAdult = 198, Type = "Plane", InitialSeats = 84,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(52).AddHours(4), 
        End = DateTime.UtcNow.AddDays(52).AddHours(6), 
        PriceAdult = 286, Type = "Plane", InitialSeats = 136,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(17), 
        End = DateTime.UtcNow.AddDays(87).AddHours(20), 
        PriceAdult = 87, Type = "Plane", InitialSeats = 88,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(5), 
        End = DateTime.UtcNow.AddDays(14).AddHours(10), 
        PriceAdult = 185, Type = "Bus", InitialSeats = 145,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(22), 
        End = DateTime.UtcNow.AddDays(81).AddHours(1), 
        PriceAdult = 244, Type = "Train", InitialSeats = 72,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(19), 
        End = DateTime.UtcNow.AddDays(2).AddHours(21), 
        PriceAdult = 291, Type = "Train", InitialSeats = 51,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(5), 
        End = DateTime.UtcNow.AddDays(42).AddHours(9), 
        PriceAdult = 191, Type = "Plane", InitialSeats = 163,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(14), 
        End = DateTime.UtcNow.AddDays(15).AddHours(21), 
        PriceAdult = 268, Type = "Plane", InitialSeats = 67,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(13), 
        End = DateTime.UtcNow.AddDays(81).AddHours(16), 
        PriceAdult = 204, Type = "Bus", InitialSeats = 108,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(16), 
        End = DateTime.UtcNow.AddDays(6).AddHours(1), 
        PriceAdult = 197, Type = "Bus", InitialSeats = 157,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(14), 
        End = DateTime.UtcNow.AddDays(87).AddHours(19), 
        PriceAdult = 89, Type = "Train", InitialSeats = 146,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(24).AddHours(20), 
        End = DateTime.UtcNow.AddDays(25).AddHours(3), 
        PriceAdult = 296, Type = "Plane", InitialSeats = 174,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(10), 
        End = DateTime.UtcNow.AddDays(47).AddHours(19), 
        PriceAdult = 73, Type = "Train", InitialSeats = 149,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(58).AddHours(18), 
        End = DateTime.UtcNow.AddDays(59).AddHours(6), 
        PriceAdult = 244, Type = "Train", InitialSeats = 189,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(23), 
        End = DateTime.UtcNow.AddDays(14).AddHours(8), 
        PriceAdult = 139, Type = "Bus", InitialSeats = 156,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(73).AddHours(12), 
        End = DateTime.UtcNow.AddDays(73).AddHours(24), 
        PriceAdult = 96, Type = "Plane", InitialSeats = 67,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(9), 
        End = DateTime.UtcNow.AddDays(85).AddHours(11), 
        PriceAdult = 275, Type = "Bus", InitialSeats = 56,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(57).AddHours(20), 
        End = DateTime.UtcNow.AddDays(58).AddHours(5), 
        PriceAdult = 201, Type = "Train", InitialSeats = 194,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(16), 
        End = DateTime.UtcNow.AddDays(42).AddHours(19), 
        PriceAdult = 115, Type = "Bus", InitialSeats = 62,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(13), 
        End = DateTime.UtcNow.AddDays(80).AddHours(17), 
        PriceAdult = 123, Type = "Bus", InitialSeats = 77,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(18), 
        End = DateTime.UtcNow.AddDays(77).AddHours(20), 
        PriceAdult = 223, Type = "Plane", InitialSeats = 114,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(20), 
        End = DateTime.UtcNow.AddDays(66).AddHours(24), 
        PriceAdult = 286, Type = "Bus", InitialSeats = 113,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(6), 
        End = DateTime.UtcNow.AddDays(17).AddHours(13), 
        PriceAdult = 75, Type = "Plane", InitialSeats = 57,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(5), 
        End = DateTime.UtcNow.AddDays(64).AddHours(12), 
        PriceAdult = 274, Type = "Train", InitialSeats = 163,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(58).AddHours(10), 
        End = DateTime.UtcNow.AddDays(58).AddHours(17), 
        PriceAdult = 232, Type = "Bus", InitialSeats = 176,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(13), 
        End = DateTime.UtcNow.AddDays(66).AddHours(20), 
        PriceAdult = 268, Type = "Plane", InitialSeats = 168,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(1), 
        End = DateTime.UtcNow.AddDays(66).AddHours(13), 
        PriceAdult = 109, Type = "Plane", InitialSeats = 196,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(11), 
        End = DateTime.UtcNow.AddDays(12).AddHours(14), 
        PriceAdult = 259, Type = "Train", InitialSeats = 199,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(0), 
        End = DateTime.UtcNow.AddDays(85).AddHours(10), 
        PriceAdult = 166, Type = "Train", InitialSeats = 192,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(20), 
        End = DateTime.UtcNow.AddDays(81).AddHours(4), 
        PriceAdult = 297, Type = "Train", InitialSeats = 160,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(1), 
        End = DateTime.UtcNow.AddDays(48).AddHours(9), 
        PriceAdult = 262, Type = "Bus", InitialSeats = 56,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(12), 
        End = DateTime.UtcNow.AddDays(76).AddHours(23), 
        PriceAdult = 286, Type = "Bus", InitialSeats = 136,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(3), 
        End = DateTime.UtcNow.AddDays(49).AddHours(15), 
        PriceAdult = 185, Type = "Train", InitialSeats = 160,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(13), 
        End = DateTime.UtcNow.AddDays(76).AddHours(19), 
        PriceAdult = 85, Type = "Bus", InitialSeats = 171,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(23), 
        End = DateTime.UtcNow.AddDays(49).AddHours(7), 
        PriceAdult = 151, Type = "Plane", InitialSeats = 136,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(13), 
        End = DateTime.UtcNow.AddDays(29).AddHours(17), 
        PriceAdult = 54, Type = "Train", InitialSeats = 130,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(21), 
        End = DateTime.UtcNow.AddDays(67).AddHours(9), 
        PriceAdult = 239, Type = "Plane", InitialSeats = 140,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(6), 
        End = DateTime.UtcNow.AddDays(29).AddHours(11), 
        PriceAdult = 83, Type = "Plane", InitialSeats = 183,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(23), 
        End = DateTime.UtcNow.AddDays(22).AddHours(8), 
        PriceAdult = 254, Type = "Plane", InitialSeats = 175,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(9), 
        End = DateTime.UtcNow.AddDays(12).AddHours(11), 
        PriceAdult = 241, Type = "Train", InitialSeats = 66,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(68).AddHours(14), 
        End = DateTime.UtcNow.AddDays(68).AddHours(22), 
        PriceAdult = 88, Type = "Train", InitialSeats = 193,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(0), 
        End = DateTime.UtcNow.AddDays(51).AddHours(12), 
        PriceAdult = 108, Type = "Plane", InitialSeats = 82,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(1), 
        End = DateTime.UtcNow.AddDays(29).AddHours(4), 
        PriceAdult = 262, Type = "Bus", InitialSeats = 178,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(7), 
        End = DateTime.UtcNow.AddDays(30).AddHours(14), 
        PriceAdult = 132, Type = "Bus", InitialSeats = 198,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(11).AddHours(0), 
        End = DateTime.UtcNow.AddDays(11).AddHours(8), 
        PriceAdult = 192, Type = "Bus", InitialSeats = 65,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(8), 
        End = DateTime.UtcNow.AddDays(84).AddHours(10), 
        PriceAdult = 251, Type = "Plane", InitialSeats = 123,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(18), 
        End = DateTime.UtcNow.AddDays(80).AddHours(24), 
        PriceAdult = 160, Type = "Train", InitialSeats = 67,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(2), 
        End = DateTime.UtcNow.AddDays(9).AddHours(14), 
        PriceAdult = 164, Type = "Train", InitialSeats = 184,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(13), 
        End = DateTime.UtcNow.AddDays(54).AddHours(17), 
        PriceAdult = 112, Type = "Bus", InitialSeats = 166,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(11), 
        End = DateTime.UtcNow.AddDays(51).AddHours(16), 
        PriceAdult = 233, Type = "Train", InitialSeats = 55,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(7), 
        End = DateTime.UtcNow.AddDays(20).AddHours(14), 
        PriceAdult = 125, Type = "Train", InitialSeats = 95,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(23), 
        End = DateTime.UtcNow.AddDays(85).AddHours(4), 
        PriceAdult = 179, Type = "Bus", InitialSeats = 152,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(0), 
        End = DateTime.UtcNow.AddDays(61).AddHours(3), 
        PriceAdult = 117, Type = "Plane", InitialSeats = 67,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(14), 
        End = DateTime.UtcNow.AddDays(85).AddHours(16), 
        PriceAdult = 195, Type = "Train", InitialSeats = 56,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(0), 
        End = DateTime.UtcNow.AddDays(30).AddHours(4), 
        PriceAdult = 191, Type = "Plane", InitialSeats = 177,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(17), 
        End = DateTime.UtcNow.AddDays(12).AddHours(24), 
        PriceAdult = 277, Type = "Train", InitialSeats = 110,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(60).AddHours(16), 
        End = DateTime.UtcNow.AddDays(61).AddHours(4), 
        PriceAdult = 197, Type = "Train", InitialSeats = 149,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(70).AddHours(6), 
        End = DateTime.UtcNow.AddDays(70).AddHours(11), 
        PriceAdult = 104, Type = "Train", InitialSeats = 187,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(22), 
        End = DateTime.UtcNow.AddDays(50).AddHours(1), 
        PriceAdult = 132, Type = "Plane", InitialSeats = 72,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(22), 
        End = DateTime.UtcNow.AddDays(55).AddHours(24), 
        PriceAdult = 56, Type = "Plane", InitialSeats = 194,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(4), 
        End = DateTime.UtcNow.AddDays(84).AddHours(16), 
        PriceAdult = 94, Type = "Bus", InitialSeats = 194,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(18), 
        End = DateTime.UtcNow.AddDays(6).AddHours(21), 
        PriceAdult = 166, Type = "Plane", InitialSeats = 195,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(19), 
        End = DateTime.UtcNow.AddDays(59).AddHours(23), 
        PriceAdult = 177, Type = "Bus", InitialSeats = 114,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(32).AddHours(10), 
        End = DateTime.UtcNow.AddDays(32).AddHours(15), 
        PriceAdult = 124, Type = "Plane", InitialSeats = 113,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(19), 
        End = DateTime.UtcNow.AddDays(27).AddHours(1), 
        PriceAdult = 212, Type = "Train", InitialSeats = 178,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(23), 
        End = DateTime.UtcNow.AddDays(30).AddHours(4), 
        PriceAdult = 68, Type = "Bus", InitialSeats = 171,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(23), 
        End = DateTime.UtcNow.AddDays(7).AddHours(11), 
        PriceAdult = 59, Type = "Bus", InitialSeats = 144,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(7), 
        End = DateTime.UtcNow.AddDays(13).AddHours(15), 
        PriceAdult = 92, Type = "Bus", InitialSeats = 67,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(12), 
        End = DateTime.UtcNow.AddDays(77).AddHours(19), 
        PriceAdult = 99, Type = "Train", InitialSeats = 180,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(1), 
        End = DateTime.UtcNow.AddDays(17).AddHours(9), 
        PriceAdult = 271, Type = "Plane", InitialSeats = 197,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(3), 
        End = DateTime.UtcNow.AddDays(48).AddHours(9), 
        PriceAdult = 149, Type = "Bus", InitialSeats = 157,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(22), 
        End = DateTime.UtcNow.AddDays(31).AddHours(5), 
        PriceAdult = 157, Type = "Plane", InitialSeats = 179,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(3), 
        End = DateTime.UtcNow.AddDays(4).AddHours(15), 
        PriceAdult = 194, Type = "Plane", InitialSeats = 58,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(3), 
        End = DateTime.UtcNow.AddDays(38).AddHours(5), 
        PriceAdult = 88, Type = "Plane", InitialSeats = 198,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(68).AddHours(16), 
        End = DateTime.UtcNow.AddDays(68).AddHours(21), 
        PriceAdult = 269, Type = "Plane", InitialSeats = 105,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(74).AddHours(22), 
        End = DateTime.UtcNow.AddDays(75).AddHours(10), 
        PriceAdult = 158, Type = "Bus", InitialSeats = 87,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(78).AddHours(3), 
        End = DateTime.UtcNow.AddDays(78).AddHours(7), 
        PriceAdult = 197, Type = "Plane", InitialSeats = 105,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(75).AddHours(15), 
        End = DateTime.UtcNow.AddDays(76).AddHours(1), 
        PriceAdult = 181, Type = "Plane", InitialSeats = 120,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(22), 
        End = DateTime.UtcNow.AddDays(54).AddHours(24), 
        PriceAdult = 166, Type = "Bus", InitialSeats = 131,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(1), 
        End = DateTime.UtcNow.AddDays(71).AddHours(11), 
        PriceAdult = 287, Type = "Train", InitialSeats = 53,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(21), 
        End = DateTime.UtcNow.AddDays(66).AddHours(24), 
        PriceAdult = 124, Type = "Train", InitialSeats = 165,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(28).AddHours(17), 
        End = DateTime.UtcNow.AddDays(28).AddHours(24), 
        PriceAdult = 51, Type = "Plane", InitialSeats = 132,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(8), 
        End = DateTime.UtcNow.AddDays(4).AddHours(20), 
        PriceAdult = 106, Type = "Bus", InitialSeats = 155,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(3).AddHours(6), 
        End = DateTime.UtcNow.AddDays(3).AddHours(15), 
        PriceAdult = 106, Type = "Train", InitialSeats = 149,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(15), 
        End = DateTime.UtcNow.AddDays(79).AddHours(21), 
        PriceAdult = 67, Type = "Bus", InitialSeats = 77,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(5), 
        End = DateTime.UtcNow.AddDays(42).AddHours(11), 
        PriceAdult = 234, Type = "Train", InitialSeats = 166,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(20), 
        End = DateTime.UtcNow.AddDays(46).AddHours(2), 
        PriceAdult = 255, Type = "Plane", InitialSeats = 126,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(6), 
        End = DateTime.UtcNow.AddDays(76).AddHours(10), 
        PriceAdult = 134, Type = "Train", InitialSeats = 131,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(23), 
        End = DateTime.UtcNow.AddDays(62).AddHours(3), 
        PriceAdult = 289, Type = "Bus", InitialSeats = 127,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(57).AddHours(9), 
        End = DateTime.UtcNow.AddDays(57).AddHours(12), 
        PriceAdult = 62, Type = "Plane", InitialSeats = 181,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(2), 
        End = DateTime.UtcNow.AddDays(18).AddHours(5), 
        PriceAdult = 196, Type = "Train", InitialSeats = 55,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(1), 
        End = DateTime.UtcNow.AddDays(81).AddHours(4), 
        PriceAdult = 251, Type = "Plane", InitialSeats = 141,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(3), 
        End = DateTime.UtcNow.AddDays(4).AddHours(12), 
        PriceAdult = 56, Type = "Plane", InitialSeats = 126,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(5), 
        End = DateTime.UtcNow.AddDays(82).AddHours(13), 
        PriceAdult = 195, Type = "Bus", InitialSeats = 171,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(6), 
        End = DateTime.UtcNow.AddDays(45).AddHours(8), 
        PriceAdult = 116, Type = "Bus", InitialSeats = 170,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(6), 
        End = DateTime.UtcNow.AddDays(2).AddHours(17), 
        PriceAdult = 297, Type = "Bus", InitialSeats = 168,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(10), 
        End = DateTime.UtcNow.AddDays(80).AddHours(21), 
        PriceAdult = 270, Type = "Train", InitialSeats = 65,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(22), 
        End = DateTime.UtcNow.AddDays(82).AddHours(2), 
        PriceAdult = 79, Type = "Train", InitialSeats = 167,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(24).AddHours(9), 
        End = DateTime.UtcNow.AddDays(24).AddHours(16), 
        PriceAdult = 268, Type = "Train", InitialSeats = 105,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(8), 
        End = DateTime.UtcNow.AddDays(36).AddHours(17), 
        PriceAdult = 51, Type = "Train", InitialSeats = 157,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(17), 
        End = DateTime.UtcNow.AddDays(8).AddHours(24), 
        PriceAdult = 124, Type = "Bus", InitialSeats = 190,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(19), 
        End = DateTime.UtcNow.AddDays(6).AddHours(6), 
        PriceAdult = 146, Type = "Train", InitialSeats = 164,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(9), 
        End = DateTime.UtcNow.AddDays(9).AddHours(13), 
        PriceAdult = 131, Type = "Train", InitialSeats = 160,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(88).AddHours(15), 
        End = DateTime.UtcNow.AddDays(88).AddHours(22), 
        PriceAdult = 235, Type = "Bus", InitialSeats = 108,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(33).AddHours(21), 
        End = DateTime.UtcNow.AddDays(34).AddHours(7), 
        PriceAdult = 290, Type = "Plane", InitialSeats = 120,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(23).AddHours(5), 
        End = DateTime.UtcNow.AddDays(23).AddHours(16), 
        PriceAdult = 297, Type = "Bus", InitialSeats = 121,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(13), 
        End = DateTime.UtcNow.AddDays(85).AddHours(23), 
        PriceAdult = 208, Type = "Bus", InitialSeats = 134,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(20), 
        End = DateTime.UtcNow.AddDays(36).AddHours(7), 
        PriceAdult = 129, Type = "Train", InitialSeats = 192,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(11), 
        End = DateTime.UtcNow.AddDays(18).AddHours(16), 
        PriceAdult = 161, Type = "Bus", InitialSeats = 106,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(4), 
        End = DateTime.UtcNow.AddDays(17).AddHours(13), 
        PriceAdult = 65, Type = "Train", InitialSeats = 175,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(14), 
        End = DateTime.UtcNow.AddDays(29).AddHours(23), 
        PriceAdult = 238, Type = "Plane", InitialSeats = 146,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(20), 
        End = DateTime.UtcNow.AddDays(56).AddHours(6), 
        PriceAdult = 224, Type = "Train", InitialSeats = 111,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(3).AddHours(3), 
        End = DateTime.UtcNow.AddDays(3).AddHours(14), 
        PriceAdult = 107, Type = "Plane", InitialSeats = 161,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(7), 
        End = DateTime.UtcNow.AddDays(55).AddHours(13), 
        PriceAdult = 295, Type = "Bus", InitialSeats = 174,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(15), 
        End = DateTime.UtcNow.AddDays(48).AddHours(2), 
        PriceAdult = 158, Type = "Plane", InitialSeats = 134,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(9), 
        End = DateTime.UtcNow.AddDays(5).AddHours(12), 
        PriceAdult = 178, Type = "Plane", InitialSeats = 77,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(1), 
        End = DateTime.UtcNow.AddDays(20).AddHours(5), 
        PriceAdult = 92, Type = "Bus", InitialSeats = 171,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(3), 
        End = DateTime.UtcNow.AddDays(71).AddHours(10), 
        PriceAdult = 287, Type = "Plane", InitialSeats = 131,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(17), 
        End = DateTime.UtcNow.AddDays(27).AddHours(1), 
        PriceAdult = 289, Type = "Plane", InitialSeats = 137,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(8), 
        End = DateTime.UtcNow.AddDays(65).AddHours(11), 
        PriceAdult = 279, Type = "Bus", InitialSeats = 127,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(2), 
        End = DateTime.UtcNow.AddDays(79).AddHours(14), 
        PriceAdult = 140, Type = "Bus", InitialSeats = 69,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(23), 
        End = DateTime.UtcNow.AddDays(48).AddHours(1), 
        PriceAdult = 290, Type = "Bus", InitialSeats = 133,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(21), 
        End = DateTime.UtcNow.AddDays(81).AddHours(23), 
        PriceAdult = 184, Type = "Bus", InitialSeats = 118,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(16), 
        End = DateTime.UtcNow.AddDays(21).AddHours(21), 
        PriceAdult = 172, Type = "Train", InitialSeats = 103,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(39).AddHours(15), 
        End = DateTime.UtcNow.AddDays(39).AddHours(19), 
        PriceAdult = 222, Type = "Plane", InitialSeats = 51,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(11), 
        End = DateTime.UtcNow.AddDays(83).AddHours(13), 
        PriceAdult = 187, Type = "Train", InitialSeats = 94,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(17), 
        End = DateTime.UtcNow.AddDays(3).AddHours(3), 
        PriceAdult = 91, Type = "Plane", InitialSeats = 83,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(18), 
        End = DateTime.UtcNow.AddDays(36).AddHours(20), 
        PriceAdult = 131, Type = "Train", InitialSeats = 66,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(28).AddHours(10), 
        End = DateTime.UtcNow.AddDays(28).AddHours(13), 
        PriceAdult = 137, Type = "Train", InitialSeats = 57,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(10), 
        End = DateTime.UtcNow.AddDays(43).AddHours(21), 
        PriceAdult = 180, Type = "Plane", InitialSeats = 51,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(16), 
        End = DateTime.UtcNow.AddDays(15).AddHours(21), 
        PriceAdult = 74, Type = "Plane", InitialSeats = 200,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(4), 
        End = DateTime.UtcNow.AddDays(90).AddHours(6), 
        PriceAdult = 232, Type = "Train", InitialSeats = 96,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(8), 
        End = DateTime.UtcNow.AddDays(51).AddHours(13), 
        PriceAdult = 132, Type = "Plane", InitialSeats = 84,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(73).AddHours(23), 
        End = DateTime.UtcNow.AddDays(74).AddHours(9), 
        PriceAdult = 159, Type = "Plane", InitialSeats = 56,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(8), 
        End = DateTime.UtcNow.AddDays(35).AddHours(16), 
        PriceAdult = 188, Type = "Bus", InitialSeats = 65,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(23), 
        End = DateTime.UtcNow.AddDays(14).AddHours(7), 
        PriceAdult = 126, Type = "Bus", InitialSeats = 147,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(18), 
        End = DateTime.UtcNow.AddDays(65).AddHours(3), 
        PriceAdult = 185, Type = "Plane", InitialSeats = 171,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(5), 
        End = DateTime.UtcNow.AddDays(48).AddHours(13), 
        PriceAdult = 68, Type = "Plane", InitialSeats = 167,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(7), 
        End = DateTime.UtcNow.AddDays(44).AddHours(18), 
        PriceAdult = 226, Type = "Bus", InitialSeats = 57,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(19), 
        End = DateTime.UtcNow.AddDays(44).AddHours(7), 
        PriceAdult = 286, Type = "Bus", InitialSeats = 74,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(9), 
        End = DateTime.UtcNow.AddDays(55).AddHours(11), 
        PriceAdult = 176, Type = "Train", InitialSeats = 55,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(2), 
        End = DateTime.UtcNow.AddDays(87).AddHours(7), 
        PriceAdult = 240, Type = "Train", InitialSeats = 77,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(14), 
        End = DateTime.UtcNow.AddDays(4).AddHours(20), 
        PriceAdult = 131, Type = "Bus", InitialSeats = 149,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(13), 
        End = DateTime.UtcNow.AddDays(38).AddHours(1), 
        PriceAdult = 83, Type = "Plane", InitialSeats = 104,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(1), 
        End = DateTime.UtcNow.AddDays(8).AddHours(5), 
        PriceAdult = 95, Type = "Plane", InitialSeats = 128,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(3), 
        End = DateTime.UtcNow.AddDays(77).AddHours(15), 
        PriceAdult = 182, Type = "Plane", InitialSeats = 190,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(60).AddHours(4), 
        End = DateTime.UtcNow.AddDays(60).AddHours(11), 
        PriceAdult = 87, Type = "Bus", InitialSeats = 137,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(21), 
        End = DateTime.UtcNow.AddDays(35).AddHours(23), 
        PriceAdult = 248, Type = "Plane", InitialSeats = 98,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(1).AddHours(6), 
        End = DateTime.UtcNow.AddDays(1).AddHours(16), 
        PriceAdult = 123, Type = "Train", InitialSeats = 69,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(34).AddHours(2), 
        End = DateTime.UtcNow.AddDays(34).AddHours(13), 
        PriceAdult = 250, Type = "Train", InitialSeats = 186,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(17), 
        End = DateTime.UtcNow.AddDays(60).AddHours(5), 
        PriceAdult = 280, Type = "Train", InitialSeats = 117,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(13), 
        End = DateTime.UtcNow.AddDays(9).AddHours(23), 
        PriceAdult = 95, Type = "Train", InitialSeats = 66,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(21), 
        End = DateTime.UtcNow.AddDays(90).AddHours(7), 
        PriceAdult = 67, Type = "Plane", InitialSeats = 117,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(9), 
        End = DateTime.UtcNow.AddDays(14).AddHours(12), 
        PriceAdult = 92, Type = "Train", InitialSeats = 170,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(2), 
        End = DateTime.UtcNow.AddDays(83).AddHours(10), 
        PriceAdult = 81, Type = "Train", InitialSeats = 130,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(23), 
        End = DateTime.UtcNow.AddDays(84).AddHours(6), 
        PriceAdult = 241, Type = "Train", InitialSeats = 192,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(25).AddHours(16), 
        End = DateTime.UtcNow.AddDays(25).AddHours(22), 
        PriceAdult = 221, Type = "Train", InitialSeats = 89,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(3), 
        End = DateTime.UtcNow.AddDays(4).AddHours(11), 
        PriceAdult = 243, Type = "Plane", InitialSeats = 176,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(16), 
        End = DateTime.UtcNow.AddDays(27).AddHours(1), 
        PriceAdult = 83, Type = "Plane", InitialSeats = 136,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(16), 
        End = DateTime.UtcNow.AddDays(66).AddHours(18), 
        PriceAdult = 53, Type = "Plane", InitialSeats = 174,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(19), 
        End = DateTime.UtcNow.AddDays(39).AddHours(6), 
        PriceAdult = 153, Type = "Train", InitialSeats = 65,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(13), 
        End = DateTime.UtcNow.AddDays(81).AddHours(18), 
        PriceAdult = 95, Type = "Plane", InitialSeats = 166,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(6), 
        End = DateTime.UtcNow.AddDays(35).AddHours(8), 
        PriceAdult = 116, Type = "Plane", InitialSeats = 112,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(9), 
        End = DateTime.UtcNow.AddDays(29).AddHours(16), 
        PriceAdult = 282, Type = "Plane", InitialSeats = 66,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(2), 
        End = DateTime.UtcNow.AddDays(63).AddHours(7), 
        PriceAdult = 108, Type = "Bus", InitialSeats = 200,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(9), 
        End = DateTime.UtcNow.AddDays(38).AddHours(11), 
        PriceAdult = 281, Type = "Plane", InitialSeats = 64,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(25).AddHours(12), 
        End = DateTime.UtcNow.AddDays(25).AddHours(19), 
        PriceAdult = 140, Type = "Bus", InitialSeats = 123,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(3), 
        End = DateTime.UtcNow.AddDays(81).AddHours(11), 
        PriceAdult = 79, Type = "Bus", InitialSeats = 128,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(12), 
        End = DateTime.UtcNow.AddDays(29).AddHours(16), 
        PriceAdult = 97, Type = "Train", InitialSeats = 148,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(19).AddHours(21), 
        End = DateTime.UtcNow.AddDays(20).AddHours(9), 
        PriceAdult = 246, Type = "Train", InitialSeats = 167,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(7), 
        End = DateTime.UtcNow.AddDays(15).AddHours(10), 
        PriceAdult = 58, Type = "Bus", InitialSeats = 82,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(20), 
        End = DateTime.UtcNow.AddDays(59).AddHours(22), 
        PriceAdult = 218, Type = "Plane", InitialSeats = 179,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(19).AddHours(9), 
        End = DateTime.UtcNow.AddDays(19).AddHours(17), 
        PriceAdult = 226, Type = "Train", InitialSeats = 172,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(33).AddHours(21), 
        End = DateTime.UtcNow.AddDays(34).AddHours(5), 
        PriceAdult = 82, Type = "Train", InitialSeats = 127,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(23), 
        End = DateTime.UtcNow.AddDays(15).AddHours(8), 
        PriceAdult = 152, Type = "Plane", InitialSeats = 187,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(20), 
        End = DateTime.UtcNow.AddDays(56).AddHours(22), 
        PriceAdult = 186, Type = "Train", InitialSeats = 121,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(67).AddHours(19), 
        End = DateTime.UtcNow.AddDays(68).AddHours(4), 
        PriceAdult = 190, Type = "Plane", InitialSeats = 110,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(14), 
        End = DateTime.UtcNow.AddDays(38).AddHours(17), 
        PriceAdult = 225, Type = "Train", InitialSeats = 122,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(13), 
        End = DateTime.UtcNow.AddDays(31).AddHours(22), 
        PriceAdult = 203, Type = "Plane", InitialSeats = 80,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(17), 
        End = DateTime.UtcNow.AddDays(37).AddHours(1), 
        PriceAdult = 272, Type = "Plane", InitialSeats = 90,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(10), 
        End = DateTime.UtcNow.AddDays(37).AddHours(18), 
        PriceAdult = 266, Type = "Train", InitialSeats = 194,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(21), 
        End = DateTime.UtcNow.AddDays(84).AddHours(1), 
        PriceAdult = 89, Type = "Train", InitialSeats = 167,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(19), 
        End = DateTime.UtcNow.AddDays(63).AddHours(23), 
        PriceAdult = 91, Type = "Train", InitialSeats = 50,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(13), 
        End = DateTime.UtcNow.AddDays(88).AddHours(1), 
        PriceAdult = 129, Type = "Plane", InitialSeats = 133,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(15), 
        End = DateTime.UtcNow.AddDays(19).AddHours(2), 
        PriceAdult = 137, Type = "Train", InitialSeats = 82,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(1), 
        End = DateTime.UtcNow.AddDays(77).AddHours(6), 
        PriceAdult = 92, Type = "Plane", InitialSeats = 65,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(7), 
        End = DateTime.UtcNow.AddDays(40).AddHours(10), 
        PriceAdult = 140, Type = "Bus", InitialSeats = 63,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(9), 
        End = DateTime.UtcNow.AddDays(8).AddHours(15), 
        PriceAdult = 274, Type = "Train", InitialSeats = 107,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(18), 
        End = DateTime.UtcNow.AddDays(41).AddHours(1), 
        PriceAdult = 284, Type = "Train", InitialSeats = 161,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(13), 
        End = DateTime.UtcNow.AddDays(63).AddHours(20), 
        PriceAdult = 149, Type = "Bus", InitialSeats = 188,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(3), 
        End = DateTime.UtcNow.AddDays(47).AddHours(6), 
        PriceAdult = 267, Type = "Train", InitialSeats = 171,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(22), 
        End = DateTime.UtcNow.AddDays(86).AddHours(7), 
        PriceAdult = 139, Type = "Plane", InitialSeats = 101,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(16).AddHours(13), 
        End = DateTime.UtcNow.AddDays(16).AddHours(15), 
        PriceAdult = 261, Type = "Bus", InitialSeats = 50,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(20), 
        End = DateTime.UtcNow.AddDays(57).AddHours(5), 
        PriceAdult = 54, Type = "Plane", InitialSeats = 103,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(10), 
        End = DateTime.UtcNow.AddDays(26).AddHours(14), 
        PriceAdult = 174, Type = "Plane", InitialSeats = 152,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(3), 
        End = DateTime.UtcNow.AddDays(44).AddHours(10), 
        PriceAdult = 257, Type = "Train", InitialSeats = 117,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(9), 
        End = DateTime.UtcNow.AddDays(82).AddHours(16), 
        PriceAdult = 187, Type = "Train", InitialSeats = 58,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(2), 
        End = DateTime.UtcNow.AddDays(76).AddHours(8), 
        PriceAdult = 100, Type = "Plane", InitialSeats = 132,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(6), 
        End = DateTime.UtcNow.AddDays(5).AddHours(9), 
        PriceAdult = 187, Type = "Plane", InitialSeats = 51,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(28).AddHours(7), 
        End = DateTime.UtcNow.AddDays(28).AddHours(19), 
        PriceAdult = 172, Type = "Train", InitialSeats = 155,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(0), 
        End = DateTime.UtcNow.AddDays(55).AddHours(5), 
        PriceAdult = 125, Type = "Plane", InitialSeats = 84,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(18), 
        End = DateTime.UtcNow.AddDays(2).AddHours(21), 
        PriceAdult = 244, Type = "Train", InitialSeats = 160,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(19), 
        End = DateTime.UtcNow.AddDays(77).AddHours(21), 
        PriceAdult = 278, Type = "Train", InitialSeats = 186,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(11).AddHours(19), 
        End = DateTime.UtcNow.AddDays(11).AddHours(23), 
        PriceAdult = 65, Type = "Train", InitialSeats = 109,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(9), 
        End = DateTime.UtcNow.AddDays(56).AddHours(14), 
        PriceAdult = 248, Type = "Bus", InitialSeats = 168,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(20), 
        End = DateTime.UtcNow.AddDays(57).AddHours(5), 
        PriceAdult = 154, Type = "Train", InitialSeats = 194,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(46).AddHours(10), 
        End = DateTime.UtcNow.AddDays(46).AddHours(14), 
        PriceAdult = 173, Type = "Bus", InitialSeats = 90,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(17), 
        End = DateTime.UtcNow.AddDays(31).AddHours(22), 
        PriceAdult = 130, Type = "Plane", InitialSeats = 141,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(50).AddHours(6), 
        End = DateTime.UtcNow.AddDays(50).AddHours(9), 
        PriceAdult = 235, Type = "Bus", InitialSeats = 179,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(73).AddHours(7), 
        End = DateTime.UtcNow.AddDays(73).AddHours(11), 
        PriceAdult = 97, Type = "Bus", InitialSeats = 174,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(0), 
        End = DateTime.UtcNow.AddDays(90).AddHours(6), 
        PriceAdult = 157, Type = "Train", InitialSeats = 106,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(15), 
        End = DateTime.UtcNow.AddDays(55).AddHours(2), 
        PriceAdult = 66, Type = "Plane", InitialSeats = 169,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(8), 
        End = DateTime.UtcNow.AddDays(65).AddHours(11), 
        PriceAdult = 106, Type = "Bus", InitialSeats = 197,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(74).AddHours(22), 
        End = DateTime.UtcNow.AddDays(75).AddHours(5), 
        PriceAdult = 217, Type = "Bus", InitialSeats = 156,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(14), 
        End = DateTime.UtcNow.AddDays(44).AddHours(2), 
        PriceAdult = 91, Type = "Bus", InitialSeats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(7), 
        End = DateTime.UtcNow.AddDays(77).AddHours(14), 
        PriceAdult = 98, Type = "Plane", InitialSeats = 121,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(22), 
        End = DateTime.UtcNow.AddDays(31).AddHours(3), 
        PriceAdult = 224, Type = "Train", InitialSeats = 97,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(4), 
        End = DateTime.UtcNow.AddDays(44).AddHours(16), 
        PriceAdult = 97, Type = "Plane", InitialSeats = 160,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(10), 
        End = DateTime.UtcNow.AddDays(14).AddHours(17), 
        PriceAdult = 281, Type = "Plane", InitialSeats = 179,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(1).AddHours(0), 
        End = DateTime.UtcNow.AddDays(1).AddHours(2), 
        PriceAdult = 185, Type = "Train", InitialSeats = 53,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(10), 
        End = DateTime.UtcNow.AddDays(61).AddHours(18), 
        PriceAdult = 156, Type = "Train", InitialSeats = 103,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(0), 
        End = DateTime.UtcNow.AddDays(37).AddHours(2), 
        PriceAdult = 115, Type = "Plane", InitialSeats = 83,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(6), 
        End = DateTime.UtcNow.AddDays(49).AddHours(17), 
        PriceAdult = 186, Type = "Train", InitialSeats = 149,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(15), 
        End = DateTime.UtcNow.AddDays(2).AddHours(17), 
        PriceAdult = 282, Type = "Train", InitialSeats = 120,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(19), 
        End = DateTime.UtcNow.AddDays(89).AddHours(21), 
        PriceAdult = 213, Type = "Train", InitialSeats = 164,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(69).AddHours(17), 
        End = DateTime.UtcNow.AddDays(69).AddHours(22), 
        PriceAdult = 141, Type = "Train", InitialSeats = 188,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(10).AddHours(22), 
        End = DateTime.UtcNow.AddDays(11).AddHours(2), 
        PriceAdult = 80, Type = "Plane", InitialSeats = 196,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(16), 
        End = DateTime.UtcNow.AddDays(17).AddHours(24), 
        PriceAdult = 287, Type = "Bus", InitialSeats = 155,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(7), 
        End = DateTime.UtcNow.AddDays(81).AddHours(18), 
        PriceAdult = 143, Type = "Bus", InitialSeats = 176,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(19), 
        End = DateTime.UtcNow.AddDays(42).AddHours(22), 
        PriceAdult = 171, Type = "Plane", InitialSeats = 109,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(10), 
        End = DateTime.UtcNow.AddDays(26).AddHours(16), 
        PriceAdult = 59, Type = "Plane", InitialSeats = 101,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(9), 
        End = DateTime.UtcNow.AddDays(53).AddHours(13), 
        PriceAdult = 273, Type = "Train", InitialSeats = 94,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(2), 
        End = DateTime.UtcNow.AddDays(48).AddHours(13), 
        PriceAdult = 277, Type = "Bus", InitialSeats = 98,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(52).AddHours(14), 
        End = DateTime.UtcNow.AddDays(52).AddHours(21), 
        PriceAdult = 215, Type = "Bus", InitialSeats = 150,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(4), 
        End = DateTime.UtcNow.AddDays(22).AddHours(13), 
        PriceAdult = 253, Type = "Train", InitialSeats = 193,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(23), 
        End = DateTime.UtcNow.AddDays(21).AddHours(3), 
        PriceAdult = 192, Type = "Plane", InitialSeats = 99,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(11).AddHours(23), 
        End = DateTime.UtcNow.AddDays(12).AddHours(7), 
        PriceAdult = 62, Type = "Plane", InitialSeats = 181,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(50).AddHours(18), 
        End = DateTime.UtcNow.AddDays(51).AddHours(6), 
        PriceAdult = 152, Type = "Bus", InitialSeats = 71,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(15), 
        End = DateTime.UtcNow.AddDays(86).AddHours(1), 
        PriceAdult = 129, Type = "Train", InitialSeats = 114,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(34).AddHours(4), 
        End = DateTime.UtcNow.AddDays(34).AddHours(13), 
        PriceAdult = 68, Type = "Bus", InitialSeats = 199,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(8), 
        End = DateTime.UtcNow.AddDays(49).AddHours(20), 
        PriceAdult = 122, Type = "Plane", InitialSeats = 94,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(8), 
        End = DateTime.UtcNow.AddDays(22).AddHours(19), 
        PriceAdult = 292, Type = "Train", InitialSeats = 70,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(21), 
        End = DateTime.UtcNow.AddDays(44).AddHours(9), 
        PriceAdult = 136, Type = "Train", InitialSeats = 99,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(4), 
        End = DateTime.UtcNow.AddDays(79).AddHours(12), 
        PriceAdult = 275, Type = "Train", InitialSeats = 50,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(75).AddHours(11), 
        End = DateTime.UtcNow.AddDays(75).AddHours(22), 
        PriceAdult = 194, Type = "Plane", InitialSeats = 184,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(18), 
        End = DateTime.UtcNow.AddDays(18).AddHours(3), 
        PriceAdult = 73, Type = "Plane", InitialSeats = 52,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },
    
    new CommandTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(8), 
        End = DateTime.UtcNow.AddDays(64).AddHours(17), 
        PriceAdult = 50, Type = "Bus", InitialSeats = 110,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },
    
                    };
      modelBuilder.Entity<CommandTransportOption>().HasData(transportOptions);

var queryTransportOptions = new[]
{

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(13),
        End = DateTime.UtcNow.AddDays(37).AddHours(15),
        PriceAdult = 262, Type = "Bus", Seats = 60,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(17),
        End = DateTime.UtcNow.AddDays(47).AddHours(19),
        PriceAdult = 285, Type = "Plane", Seats = 123,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(17),
        End = DateTime.UtcNow.AddDays(7).AddHours(4),
        PriceAdult = 149, Type = "Plane", Seats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(78).AddHours(9),
        End = DateTime.UtcNow.AddDays(78).AddHours(14),
        PriceAdult = 122, Type = "Bus", Seats = 106,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(1),
        End = DateTime.UtcNow.AddDays(61).AddHours(10),
        PriceAdult = 221, Type = "Bus", Seats = 167,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(15),
        End = DateTime.UtcNow.AddDays(42).AddHours(24),
        PriceAdult = 62, Type = "Bus", Seats = 156,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(88).AddHours(6),
        End = DateTime.UtcNow.AddDays(88).AddHours(14),
        PriceAdult = 64, Type = "Plane", Seats = 189,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(3).AddHours(22),
        End = DateTime.UtcNow.AddDays(4).AddHours(3),
        PriceAdult = 90, Type = "Train", Seats = 90,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(5),
        End = DateTime.UtcNow.AddDays(90).AddHours(14),
        PriceAdult = 65, Type = "Bus", Seats = 135,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(72).AddHours(14),
        End = DateTime.UtcNow.AddDays(72).AddHours(20),
        PriceAdult = 225, Type = "Plane", Seats = 59,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(9),
        End = DateTime.UtcNow.AddDays(56).AddHours(15),
        PriceAdult = 284, Type = "Plane", Seats = 196,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(12),
        End = DateTime.UtcNow.AddDays(90).AddHours(21),
        PriceAdult = 118, Type = "Train", Seats = 155,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(5),
        End = DateTime.UtcNow.AddDays(26).AddHours(9),
        PriceAdult = 108, Type = "Bus", Seats = 150,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(72).AddHours(18),
        End = DateTime.UtcNow.AddDays(73).AddHours(1),
        PriceAdult = 149, Type = "Plane", Seats = 125,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(21),
        End = DateTime.UtcNow.AddDays(77).AddHours(1),
        PriceAdult = 257, Type = "Train", Seats = 131,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(10),
        End = DateTime.UtcNow.AddDays(9).AddHours(20),
        PriceAdult = 156, Type = "Bus", Seats = 182,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(10),
        End = DateTime.UtcNow.AddDays(45).AddHours(21),
        PriceAdult = 75, Type = "Plane", Seats = 86,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(16),
        End = DateTime.UtcNow.AddDays(90).AddHours(18),
        PriceAdult = 107, Type = "Plane", Seats = 187,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(6),
        End = DateTime.UtcNow.AddDays(27).AddHours(12),
        PriceAdult = 271, Type = "Plane", Seats = 158,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(8),
        End = DateTime.UtcNow.AddDays(14).AddHours(15),
        PriceAdult = 167, Type = "Plane", Seats = 163,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(20),
        End = DateTime.UtcNow.AddDays(48).AddHours(24),
        PriceAdult = 91, Type = "Train", Seats = 51,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(18),
        End = DateTime.UtcNow.AddDays(81).AddHours(6),
        PriceAdult = 127, Type = "Bus", Seats = 172,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(21),
        End = DateTime.UtcNow.AddDays(79).AddHours(23),
        PriceAdult = 173, Type = "Plane", Seats = 94,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(15),
        End = DateTime.UtcNow.AddDays(15).AddHours(20),
        PriceAdult = 160, Type = "Train", Seats = 67,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(1),
        End = DateTime.UtcNow.AddDays(31).AddHours(10),
        PriceAdult = 79, Type = "Train", Seats = 128,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(4),
        End = DateTime.UtcNow.AddDays(42).AddHours(13),
        PriceAdult = 180, Type = "Bus", Seats = 178,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(16).AddHours(19),
        End = DateTime.UtcNow.AddDays(17).AddHours(3),
        PriceAdult = 227, Type = "Train", Seats = 108,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(18),
        End = DateTime.UtcNow.AddDays(18).AddHours(22),
        PriceAdult = 79, Type = "Bus", Seats = 181,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(5),
        End = DateTime.UtcNow.AddDays(87).AddHours(8),
        PriceAdult = 228, Type = "Plane", Seats = 187,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(17),
        End = DateTime.UtcNow.AddDays(28).AddHours(4),
        PriceAdult = 193, Type = "Train", Seats = 79,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(4),
        End = DateTime.UtcNow.AddDays(6).AddHours(12),
        PriceAdult = 84, Type = "Bus", Seats = 86,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(75).AddHours(7),
        End = DateTime.UtcNow.AddDays(75).AddHours(16),
        PriceAdult = 227, Type = "Train", Seats = 74,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(12),
        End = DateTime.UtcNow.AddDays(54).AddHours(20),
        PriceAdult = 60, Type = "Plane", Seats = 107,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(4),
        End = DateTime.UtcNow.AddDays(85).AddHours(6),
        PriceAdult = 131, Type = "Plane", Seats = 85,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(19),
        End = DateTime.UtcNow.AddDays(65).AddHours(24),
        PriceAdult = 152, Type = "Train", Seats = 134,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(46).AddHours(4),
        End = DateTime.UtcNow.AddDays(46).AddHours(10),
        PriceAdult = 166, Type = "Plane", Seats = 84,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(86).AddHours(15),
        End = DateTime.UtcNow.AddDays(86).AddHours(23),
        PriceAdult = 118, Type = "Plane", Seats = 154,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(19),
        End = DateTime.UtcNow.AddDays(84).AddHours(7),
        PriceAdult = 135, Type = "Train", Seats = 146,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(21),
        End = DateTime.UtcNow.AddDays(78).AddHours(1),
        PriceAdult = 199, Type = "Bus", Seats = 51,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(25).AddHours(5),
        End = DateTime.UtcNow.AddDays(25).AddHours(17),
        PriceAdult = 239, Type = "Bus", Seats = 129,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(2),
        End = DateTime.UtcNow.AddDays(66).AddHours(8),
        PriceAdult = 281, Type = "Train", Seats = 50,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(7).AddHours(22),
        End = DateTime.UtcNow.AddDays(8).AddHours(4),
        PriceAdult = 197, Type = "Train", Seats = 170,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(7),
        End = DateTime.UtcNow.AddDays(6).AddHours(13),
        PriceAdult = 127, Type = "Bus", Seats = 101,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(62).AddHours(2),
        End = DateTime.UtcNow.AddDays(62).AddHours(5),
        PriceAdult = 193, Type = "Bus", Seats = 115,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(9),
        End = DateTime.UtcNow.AddDays(29).AddHours(17),
        PriceAdult = 132, Type = "Bus", Seats = 191,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(52).AddHours(23),
        End = DateTime.UtcNow.AddDays(53).AddHours(1),
        PriceAdult = 130, Type = "Bus", Seats = 91,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(14),
        End = DateTime.UtcNow.AddDays(9).AddHours(2),
        PriceAdult = 101, Type = "Bus", Seats = 68,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(22),
        End = DateTime.UtcNow.AddDays(37).AddHours(6),
        PriceAdult = 104, Type = "Train", Seats = 50,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(9),
        End = DateTime.UtcNow.AddDays(13).AddHours(14),
        PriceAdult = 190, Type = "Bus", Seats = 52,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(23).AddHours(23),
        End = DateTime.UtcNow.AddDays(24).AddHours(6),
        PriceAdult = 95, Type = "Bus", Seats = 54,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(11),
        End = DateTime.UtcNow.AddDays(27).AddHours(14),
        PriceAdult = 97, Type = "Plane", Seats = 160,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(21),
        End = DateTime.UtcNow.AddDays(4).AddHours(23),
        PriceAdult = 51, Type = "Train", Seats = 98,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(14),
        End = DateTime.UtcNow.AddDays(82).AddHours(24),
        PriceAdult = 213, Type = "Plane", Seats = 102,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(70).AddHours(15),
        End = DateTime.UtcNow.AddDays(71).AddHours(2),
        PriceAdult = 59, Type = "Plane", Seats = 184,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(12),
        End = DateTime.UtcNow.AddDays(2).AddHours(16),
        PriceAdult = 126, Type = "Bus", Seats = 60,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(10),
        End = DateTime.UtcNow.AddDays(47).AddHours(15),
        PriceAdult = 252, Type = "Train", Seats = 184,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(18),
        End = DateTime.UtcNow.AddDays(87).AddHours(22),
        PriceAdult = 296, Type = "Train", Seats = 143,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(7),
        End = DateTime.UtcNow.AddDays(40).AddHours(9),
        PriceAdult = 160, Type = "Train", Seats = 126,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(6),
        End = DateTime.UtcNow.AddDays(56).AddHours(16),
        PriceAdult = 136, Type = "Bus", Seats = 97,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(13),
        End = DateTime.UtcNow.AddDays(5).AddHours(19),
        PriceAdult = 148, Type = "Bus", Seats = 151,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(3),
        End = DateTime.UtcNow.AddDays(82).AddHours(8),
        PriceAdult = 179, Type = "Bus", Seats = 109,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(0),
        End = DateTime.UtcNow.AddDays(29).AddHours(3),
        PriceAdult = 244, Type = "Train", Seats = 191,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(16),
        End = DateTime.UtcNow.AddDays(9).AddHours(3),
        PriceAdult = 114, Type = "Train", Seats = 125,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(69).AddHours(20),
        End = DateTime.UtcNow.AddDays(70).AddHours(3),
        PriceAdult = 264, Type = "Train", Seats = 107,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(2),
        End = DateTime.UtcNow.AddDays(18).AddHours(4),
        PriceAdult = 218, Type = "Plane", Seats = 185,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(20),
        End = DateTime.UtcNow.AddDays(5).AddHours(1),
        PriceAdult = 252, Type = "Train", Seats = 90,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(17),
        End = DateTime.UtcNow.AddDays(50).AddHours(2),
        PriceAdult = 189, Type = "Plane", Seats = 193,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(15),
        End = DateTime.UtcNow.AddDays(4).AddHours(22),
        PriceAdult = 127, Type = "Plane", Seats = 148,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(10).AddHours(4),
        End = DateTime.UtcNow.AddDays(10).AddHours(14),
        PriceAdult = 161, Type = "Plane", Seats = 139,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(9),
        End = DateTime.UtcNow.AddDays(42).AddHours(20),
        PriceAdult = 166, Type = "Plane", Seats = 173,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(14),
        End = DateTime.UtcNow.AddDays(16).AddHours(2),
        PriceAdult = 51, Type = "Plane", Seats = 152,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(12),
        End = DateTime.UtcNow.AddDays(53).AddHours(14),
        PriceAdult = 184, Type = "Train", Seats = 157,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(2),
        End = DateTime.UtcNow.AddDays(79).AddHours(12),
        PriceAdult = 225, Type = "Plane", Seats = 142,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(21),
        End = DateTime.UtcNow.AddDays(65).AddHours(24),
        PriceAdult = 135, Type = "Plane", Seats = 91,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(17),
        End = DateTime.UtcNow.AddDays(16).AddHours(2),
        PriceAdult = 247, Type = "Train", Seats = 164,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(72).AddHours(15),
        End = DateTime.UtcNow.AddDays(72).AddHours(21),
        PriceAdult = 298, Type = "Plane", Seats = 73,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(41).AddHours(5),
        End = DateTime.UtcNow.AddDays(41).AddHours(17),
        PriceAdult = 134, Type = "Bus", Seats = 95,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(72).AddHours(13),
        End = DateTime.UtcNow.AddDays(72).AddHours(22),
        PriceAdult = 209, Type = "Train", Seats = 169,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(8),
        End = DateTime.UtcNow.AddDays(53).AddHours(13),
        PriceAdult = 208, Type = "Train", Seats = 195,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(2),
        End = DateTime.UtcNow.AddDays(31).AddHours(13),
        PriceAdult = 104, Type = "Train", Seats = 164,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(13),
        End = DateTime.UtcNow.AddDays(31).AddHours(20),
        PriceAdult = 172, Type = "Bus", Seats = 158,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(7),
        End = DateTime.UtcNow.AddDays(43).AddHours(12),
        PriceAdult = 64, Type = "Plane", Seats = 156,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(6),
        End = DateTime.UtcNow.AddDays(22).AddHours(18),
        PriceAdult = 199, Type = "Plane", Seats = 89,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(16),
        End = DateTime.UtcNow.AddDays(85).AddHours(22),
        PriceAdult = 236, Type = "Plane", Seats = 175,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(11),
        End = DateTime.UtcNow.AddDays(13).AddHours(13),
        PriceAdult = 71, Type = "Train", Seats = 140,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(11),
        End = DateTime.UtcNow.AddDays(20).AddHours(20),
        PriceAdult = 276, Type = "Train", Seats = 124,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(10).AddHours(19),
        End = DateTime.UtcNow.AddDays(11).AddHours(3),
        PriceAdult = 273, Type = "Train", Seats = 117,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(14),
        End = DateTime.UtcNow.AddDays(15).AddHours(23),
        PriceAdult = 207, Type = "Bus", Seats = 83,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(14),
        End = DateTime.UtcNow.AddDays(59).AddHours(19),
        PriceAdult = 214, Type = "Bus", Seats = 50,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(7).AddHours(5),
        End = DateTime.UtcNow.AddDays(7).AddHours(14),
        PriceAdult = 176, Type = "Train", Seats = 95,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(67).AddHours(1),
        End = DateTime.UtcNow.AddDays(67).AddHours(5),
        PriceAdult = 134, Type = "Plane", Seats = 83,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(21),
        End = DateTime.UtcNow.AddDays(48).AddHours(23),
        PriceAdult = 108, Type = "Train", Seats = 185,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(86).AddHours(6),
        End = DateTime.UtcNow.AddDays(86).AddHours(9),
        PriceAdult = 140, Type = "Bus", Seats = 200,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(2),
        End = DateTime.UtcNow.AddDays(43).AddHours(13),
        PriceAdult = 249, Type = "Bus", Seats = 57,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(8),
        End = DateTime.UtcNow.AddDays(8).AddHours(15),
        PriceAdult = 72, Type = "Train", Seats = 200,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(69).AddHours(20),
        End = DateTime.UtcNow.AddDays(70).AddHours(1),
        PriceAdult = 125, Type = "Plane", Seats = 171,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(11),
        End = DateTime.UtcNow.AddDays(64).AddHours(15),
        PriceAdult = 110, Type = "Plane", Seats = 125,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(22),
        End = DateTime.UtcNow.AddDays(55).AddHours(3),
        PriceAdult = 126, Type = "Bus", Seats = 96,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(4),
        End = DateTime.UtcNow.AddDays(66).AddHours(15),
        PriceAdult = 231, Type = "Plane", Seats = 115,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(69).AddHours(15),
        End = DateTime.UtcNow.AddDays(69).AddHours(17),
        PriceAdult = 89, Type = "Plane", Seats = 133,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(13),
        End = DateTime.UtcNow.AddDays(82).AddHours(15),
        PriceAdult = 251, Type = "Plane", Seats = 122,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(9),
        End = DateTime.UtcNow.AddDays(79).AddHours(20),
        PriceAdult = 283, Type = "Bus", Seats = 79,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(10),
        End = DateTime.UtcNow.AddDays(37).AddHours(20),
        PriceAdult = 207, Type = "Train", Seats = 112,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(10),
        End = DateTime.UtcNow.AddDays(26).AddHours(19),
        PriceAdult = 245, Type = "Plane", Seats = 178,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(78).AddHours(2),
        End = DateTime.UtcNow.AddDays(78).AddHours(7),
        PriceAdult = 183, Type = "Bus", Seats = 170,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(9),
        End = DateTime.UtcNow.AddDays(56).AddHours(11),
        PriceAdult = 78, Type = "Train", Seats = 197,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(6),
        End = DateTime.UtcNow.AddDays(35).AddHours(10),
        PriceAdult = 67, Type = "Train", Seats = 108,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(8),
        End = DateTime.UtcNow.AddDays(30).AddHours(18),
        PriceAdult = 167, Type = "Plane", Seats = 155,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(17),
        End = DateTime.UtcNow.AddDays(80).AddHours(1),
        PriceAdult = 90, Type = "Train", Seats = 97,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(16).AddHours(18),
        End = DateTime.UtcNow.AddDays(17).AddHours(2),
        PriceAdult = 297, Type = "Bus", Seats = 80,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(13),
        End = DateTime.UtcNow.AddDays(54).AddHours(17),
        PriceAdult = 105, Type = "Bus", Seats = 200,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(5),
        End = DateTime.UtcNow.AddDays(22).AddHours(12),
        PriceAdult = 260, Type = "Plane", Seats = 179,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(16),
        End = DateTime.UtcNow.AddDays(89).AddHours(22),
        PriceAdult = 280, Type = "Train", Seats = 59,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(10),
        End = DateTime.UtcNow.AddDays(40).AddHours(21),
        PriceAdult = 199, Type = "Plane", Seats = 81,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(14),
        End = DateTime.UtcNow.AddDays(87).AddHours(16),
        PriceAdult = 276, Type = "Bus", Seats = 162,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(14),
        End = DateTime.UtcNow.AddDays(84).AddHours(17),
        PriceAdult = 162, Type = "Bus", Seats = 145,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(11).AddHours(7),
        End = DateTime.UtcNow.AddDays(11).AddHours(9),
        PriceAdult = 257, Type = "Train", Seats = 90,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(33).AddHours(5),
        End = DateTime.UtcNow.AddDays(33).AddHours(9),
        PriceAdult = 203, Type = "Train", Seats = 138,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(2),
        End = DateTime.UtcNow.AddDays(81).AddHours(14),
        PriceAdult = 265, Type = "Train", Seats = 131,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(1),
        End = DateTime.UtcNow.AddDays(22).AddHours(9),
        PriceAdult = 254, Type = "Train", Seats = 106,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(4),
        End = DateTime.UtcNow.AddDays(53).AddHours(8),
        PriceAdult = 108, Type = "Bus", Seats = 177,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(67).AddHours(16),
        End = DateTime.UtcNow.AddDays(67).AddHours(18),
        PriceAdult = 175, Type = "Bus", Seats = 172,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(21),
        End = DateTime.UtcNow.AddDays(10).AddHours(7),
        PriceAdult = 158, Type = "Bus", Seats = 175,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(15),
        End = DateTime.UtcNow.AddDays(27).AddHours(20),
        PriceAdult = 135, Type = "Plane", Seats = 68,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(16),
        End = DateTime.UtcNow.AddDays(14).AddHours(3),
        PriceAdult = 54, Type = "Bus", Seats = 100,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(20),
        End = DateTime.UtcNow.AddDays(37).AddHours(2),
        PriceAdult = 118, Type = "Bus", Seats = 82,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(33).AddHours(22),
        End = DateTime.UtcNow.AddDays(34).AddHours(2),
        PriceAdult = 242, Type = "Bus", Seats = 172,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(14),
        End = DateTime.UtcNow.AddDays(55).AddHours(23),
        PriceAdult = 96, Type = "Train", Seats = 116,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(8),
        End = DateTime.UtcNow.AddDays(43).AddHours(16),
        PriceAdult = 108, Type = "Plane", Seats = 137,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(62).AddHours(11),
        End = DateTime.UtcNow.AddDays(62).AddHours(14),
        PriceAdult = 101, Type = "Plane", Seats = 161,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(7),
        End = DateTime.UtcNow.AddDays(35).AddHours(10),
        PriceAdult = 204, Type = "Train", Seats = 61,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(52).AddHours(4),
        End = DateTime.UtcNow.AddDays(52).AddHours(16),
        PriceAdult = 55, Type = "Bus", Seats = 141,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(3).AddHours(12),
        End = DateTime.UtcNow.AddDays(3).AddHours(21),
        PriceAdult = 78, Type = "Bus", Seats = 156,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(10),
        End = DateTime.UtcNow.AddDays(77).AddHours(18),
        PriceAdult = 223, Type = "Train", Seats = 138,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(10),
        End = DateTime.UtcNow.AddDays(83).AddHours(22),
        PriceAdult = 123, Type = "Bus", Seats = 164,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(0),
        End = DateTime.UtcNow.AddDays(84).AddHours(2),
        PriceAdult = 169, Type = "Plane", Seats = 187,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(1).AddHours(22),
        End = DateTime.UtcNow.AddDays(2).AddHours(4),
        PriceAdult = 250, Type = "Train", Seats = 195,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(22),
        End = DateTime.UtcNow.AddDays(22).AddHours(6),
        PriceAdult = 194, Type = "Train", Seats = 134,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(9),
        End = DateTime.UtcNow.AddDays(38).AddHours(17),
        PriceAdult = 93, Type = "Bus", Seats = 127,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(3),
        End = DateTime.UtcNow.AddDays(56).AddHours(5),
        PriceAdult = 259, Type = "Bus", Seats = 152,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(41).AddHours(14),
        End = DateTime.UtcNow.AddDays(41).AddHours(23),
        PriceAdult = 294, Type = "Train", Seats = 163,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(6),
        End = DateTime.UtcNow.AddDays(8).AddHours(12),
        PriceAdult = 275, Type = "Train", Seats = 142,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(17),
        End = DateTime.UtcNow.AddDays(77).AddHours(5),
        PriceAdult = 123, Type = "Plane", Seats = 105,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(18),
        End = DateTime.UtcNow.AddDays(15).AddHours(21),
        PriceAdult = 83, Type = "Train", Seats = 194,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(16),
        End = DateTime.UtcNow.AddDays(17).AddHours(20),
        PriceAdult = 101, Type = "Plane", Seats = 180,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(22),
        End = DateTime.UtcNow.AddDays(38).AddHours(6),
        PriceAdult = 254, Type = "Train", Seats = 182,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(15),
        End = DateTime.UtcNow.AddDays(83).AddHours(18),
        PriceAdult = 179, Type = "Plane", Seats = 150,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(12),
        End = DateTime.UtcNow.AddDays(8).AddHours(14),
        PriceAdult = 151, Type = "Bus", Seats = 57,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(1),
        End = DateTime.UtcNow.AddDays(6).AddHours(11),
        PriceAdult = 151, Type = "Train", Seats = 200,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(0),
        End = DateTime.UtcNow.AddDays(12).AddHours(3),
        PriceAdult = 101, Type = "Train", Seats = 184,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(32).AddHours(22),
        End = DateTime.UtcNow.AddDays(33).AddHours(2),
        PriceAdult = 259, Type = "Train", Seats = 166,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(8),
        End = DateTime.UtcNow.AddDays(54).AddHours(14),
        PriceAdult = 212, Type = "Plane", Seats = 106,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(7),
        End = DateTime.UtcNow.AddDays(40).AddHours(15),
        PriceAdult = 153, Type = "Bus", Seats = 147,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(21),
        End = DateTime.UtcNow.AddDays(31).AddHours(9),
        PriceAdult = 157, Type = "Bus", Seats = 197,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(15),
        End = DateTime.UtcNow.AddDays(90).AddHours(24),
        PriceAdult = 140, Type = "Bus", Seats = 71,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(5),
        End = DateTime.UtcNow.AddDays(29).AddHours(12),
        PriceAdult = 113, Type = "Train", Seats = 189,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(41).AddHours(16),
        End = DateTime.UtcNow.AddDays(41).AddHours(23),
        PriceAdult = 183, Type = "Train", Seats = 107,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(5),
        End = DateTime.UtcNow.AddDays(13).AddHours(13),
        PriceAdult = 131, Type = "Bus", Seats = 129,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(13),
        End = DateTime.UtcNow.AddDays(45).AddHours(19),
        PriceAdult = 278, Type = "Plane", Seats = 181,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(10),
        End = DateTime.UtcNow.AddDays(42).AddHours(16),
        PriceAdult = 100, Type = "Plane", Seats = 69,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(15),
        End = DateTime.UtcNow.AddDays(82).AddHours(23),
        PriceAdult = 196, Type = "Plane", Seats = 143,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(0),
        End = DateTime.UtcNow.AddDays(37).AddHours(5),
        PriceAdult = 51, Type = "Bus", Seats = 131,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(10),
        End = DateTime.UtcNow.AddDays(14).AddHours(12),
        PriceAdult = 256, Type = "Plane", Seats = 166,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(16).AddHours(8),
        End = DateTime.UtcNow.AddDays(16).AddHours(10),
        PriceAdult = 77, Type = "Train", Seats = 172,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(4),
        End = DateTime.UtcNow.AddDays(87).AddHours(9),
        PriceAdult = 141, Type = "Plane", Seats = 146,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(19).AddHours(16),
        End = DateTime.UtcNow.AddDays(20).AddHours(1),
        PriceAdult = 123, Type = "Plane", Seats = 126,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(7),
        End = DateTime.UtcNow.AddDays(6).AddHours(17),
        PriceAdult = 179, Type = "Bus", Seats = 132,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(17),
        End = DateTime.UtcNow.AddDays(64).AddHours(4),
        PriceAdult = 270, Type = "Bus", Seats = 81,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(74).AddHours(13),
        End = DateTime.UtcNow.AddDays(75).AddHours(1),
        PriceAdult = 109, Type = "Bus", Seats = 53,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(7),
        End = DateTime.UtcNow.AddDays(51).AddHours(18),
        PriceAdult = 246, Type = "Train", Seats = 59,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(12),
        End = DateTime.UtcNow.AddDays(65).AddHours(24),
        PriceAdult = 141, Type = "Train", Seats = 195,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(58).AddHours(12),
        End = DateTime.UtcNow.AddDays(58).AddHours(17),
        PriceAdult = 51, Type = "Plane", Seats = 140,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(19),
        End = DateTime.UtcNow.AddDays(31).AddHours(5),
        PriceAdult = 88, Type = "Plane", Seats = 151,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(7),
        End = DateTime.UtcNow.AddDays(59).AddHours(9),
        PriceAdult = 54, Type = "Train", Seats = 102,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(11),
        End = DateTime.UtcNow.AddDays(71).AddHours(19),
        PriceAdult = 237, Type = "Train", Seats = 184,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(12),
        End = DateTime.UtcNow.AddDays(9).AddHours(15),
        PriceAdult = 56, Type = "Plane", Seats = 135,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(74).AddHours(22),
        End = DateTime.UtcNow.AddDays(75).AddHours(7),
        PriceAdult = 275, Type = "Train", Seats = 164,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(88).AddHours(22),
        End = DateTime.UtcNow.AddDays(89).AddHours(9),
        PriceAdult = 137, Type = "Train", Seats = 196,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(11),
        End = DateTime.UtcNow.AddDays(80).AddHours(13),
        PriceAdult = 276, Type = "Train", Seats = 88,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(4),
        End = DateTime.UtcNow.AddDays(6).AddHours(8),
        PriceAdult = 249, Type = "Bus", Seats = 179,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(4),
        End = DateTime.UtcNow.AddDays(71).AddHours(15),
        PriceAdult = 254, Type = "Bus", Seats = 116,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(24).AddHours(4),
        End = DateTime.UtcNow.AddDays(24).AddHours(13),
        PriceAdult = 164, Type = "Train", Seats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(12),
        End = DateTime.UtcNow.AddDays(89).AddHours(22),
        PriceAdult = 59, Type = "Train", Seats = 191,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(18),
        End = DateTime.UtcNow.AddDays(2).AddHours(23),
        PriceAdult = 275, Type = "Bus", Seats = 166,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(19),
        End = DateTime.UtcNow.AddDays(20).AddHours(22),
        PriceAdult = 190, Type = "Train", Seats = 126,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(6),
        End = DateTime.UtcNow.AddDays(84).AddHours(13),
        PriceAdult = 127, Type = "Bus", Seats = 170,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(14),
        End = DateTime.UtcNow.AddDays(51).AddHours(20),
        PriceAdult = 192, Type = "Train", Seats = 191,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(3),
        End = DateTime.UtcNow.AddDays(22).AddHours(7),
        PriceAdult = 194, Type = "Train", Seats = 68,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(4),
        End = DateTime.UtcNow.AddDays(76).AddHours(7),
        PriceAdult = 227, Type = "Train", Seats = 189,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(5),
        End = DateTime.UtcNow.AddDays(37).AddHours(9),
        PriceAdult = 132, Type = "Bus", Seats = 173,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(5),
        End = DateTime.UtcNow.AddDays(22).AddHours(13),
        PriceAdult = 90, Type = "Plane", Seats = 94,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(73).AddHours(21),
        End = DateTime.UtcNow.AddDays(74).AddHours(8),
        PriceAdult = 291, Type = "Train", Seats = 69,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(6),
        End = DateTime.UtcNow.AddDays(38).AddHours(15),
        PriceAdult = 256, Type = "Plane", Seats = 157,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(15),
        End = DateTime.UtcNow.AddDays(80).AddHours(17),
        PriceAdult = 153, Type = "Plane", Seats = 130,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(7).AddHours(4),
        End = DateTime.UtcNow.AddDays(7).AddHours(14),
        PriceAdult = 123, Type = "Train", Seats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(8),
        End = DateTime.UtcNow.AddDays(65).AddHours(19),
        PriceAdult = 81, Type = "Plane", Seats = 200,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(15),
        End = DateTime.UtcNow.AddDays(76).AddHours(18),
        PriceAdult = 274, Type = "Bus", Seats = 64,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(68).AddHours(13),
        End = DateTime.UtcNow.AddDays(68).AddHours(19),
        PriceAdult = 118, Type = "Plane", Seats = 79,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(10),
        End = DateTime.UtcNow.AddDays(29).AddHours(12),
        PriceAdult = 188, Type = "Plane", Seats = 171,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(0),
        End = DateTime.UtcNow.AddDays(61).AddHours(6),
        PriceAdult = 126, Type = "Train", Seats = 58,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(18),
        End = DateTime.UtcNow.AddDays(21).AddHours(22),
        PriceAdult = 211, Type = "Train", Seats = 165,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(16),
        End = DateTime.UtcNow.AddDays(71).AddHours(19),
        PriceAdult = 65, Type = "Bus", Seats = 184,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(23),
        End = DateTime.UtcNow.AddDays(44).AddHours(2),
        PriceAdult = 99, Type = "Plane", Seats = 153,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(20),
        End = DateTime.UtcNow.AddDays(14).AddHours(22),
        PriceAdult = 159, Type = "Bus", Seats = 113,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(58).AddHours(11),
        End = DateTime.UtcNow.AddDays(58).AddHours(14),
        PriceAdult = 129, Type = "Plane", Seats = 144,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(70).AddHours(13),
        End = DateTime.UtcNow.AddDays(70).AddHours(16),
        PriceAdult = 118, Type = "Plane", Seats = 58,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(12),
        End = DateTime.UtcNow.AddDays(66).AddHours(16),
        PriceAdult = 57, Type = "Plane", Seats = 181,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(16),
        End = DateTime.UtcNow.AddDays(38).AddHours(21),
        PriceAdult = 263, Type = "Bus", Seats = 180,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(23).AddHours(17),
        End = DateTime.UtcNow.AddDays(23).AddHours(22),
        PriceAdult = 103, Type = "Plane", Seats = 158,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(9),
        End = DateTime.UtcNow.AddDays(42).AddHours(16),
        PriceAdult = 169, Type = "Train", Seats = 125,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(12),
        End = DateTime.UtcNow.AddDays(53).AddHours(22),
        PriceAdult = 158, Type = "Plane", Seats = 57,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(3),
        End = DateTime.UtcNow.AddDays(38).AddHours(13),
        PriceAdult = 236, Type = "Train", Seats = 140,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(7),
        End = DateTime.UtcNow.AddDays(53).AddHours(12),
        PriceAdult = 145, Type = "Bus", Seats = 161,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(5),
        End = DateTime.UtcNow.AddDays(80).AddHours(10),
        PriceAdult = 131, Type = "Plane", Seats = 148,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(16),
        End = DateTime.UtcNow.AddDays(37).AddHours(4),
        PriceAdult = 228, Type = "Train", Seats = 131,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(8),
        End = DateTime.UtcNow.AddDays(15).AddHours(16),
        PriceAdult = 215, Type = "Bus", Seats = 92,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(10),
        End = DateTime.UtcNow.AddDays(45).AddHours(13),
        PriceAdult = 55, Type = "Train", Seats = 191,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(21),
        End = DateTime.UtcNow.AddDays(18).AddHours(1),
        PriceAdult = 242, Type = "Bus", Seats = 171,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(17),
        End = DateTime.UtcNow.AddDays(89).AddHours(24),
        PriceAdult = 151, Type = "Plane", Seats = 155,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(0),
        End = DateTime.UtcNow.AddDays(47).AddHours(4),
        PriceAdult = 244, Type = "Bus", Seats = 133,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(13),
        End = DateTime.UtcNow.AddDays(54).AddHours(22),
        PriceAdult = 243, Type = "Train", Seats = 50,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(23),
        End = DateTime.UtcNow.AddDays(7).AddHours(5),
        PriceAdult = 171, Type = "Plane", Seats = 99,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(27).AddHours(15),
        End = DateTime.UtcNow.AddDays(28).AddHours(2),
        PriceAdult = 72, Type = "Plane", Seats = 69,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(23).AddHours(4),
        End = DateTime.UtcNow.AddDays(23).AddHours(8),
        PriceAdult = 94, Type = "Train", Seats = 104,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(3),
        End = DateTime.UtcNow.AddDays(18).AddHours(13),
        PriceAdult = 222, Type = "Bus", Seats = 138,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(21),
        End = DateTime.UtcNow.AddDays(82).AddHours(2),
        PriceAdult = 150, Type = "Train", Seats = 71,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(10),
        End = DateTime.UtcNow.AddDays(44).AddHours(22),
        PriceAdult = 187, Type = "Plane", Seats = 99,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(12),
        End = DateTime.UtcNow.AddDays(63).AddHours(22),
        PriceAdult = 219, Type = "Train", Seats = 126,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(21),
        End = DateTime.UtcNow.AddDays(88).AddHours(8),
        PriceAdult = 289, Type = "Bus", Seats = 98,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(3),
        End = DateTime.UtcNow.AddDays(79).AddHours(12),
        PriceAdult = 238, Type = "Bus", Seats = 181,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(78).AddHours(4),
        End = DateTime.UtcNow.AddDays(78).AddHours(9),
        PriceAdult = 135, Type = "Train", Seats = 129,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(1),
        End = DateTime.UtcNow.AddDays(84).AddHours(7),
        PriceAdult = 78, Type = "Plane", Seats = 145,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(23),
        End = DateTime.UtcNow.AddDays(9).AddHours(10),
        PriceAdult = 195, Type = "Plane", Seats = 191,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(19),
        End = DateTime.UtcNow.AddDays(23).AddHours(2),
        PriceAdult = 147, Type = "Plane", Seats = 151,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(4),
        End = DateTime.UtcNow.AddDays(12).AddHours(15),
        PriceAdult = 119, Type = "Train", Seats = 65,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(0),
        End = DateTime.UtcNow.AddDays(82).AddHours(5),
        PriceAdult = 215, Type = "Plane", Seats = 74,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(20),
        End = DateTime.UtcNow.AddDays(64).AddHours(24),
        PriceAdult = 279, Type = "Plane", Seats = 144,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(4),
        End = DateTime.UtcNow.AddDays(47).AddHours(11),
        PriceAdult = 196, Type = "Bus", Seats = 86,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(18),
        End = DateTime.UtcNow.AddDays(59).AddHours(21),
        PriceAdult = 187, Type = "Bus", Seats = 140,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(1),
        End = DateTime.UtcNow.AddDays(76).AddHours(13),
        PriceAdult = 202, Type = "Bus", Seats = 102,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(11),
        End = DateTime.UtcNow.AddDays(44).AddHours(22),
        PriceAdult = 271, Type = "Plane", Seats = 116,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(11),
        End = DateTime.UtcNow.AddDays(37).AddHours(13),
        PriceAdult = 125, Type = "Train", Seats = 183,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(17),
        End = DateTime.UtcNow.AddDays(21).AddHours(20),
        PriceAdult = 190, Type = "Bus", Seats = 142,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(25).AddHours(12),
        End = DateTime.UtcNow.AddDays(25).AddHours(18),
        PriceAdult = 264, Type = "Bus", Seats = 189,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(5),
        End = DateTime.UtcNow.AddDays(8).AddHours(10),
        PriceAdult = 169, Type = "Bus", Seats = 81,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(7),
        End = DateTime.UtcNow.AddDays(43).AddHours(15),
        PriceAdult = 300, Type = "Plane", Seats = 115,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(10).AddHours(11),
        End = DateTime.UtcNow.AddDays(10).AddHours(15),
        PriceAdult = 249, Type = "Train", Seats = 155,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(10),
        End = DateTime.UtcNow.AddDays(53).AddHours(22),
        PriceAdult = 105, Type = "Plane", Seats = 61,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(8),
        End = DateTime.UtcNow.AddDays(85).AddHours(14),
        PriceAdult = 242, Type = "Bus", Seats = 62,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(7),
        End = DateTime.UtcNow.AddDays(45).AddHours(11),
        PriceAdult = 146, Type = "Bus", Seats = 74,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(10),
        End = DateTime.UtcNow.AddDays(44).AddHours(12),
        PriceAdult = 136, Type = "Plane", Seats = 147,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(19).AddHours(10),
        End = DateTime.UtcNow.AddDays(19).AddHours(17),
        PriceAdult = 168, Type = "Bus", Seats = 111,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(4),
        End = DateTime.UtcNow.AddDays(37).AddHours(6),
        PriceAdult = 140, Type = "Train", Seats = 98,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(11),
        End = DateTime.UtcNow.AddDays(85).AddHours(23),
        PriceAdult = 198, Type = "Plane", Seats = 84,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(52).AddHours(4),
        End = DateTime.UtcNow.AddDays(52).AddHours(6),
        PriceAdult = 286, Type = "Plane", Seats = 136,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(17),
        End = DateTime.UtcNow.AddDays(87).AddHours(20),
        PriceAdult = 87, Type = "Plane", Seats = 88,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(5),
        End = DateTime.UtcNow.AddDays(14).AddHours(10),
        PriceAdult = 185, Type = "Bus", Seats = 145,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(22),
        End = DateTime.UtcNow.AddDays(81).AddHours(1),
        PriceAdult = 244, Type = "Train", Seats = 72,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(19),
        End = DateTime.UtcNow.AddDays(2).AddHours(21),
        PriceAdult = 291, Type = "Train", Seats = 51,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(5),
        End = DateTime.UtcNow.AddDays(42).AddHours(9),
        PriceAdult = 191, Type = "Plane", Seats = 163,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(14),
        End = DateTime.UtcNow.AddDays(15).AddHours(21),
        PriceAdult = 268, Type = "Plane", Seats = 67,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(13),
        End = DateTime.UtcNow.AddDays(81).AddHours(16),
        PriceAdult = 204, Type = "Bus", Seats = 108,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(16),
        End = DateTime.UtcNow.AddDays(6).AddHours(1),
        PriceAdult = 197, Type = "Bus", Seats = 157,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(14),
        End = DateTime.UtcNow.AddDays(87).AddHours(19),
        PriceAdult = 89, Type = "Train", Seats = 146,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(24).AddHours(20),
        End = DateTime.UtcNow.AddDays(25).AddHours(3),
        PriceAdult = 296, Type = "Plane", Seats = 174,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(10),
        End = DateTime.UtcNow.AddDays(47).AddHours(19),
        PriceAdult = 73, Type = "Train", Seats = 149,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(58).AddHours(18),
        End = DateTime.UtcNow.AddDays(59).AddHours(6),
        PriceAdult = 244, Type = "Train", Seats = 189,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(23),
        End = DateTime.UtcNow.AddDays(14).AddHours(8),
        PriceAdult = 139, Type = "Bus", Seats = 156,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(73).AddHours(12),
        End = DateTime.UtcNow.AddDays(73).AddHours(24),
        PriceAdult = 96, Type = "Plane", Seats = 67,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(9),
        End = DateTime.UtcNow.AddDays(85).AddHours(11),
        PriceAdult = 275, Type = "Bus", Seats = 56,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(57).AddHours(20),
        End = DateTime.UtcNow.AddDays(58).AddHours(5),
        PriceAdult = 201, Type = "Train", Seats = 194,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(16),
        End = DateTime.UtcNow.AddDays(42).AddHours(19),
        PriceAdult = 115, Type = "Bus", Seats = 62,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(13),
        End = DateTime.UtcNow.AddDays(80).AddHours(17),
        PriceAdult = 123, Type = "Bus", Seats = 77,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(18),
        End = DateTime.UtcNow.AddDays(77).AddHours(20),
        PriceAdult = 223, Type = "Plane", Seats = 114,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(20),
        End = DateTime.UtcNow.AddDays(66).AddHours(24),
        PriceAdult = 286, Type = "Bus", Seats = 113,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(6),
        End = DateTime.UtcNow.AddDays(17).AddHours(13),
        PriceAdult = 75, Type = "Plane", Seats = 57,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(5),
        End = DateTime.UtcNow.AddDays(64).AddHours(12),
        PriceAdult = 274, Type = "Train", Seats = 163,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(58).AddHours(10),
        End = DateTime.UtcNow.AddDays(58).AddHours(17),
        PriceAdult = 232, Type = "Bus", Seats = 176,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(13),
        End = DateTime.UtcNow.AddDays(66).AddHours(20),
        PriceAdult = 268, Type = "Plane", Seats = 168,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(1),
        End = DateTime.UtcNow.AddDays(66).AddHours(13),
        PriceAdult = 109, Type = "Plane", Seats = 196,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(11),
        End = DateTime.UtcNow.AddDays(12).AddHours(14),
        PriceAdult = 259, Type = "Train", Seats = 199,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(0),
        End = DateTime.UtcNow.AddDays(85).AddHours(10),
        PriceAdult = 166, Type = "Train", Seats = 192,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(20),
        End = DateTime.UtcNow.AddDays(81).AddHours(4),
        PriceAdult = 297, Type = "Train", Seats = 160,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(1),
        End = DateTime.UtcNow.AddDays(48).AddHours(9),
        PriceAdult = 262, Type = "Bus", Seats = 56,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(12),
        End = DateTime.UtcNow.AddDays(76).AddHours(23),
        PriceAdult = 286, Type = "Bus", Seats = 136,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(3),
        End = DateTime.UtcNow.AddDays(49).AddHours(15),
        PriceAdult = 185, Type = "Train", Seats = 160,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(13),
        End = DateTime.UtcNow.AddDays(76).AddHours(19),
        PriceAdult = 85, Type = "Bus", Seats = 171,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(23),
        End = DateTime.UtcNow.AddDays(49).AddHours(7),
        PriceAdult = 151, Type = "Plane", Seats = 136,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(13),
        End = DateTime.UtcNow.AddDays(29).AddHours(17),
        PriceAdult = 54, Type = "Train", Seats = 130,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(21),
        End = DateTime.UtcNow.AddDays(67).AddHours(9),
        PriceAdult = 239, Type = "Plane", Seats = 140,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(6),
        End = DateTime.UtcNow.AddDays(29).AddHours(11),
        PriceAdult = 83, Type = "Plane", Seats = 183,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(23),
        End = DateTime.UtcNow.AddDays(22).AddHours(8),
        PriceAdult = 254, Type = "Plane", Seats = 175,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(9),
        End = DateTime.UtcNow.AddDays(12).AddHours(11),
        PriceAdult = 241, Type = "Train", Seats = 66,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(68).AddHours(14),
        End = DateTime.UtcNow.AddDays(68).AddHours(22),
        PriceAdult = 88, Type = "Train", Seats = 193,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(0),
        End = DateTime.UtcNow.AddDays(51).AddHours(12),
        PriceAdult = 108, Type = "Plane", Seats = 82,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(1),
        End = DateTime.UtcNow.AddDays(29).AddHours(4),
        PriceAdult = 262, Type = "Bus", Seats = 178,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(7),
        End = DateTime.UtcNow.AddDays(30).AddHours(14),
        PriceAdult = 132, Type = "Bus", Seats = 198,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(11).AddHours(0),
        End = DateTime.UtcNow.AddDays(11).AddHours(8),
        PriceAdult = 192, Type = "Bus", Seats = 65,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(8),
        End = DateTime.UtcNow.AddDays(84).AddHours(10),
        PriceAdult = 251, Type = "Plane", Seats = 123,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(18),
        End = DateTime.UtcNow.AddDays(80).AddHours(24),
        PriceAdult = 160, Type = "Train", Seats = 67,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(2),
        End = DateTime.UtcNow.AddDays(9).AddHours(14),
        PriceAdult = 164, Type = "Train", Seats = 184,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(13),
        End = DateTime.UtcNow.AddDays(54).AddHours(17),
        PriceAdult = 112, Type = "Bus", Seats = 166,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(11),
        End = DateTime.UtcNow.AddDays(51).AddHours(16),
        PriceAdult = 233, Type = "Train", Seats = 55,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(7),
        End = DateTime.UtcNow.AddDays(20).AddHours(14),
        PriceAdult = 125, Type = "Train", Seats = 95,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(23),
        End = DateTime.UtcNow.AddDays(85).AddHours(4),
        PriceAdult = 179, Type = "Bus", Seats = 152,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(0),
        End = DateTime.UtcNow.AddDays(61).AddHours(3),
        PriceAdult = 117, Type = "Plane", Seats = 67,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(14),
        End = DateTime.UtcNow.AddDays(85).AddHours(16),
        PriceAdult = 195, Type = "Train", Seats = 56,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(0),
        End = DateTime.UtcNow.AddDays(30).AddHours(4),
        PriceAdult = 191, Type = "Plane", Seats = 177,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(12).AddHours(17),
        End = DateTime.UtcNow.AddDays(12).AddHours(24),
        PriceAdult = 277, Type = "Train", Seats = 110,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(60).AddHours(16),
        End = DateTime.UtcNow.AddDays(61).AddHours(4),
        PriceAdult = 197, Type = "Train", Seats = 149,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(70).AddHours(6),
        End = DateTime.UtcNow.AddDays(70).AddHours(11),
        PriceAdult = 104, Type = "Train", Seats = 187,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(22),
        End = DateTime.UtcNow.AddDays(50).AddHours(1),
        PriceAdult = 132, Type = "Plane", Seats = 72,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(22),
        End = DateTime.UtcNow.AddDays(55).AddHours(24),
        PriceAdult = 56, Type = "Plane", Seats = 194,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(84).AddHours(4),
        End = DateTime.UtcNow.AddDays(84).AddHours(16),
        PriceAdult = 94, Type = "Bus", Seats = 194,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(18),
        End = DateTime.UtcNow.AddDays(6).AddHours(21),
        PriceAdult = 166, Type = "Plane", Seats = 195,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(19),
        End = DateTime.UtcNow.AddDays(59).AddHours(23),
        PriceAdult = 177, Type = "Bus", Seats = 114,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(32).AddHours(10),
        End = DateTime.UtcNow.AddDays(32).AddHours(15),
        PriceAdult = 124, Type = "Plane", Seats = 113,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(19),
        End = DateTime.UtcNow.AddDays(27).AddHours(1),
        PriceAdult = 212, Type = "Train", Seats = 178,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(23),
        End = DateTime.UtcNow.AddDays(30).AddHours(4),
        PriceAdult = 68, Type = "Bus", Seats = 171,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(6).AddHours(23),
        End = DateTime.UtcNow.AddDays(7).AddHours(11),
        PriceAdult = 59, Type = "Bus", Seats = 144,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(7),
        End = DateTime.UtcNow.AddDays(13).AddHours(15),
        PriceAdult = 92, Type = "Bus", Seats = 67,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(12),
        End = DateTime.UtcNow.AddDays(77).AddHours(19),
        PriceAdult = 99, Type = "Train", Seats = 180,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(1),
        End = DateTime.UtcNow.AddDays(17).AddHours(9),
        PriceAdult = 271, Type = "Plane", Seats = 197,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(3),
        End = DateTime.UtcNow.AddDays(48).AddHours(9),
        PriceAdult = 149, Type = "Bus", Seats = 157,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(22),
        End = DateTime.UtcNow.AddDays(31).AddHours(5),
        PriceAdult = 157, Type = "Plane", Seats = 179,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(3),
        End = DateTime.UtcNow.AddDays(4).AddHours(15),
        PriceAdult = 194, Type = "Plane", Seats = 58,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(3),
        End = DateTime.UtcNow.AddDays(38).AddHours(5),
        PriceAdult = 88, Type = "Plane", Seats = 198,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(68).AddHours(16),
        End = DateTime.UtcNow.AddDays(68).AddHours(21),
        PriceAdult = 269, Type = "Plane", Seats = 105,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(74).AddHours(22),
        End = DateTime.UtcNow.AddDays(75).AddHours(10),
        PriceAdult = 158, Type = "Bus", Seats = 87,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(78).AddHours(3),
        End = DateTime.UtcNow.AddDays(78).AddHours(7),
        PriceAdult = 197, Type = "Plane", Seats = 105,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(75).AddHours(15),
        End = DateTime.UtcNow.AddDays(76).AddHours(1),
        PriceAdult = 181, Type = "Plane", Seats = 120,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(22),
        End = DateTime.UtcNow.AddDays(54).AddHours(24),
        PriceAdult = 166, Type = "Bus", Seats = 131,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(1),
        End = DateTime.UtcNow.AddDays(71).AddHours(11),
        PriceAdult = 287, Type = "Train", Seats = 53,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(21),
        End = DateTime.UtcNow.AddDays(66).AddHours(24),
        PriceAdult = 124, Type = "Train", Seats = 165,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(28).AddHours(17),
        End = DateTime.UtcNow.AddDays(28).AddHours(24),
        PriceAdult = 51, Type = "Plane", Seats = 132,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(8),
        End = DateTime.UtcNow.AddDays(4).AddHours(20),
        PriceAdult = 106, Type = "Bus", Seats = 155,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(3).AddHours(6),
        End = DateTime.UtcNow.AddDays(3).AddHours(15),
        PriceAdult = 106, Type = "Train", Seats = 149,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(15),
        End = DateTime.UtcNow.AddDays(79).AddHours(21),
        PriceAdult = 67, Type = "Bus", Seats = 77,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(5),
        End = DateTime.UtcNow.AddDays(42).AddHours(11),
        PriceAdult = 234, Type = "Train", Seats = 166,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(20),
        End = DateTime.UtcNow.AddDays(46).AddHours(2),
        PriceAdult = 255, Type = "Plane", Seats = 126,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(6),
        End = DateTime.UtcNow.AddDays(76).AddHours(10),
        PriceAdult = 134, Type = "Train", Seats = 131,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(23),
        End = DateTime.UtcNow.AddDays(62).AddHours(3),
        PriceAdult = 289, Type = "Bus", Seats = 127,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(57).AddHours(9),
        End = DateTime.UtcNow.AddDays(57).AddHours(12),
        PriceAdult = 62, Type = "Plane", Seats = 181,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(2),
        End = DateTime.UtcNow.AddDays(18).AddHours(5),
        PriceAdult = 196, Type = "Train", Seats = 55,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(1),
        End = DateTime.UtcNow.AddDays(81).AddHours(4),
        PriceAdult = 251, Type = "Plane", Seats = 141,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(3),
        End = DateTime.UtcNow.AddDays(4).AddHours(12),
        PriceAdult = 56, Type = "Plane", Seats = 126,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(5),
        End = DateTime.UtcNow.AddDays(82).AddHours(13),
        PriceAdult = 195, Type = "Bus", Seats = 171,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(45).AddHours(6),
        End = DateTime.UtcNow.AddDays(45).AddHours(8),
        PriceAdult = 116, Type = "Bus", Seats = 170,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(6),
        End = DateTime.UtcNow.AddDays(2).AddHours(17),
        PriceAdult = 297, Type = "Bus", Seats = 168,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(80).AddHours(10),
        End = DateTime.UtcNow.AddDays(80).AddHours(21),
        PriceAdult = 270, Type = "Train", Seats = 65,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(22),
        End = DateTime.UtcNow.AddDays(82).AddHours(2),
        PriceAdult = 79, Type = "Train", Seats = 167,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(24).AddHours(9),
        End = DateTime.UtcNow.AddDays(24).AddHours(16),
        PriceAdult = 268, Type = "Train", Seats = 105,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(8),
        End = DateTime.UtcNow.AddDays(36).AddHours(17),
        PriceAdult = 51, Type = "Train", Seats = 157,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(17),
        End = DateTime.UtcNow.AddDays(8).AddHours(24),
        PriceAdult = 124, Type = "Bus", Seats = 190,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(19),
        End = DateTime.UtcNow.AddDays(6).AddHours(6),
        PriceAdult = 146, Type = "Train", Seats = 164,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(9),
        End = DateTime.UtcNow.AddDays(9).AddHours(13),
        PriceAdult = 131, Type = "Train", Seats = 160,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(88).AddHours(15),
        End = DateTime.UtcNow.AddDays(88).AddHours(22),
        PriceAdult = 235, Type = "Bus", Seats = 108,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(33).AddHours(21),
        End = DateTime.UtcNow.AddDays(34).AddHours(7),
        PriceAdult = 290, Type = "Plane", Seats = 120,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(23).AddHours(5),
        End = DateTime.UtcNow.AddDays(23).AddHours(16),
        PriceAdult = 297, Type = "Bus", Seats = 121,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(13),
        End = DateTime.UtcNow.AddDays(85).AddHours(23),
        PriceAdult = 208, Type = "Bus", Seats = 134,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(20),
        End = DateTime.UtcNow.AddDays(36).AddHours(7),
        PriceAdult = 129, Type = "Train", Seats = 192,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(11),
        End = DateTime.UtcNow.AddDays(18).AddHours(16),
        PriceAdult = 161, Type = "Bus", Seats = 106,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(4),
        End = DateTime.UtcNow.AddDays(17).AddHours(13),
        PriceAdult = 65, Type = "Train", Seats = 175,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(14),
        End = DateTime.UtcNow.AddDays(29).AddHours(23),
        PriceAdult = 238, Type = "Plane", Seats = 146,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(20),
        End = DateTime.UtcNow.AddDays(56).AddHours(6),
        PriceAdult = 224, Type = "Train", Seats = 111,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(3).AddHours(3),
        End = DateTime.UtcNow.AddDays(3).AddHours(14),
        PriceAdult = 107, Type = "Plane", Seats = 161,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(7),
        End = DateTime.UtcNow.AddDays(55).AddHours(13),
        PriceAdult = 295, Type = "Bus", Seats = 174,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(15),
        End = DateTime.UtcNow.AddDays(48).AddHours(2),
        PriceAdult = 158, Type = "Plane", Seats = 134,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(9),
        End = DateTime.UtcNow.AddDays(5).AddHours(12),
        PriceAdult = 178, Type = "Plane", Seats = 77,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(1),
        End = DateTime.UtcNow.AddDays(20).AddHours(5),
        PriceAdult = 92, Type = "Bus", Seats = 171,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(71).AddHours(3),
        End = DateTime.UtcNow.AddDays(71).AddHours(10),
        PriceAdult = 287, Type = "Plane", Seats = 131,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(17),
        End = DateTime.UtcNow.AddDays(27).AddHours(1),
        PriceAdult = 289, Type = "Plane", Seats = 137,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(8),
        End = DateTime.UtcNow.AddDays(65).AddHours(11),
        PriceAdult = 279, Type = "Bus", Seats = 127,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(2),
        End = DateTime.UtcNow.AddDays(79).AddHours(14),
        PriceAdult = 140, Type = "Bus", Seats = 69,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(23),
        End = DateTime.UtcNow.AddDays(48).AddHours(1),
        PriceAdult = 290, Type = "Bus", Seats = 133,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(21),
        End = DateTime.UtcNow.AddDays(81).AddHours(23),
        PriceAdult = 184, Type = "Bus", Seats = 118,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(21).AddHours(16),
        End = DateTime.UtcNow.AddDays(21).AddHours(21),
        PriceAdult = 172, Type = "Train", Seats = 103,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(39).AddHours(15),
        End = DateTime.UtcNow.AddDays(39).AddHours(19),
        PriceAdult = 222, Type = "Plane", Seats = 51,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(11),
        End = DateTime.UtcNow.AddDays(83).AddHours(13),
        PriceAdult = 187, Type = "Train", Seats = 94,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(17),
        End = DateTime.UtcNow.AddDays(3).AddHours(3),
        PriceAdult = 91, Type = "Plane", Seats = 83,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(18),
        End = DateTime.UtcNow.AddDays(36).AddHours(20),
        PriceAdult = 131, Type = "Train", Seats = 66,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(28).AddHours(10),
        End = DateTime.UtcNow.AddDays(28).AddHours(13),
        PriceAdult = 137, Type = "Train", Seats = 57,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(10),
        End = DateTime.UtcNow.AddDays(43).AddHours(21),
        PriceAdult = 180, Type = "Plane", Seats = 51,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(16),
        End = DateTime.UtcNow.AddDays(15).AddHours(21),
        PriceAdult = 74, Type = "Plane", Seats = 200,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(4),
        End = DateTime.UtcNow.AddDays(90).AddHours(6),
        PriceAdult = 232, Type = "Train", Seats = 96,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(51).AddHours(8),
        End = DateTime.UtcNow.AddDays(51).AddHours(13),
        PriceAdult = 132, Type = "Plane", Seats = 84,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(73).AddHours(23),
        End = DateTime.UtcNow.AddDays(74).AddHours(9),
        PriceAdult = 159, Type = "Plane", Seats = 56,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(8),
        End = DateTime.UtcNow.AddDays(35).AddHours(16),
        PriceAdult = 188, Type = "Bus", Seats = 65,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(13).AddHours(23),
        End = DateTime.UtcNow.AddDays(14).AddHours(7),
        PriceAdult = 126, Type = "Bus", Seats = 147,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle de Alcalá"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(64).AddHours(18),
        End = DateTime.UtcNow.AddDays(65).AddHours(3),
        PriceAdult = 185, Type = "Plane", Seats = 171,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(5),
        End = DateTime.UtcNow.AddDays(48).AddHours(13),
        PriceAdult = 68, Type = "Plane", Seats = 167,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(7),
        End = DateTime.UtcNow.AddDays(44).AddHours(18),
        PriceAdult = 226, Type = "Bus", Seats = 57,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(19),
        End = DateTime.UtcNow.AddDays(44).AddHours(7),
        PriceAdult = 286, Type = "Bus", Seats = 74,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(9),
        End = DateTime.UtcNow.AddDays(55).AddHours(11),
        PriceAdult = 176, Type = "Train", Seats = 55,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(2),
        End = DateTime.UtcNow.AddDays(87).AddHours(7),
        PriceAdult = 240, Type = "Train", Seats = 77,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(14),
        End = DateTime.UtcNow.AddDays(4).AddHours(20),
        PriceAdult = 131, Type = "Bus", Seats = 149,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(13),
        End = DateTime.UtcNow.AddDays(38).AddHours(1),
        PriceAdult = 83, Type = "Plane", Seats = 104,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(1),
        End = DateTime.UtcNow.AddDays(8).AddHours(5),
        PriceAdult = 95, Type = "Plane", Seats = 128,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(3),
        End = DateTime.UtcNow.AddDays(77).AddHours(15),
        PriceAdult = 182, Type = "Plane", Seats = 190,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(60).AddHours(4),
        End = DateTime.UtcNow.AddDays(60).AddHours(11),
        PriceAdult = 87, Type = "Bus", Seats = 137,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(21),
        End = DateTime.UtcNow.AddDays(35).AddHours(23),
        PriceAdult = 248, Type = "Plane", Seats = 98,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(1).AddHours(6),
        End = DateTime.UtcNow.AddDays(1).AddHours(16),
        PriceAdult = 123, Type = "Train", Seats = 69,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(34).AddHours(2),
        End = DateTime.UtcNow.AddDays(34).AddHours(13),
        PriceAdult = 250, Type = "Train", Seats = 186,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(17),
        End = DateTime.UtcNow.AddDays(60).AddHours(5),
        PriceAdult = 280, Type = "Train", Seats = 117,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(9).AddHours(13),
        End = DateTime.UtcNow.AddDays(9).AddHours(23),
        PriceAdult = 95, Type = "Train", Seats = 66,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(21),
        End = DateTime.UtcNow.AddDays(90).AddHours(7),
        PriceAdult = 67, Type = "Plane", Seats = 117,
        FromCity = "Almeria", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(9),
        End = DateTime.UtcNow.AddDays(14).AddHours(12),
        PriceAdult = 92, Type = "Train", Seats = 170,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(2),
        End = DateTime.UtcNow.AddDays(83).AddHours(10),
        PriceAdult = 81, Type = "Train", Seats = 130,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(23),
        End = DateTime.UtcNow.AddDays(84).AddHours(6),
        PriceAdult = 241, Type = "Train", Seats = 192,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(25).AddHours(16),
        End = DateTime.UtcNow.AddDays(25).AddHours(22),
        PriceAdult = 221, Type = "Train", Seats = 89,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(4).AddHours(3),
        End = DateTime.UtcNow.AddDays(4).AddHours(11),
        PriceAdult = 243, Type = "Plane", Seats = 176,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(16),
        End = DateTime.UtcNow.AddDays(27).AddHours(1),
        PriceAdult = 83, Type = "Plane", Seats = 136,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(66).AddHours(16),
        End = DateTime.UtcNow.AddDays(66).AddHours(18),
        PriceAdult = 53, Type = "Plane", Seats = 174,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle de Alcalá",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(19),
        End = DateTime.UtcNow.AddDays(39).AddHours(6),
        PriceAdult = 153, Type = "Train", Seats = 65,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(13),
        End = DateTime.UtcNow.AddDays(81).AddHours(18),
        PriceAdult = 95, Type = "Plane", Seats = 166,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(35).AddHours(6),
        End = DateTime.UtcNow.AddDays(35).AddHours(8),
        PriceAdult = 116, Type = "Plane", Seats = 112,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(9),
        End = DateTime.UtcNow.AddDays(29).AddHours(16),
        PriceAdult = 282, Type = "Plane", Seats = 66,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Halaskargazi Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(2),
        End = DateTime.UtcNow.AddDays(63).AddHours(7),
        PriceAdult = 108, Type = "Bus", Seats = 200,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(9),
        End = DateTime.UtcNow.AddDays(38).AddHours(11),
        PriceAdult = 281, Type = "Plane", Seats = 64,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(25).AddHours(12),
        End = DateTime.UtcNow.AddDays(25).AddHours(19),
        PriceAdult = 140, Type = "Bus", Seats = 123,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Nazionale",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(3),
        End = DateTime.UtcNow.AddDays(81).AddHours(11),
        PriceAdult = 79, Type = "Bus", Seats = 128,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(29).AddHours(12),
        End = DateTime.UtcNow.AddDays(29).AddHours(16),
        PriceAdult = 97, Type = "Train", Seats = 148,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Heraklion", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(19).AddHours(21),
        End = DateTime.UtcNow.AddDays(20).AddHours(9),
        PriceAdult = 246, Type = "Train", Seats = 167,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Bulevardi Bajram Curri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(15).AddHours(7),
        End = DateTime.UtcNow.AddDays(15).AddHours(10),
        PriceAdult = 58, Type = "Bus", Seats = 82,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(59).AddHours(20),
        End = DateTime.UtcNow.AddDays(59).AddHours(22),
        PriceAdult = 218, Type = "Plane", Seats = 179,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(19).AddHours(9),
        End = DateTime.UtcNow.AddDays(19).AddHours(17),
        PriceAdult = 226, Type = "Train", Seats = 172,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(33).AddHours(21),
        End = DateTime.UtcNow.AddDays(34).AddHours(5),
        PriceAdult = 82, Type = "Train", Seats = 127,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(23),
        End = DateTime.UtcNow.AddDays(15).AddHours(8),
        PriceAdult = 152, Type = "Plane", Seats = 187,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(20),
        End = DateTime.UtcNow.AddDays(56).AddHours(22),
        PriceAdult = 186, Type = "Train", Seats = 121,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Vukovarska ulica",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(67).AddHours(19),
        End = DateTime.UtcNow.AddDays(68).AddHours(4),
        PriceAdult = 190, Type = "Plane", Seats = 110,
        FromCity = "Olimpijska", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(38).AddHours(14),
        End = DateTime.UtcNow.AddDays(38).AddHours(17),
        PriceAdult = 225, Type = "Train", Seats = 122,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(13),
        End = DateTime.UtcNow.AddDays(31).AddHours(22),
        PriceAdult = 203, Type = "Plane", Seats = 80,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(36).AddHours(17),
        End = DateTime.UtcNow.AddDays(37).AddHours(1),
        PriceAdult = 272, Type = "Plane", Seats = 90,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Trg bana Josipa Jelačića",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(10),
        End = DateTime.UtcNow.AddDays(37).AddHours(18),
        PriceAdult = 266, Type = "Train", Seats = 194,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Halaskargazi Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(83).AddHours(21),
        End = DateTime.UtcNow.AddDays(84).AddHours(1),
        PriceAdult = 89, Type = "Train", Seats = 167,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(19),
        End = DateTime.UtcNow.AddDays(63).AddHours(23),
        PriceAdult = 91, Type = "Train", Seats = 50,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(87).AddHours(13),
        End = DateTime.UtcNow.AddDays(88).AddHours(1),
        PriceAdult = 129, Type = "Plane", Seats = 133,
        FromCity = "Luz", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(18).AddHours(15),
        End = DateTime.UtcNow.AddDays(19).AddHours(2),
        PriceAdult = 137, Type = "Train", Seats = 82,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(1),
        End = DateTime.UtcNow.AddDays(77).AddHours(6),
        PriceAdult = 92, Type = "Plane", Seats = 65,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Almeria", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(7),
        End = DateTime.UtcNow.AddDays(40).AddHours(10),
        PriceAdult = 140, Type = "Bus", Seats = 63,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Gran Vía"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(8).AddHours(9),
        End = DateTime.UtcNow.AddDays(8).AddHours(15),
        PriceAdult = 274, Type = "Train", Seats = 107,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(40).AddHours(18),
        End = DateTime.UtcNow.AddDays(41).AddHours(1),
        PriceAdult = 284, Type = "Train", Seats = 161,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(63).AddHours(13),
        End = DateTime.UtcNow.AddDays(63).AddHours(20),
        PriceAdult = 149, Type = "Bus", Seats = 188,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(47).AddHours(3),
        End = DateTime.UtcNow.AddDays(47).AddHours(6),
        PriceAdult = 267, Type = "Train", Seats = 171,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(22),
        End = DateTime.UtcNow.AddDays(86).AddHours(7),
        PriceAdult = 139, Type = "Plane", Seats = 101,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Gamal Abdel Nasser"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(16).AddHours(13),
        End = DateTime.UtcNow.AddDays(16).AddHours(15),
        PriceAdult = 261, Type = "Bus", Seats = 50,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(20),
        End = DateTime.UtcNow.AddDays(57).AddHours(5),
        PriceAdult = 54, Type = "Plane", Seats = 103,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(10),
        End = DateTime.UtcNow.AddDays(26).AddHours(14),
        PriceAdult = 174, Type = "Plane", Seats = 152,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(3),
        End = DateTime.UtcNow.AddDays(44).AddHours(10),
        PriceAdult = 257, Type = "Train", Seats = 117,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(82).AddHours(9),
        End = DateTime.UtcNow.AddDays(82).AddHours(16),
        PriceAdult = 187, Type = "Train", Seats = 58,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(76).AddHours(2),
        End = DateTime.UtcNow.AddDays(76).AddHours(8),
        PriceAdult = 100, Type = "Plane", Seats = 132,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(5).AddHours(6),
        End = DateTime.UtcNow.AddDays(5).AddHours(9),
        PriceAdult = 187, Type = "Plane", Seats = 51,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(28).AddHours(7),
        End = DateTime.UtcNow.AddDays(28).AddHours(19),
        PriceAdult = 172, Type = "Train", Seats = 155,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(55).AddHours(0),
        End = DateTime.UtcNow.AddDays(55).AddHours(5),
        PriceAdult = 125, Type = "Plane", Seats = 84,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(18),
        End = DateTime.UtcNow.AddDays(2).AddHours(21),
        PriceAdult = 244, Type = "Train", Seats = 160,
        FromCity = "Heraklion", FromCountry = "grecja", FromStreet = "Plateia Syntagmatos",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(19),
        End = DateTime.UtcNow.AddDays(77).AddHours(21),
        PriceAdult = 278, Type = "Train", Seats = 186,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(11).AddHours(19),
        End = DateTime.UtcNow.AddDays(11).AddHours(23),
        PriceAdult = 65, Type = "Train", Seats = 109,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(9),
        End = DateTime.UtcNow.AddDays(56).AddHours(14),
        PriceAdult = 248, Type = "Bus", Seats = 168,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(56).AddHours(20),
        End = DateTime.UtcNow.AddDays(57).AddHours(5),
        PriceAdult = 154, Type = "Train", Seats = 194,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(46).AddHours(10),
        End = DateTime.UtcNow.AddDays(46).AddHours(14),
        PriceAdult = 173, Type = "Bus", Seats = 90,
        FromCity = "Nero", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Ramsis"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(31).AddHours(17),
        End = DateTime.UtcNow.AddDays(31).AddHours(22),
        PriceAdult = 130, Type = "Plane", Seats = 141,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(50).AddHours(6),
        End = DateTime.UtcNow.AddDays(50).AddHours(9),
        PriceAdult = 235, Type = "Bus", Seats = 179,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Peloponez", ToCountry = "grecja", ToStreet = "Leoforos Alexandras"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(73).AddHours(7),
        End = DateTime.UtcNow.AddDays(73).AddHours(11),
        PriceAdult = 97, Type = "Bus", Seats = 174,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Kapucinska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(90).AddHours(0),
        End = DateTime.UtcNow.AddDays(90).AddHours(6),
        PriceAdult = 157, Type = "Train", Seats = 106,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via del Corso",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga e Dibres"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(54).AddHours(15),
        End = DateTime.UtcNow.AddDays(55).AddHours(2),
        PriceAdult = 66, Type = "Plane", Seats = 169,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Maresme", ToCountry = "hiszpania", ToStreet = "Paseo del Prado"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(65).AddHours(8),
        End = DateTime.UtcNow.AddDays(65).AddHours(11),
        PriceAdult = 106, Type = "Bus", Seats = 197,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Gran Vía",
        ToCity = "Brava", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(74).AddHours(22),
        End = DateTime.UtcNow.AddDays(75).AddHours(5),
        PriceAdult = 217, Type = "Bus", Seats = 156,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Chania", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(14),
        End = DateTime.UtcNow.AddDays(44).AddHours(2),
        PriceAdult = 91, Type = "Bus", Seats = 159,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(77).AddHours(7),
        End = DateTime.UtcNow.AddDays(77).AddHours(14),
        PriceAdult = 98, Type = "Plane", Seats = 121,
        FromCity = "Peloponez", FromCountry = "grecja", FromStreet = "Leoforos Alexandras",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(30).AddHours(22),
        End = DateTime.UtcNow.AddDays(31).AddHours(3),
        PriceAdult = 224, Type = "Train", Seats = 97,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Bulevardi Bajram Curri",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(44).AddHours(4),
        End = DateTime.UtcNow.AddDays(44).AddHours(16),
        PriceAdult = 97, Type = "Plane", Seats = 160,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Nero", ToCountry = "grecja", ToStreet = "Leoforos Vasilissis Sofias"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(14).AddHours(10),
        End = DateTime.UtcNow.AddDays(14).AddHours(17),
        PriceAdult = 281, Type = "Plane", Seats = 179,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(1).AddHours(0),
        End = DateTime.UtcNow.AddDays(1).AddHours(2),
        PriceAdult = 185, Type = "Train", Seats = 53,
        FromCity = "Marmaris", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(61).AddHours(10),
        End = DateTime.UtcNow.AddDays(61).AddHours(18),
        PriceAdult = 156, Type = "Train", Seats = 103,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Maksimirska ulica",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(37).AddHours(0),
        End = DateTime.UtcNow.AddDays(37).AddHours(2),
        PriceAdult = 115, Type = "Plane", Seats = 83,
        FromCity = "Chania", FromCountry = "grecja", FromStreet = "Leoforos Vasilissis Sofias",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(6),
        End = DateTime.UtcNow.AddDays(49).AddHours(17),
        PriceAdult = 186, Type = "Train", Seats = 149,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Olimpijska", ToCountry = "grecja", ToStreet = "Plateia Syntagmatos"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(2).AddHours(15),
        End = DateTime.UtcNow.AddDays(2).AddHours(17),
        PriceAdult = 282, Type = "Train", Seats = 120,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(89).AddHours(19),
        End = DateTime.UtcNow.AddDays(89).AddHours(21),
        PriceAdult = 213, Type = "Train", Seats = 164,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(69).AddHours(17),
        End = DateTime.UtcNow.AddDays(69).AddHours(22),
        PriceAdult = 141, Type = "Train", Seats = 188,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(10).AddHours(22),
        End = DateTime.UtcNow.AddDays(11).AddHours(2),
        PriceAdult = 80, Type = "Plane", Seats = 196,
        FromCity = "Maresme", FromCountry = "hiszpania", FromStreet = "Paseo del Prado",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(17).AddHours(16),
        End = DateTime.UtcNow.AddDays(17).AddHours(24),
        PriceAdult = 287, Type = "Bus", Seats = 155,
        FromCity = "Brava", FromCountry = "hiszpania", FromStreet = "Calle Mayor",
        ToCity = "Marmaris", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(81).AddHours(7),
        End = DateTime.UtcNow.AddDays(81).AddHours(18),
        PriceAdult = 143, Type = "Bus", Seats = 176,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Veneto"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(42).AddHours(19),
        End = DateTime.UtcNow.AddDays(42).AddHours(22),
        PriceAdult = 171, Type = "Plane", Seats = 109,
        FromCity = "Riwiera", FromCountry = "chorwacja", FromStreet = "Kapucinska ulica",
        ToCity = "Alam", ToCountry = "egipt", ToStreet = "Sharia Tahrir"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(26).AddHours(10),
        End = DateTime.UtcNow.AddDays(26).AddHours(16),
        PriceAdult = 59, Type = "Plane", Seats = 101,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga e Kavajes",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(53).AddHours(9),
        End = DateTime.UtcNow.AddDays(53).AddHours(13),
        PriceAdult = 273, Type = "Train", Seats = 94,
        FromCity = "Vlora", FromCountry = "albania", FromStreet = "Rruga 28 Nentori",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via Nazionale"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(48).AddHours(2),
        End = DateTime.UtcNow.AddDays(48).AddHours(13),
        PriceAdult = 277, Type = "Bus", Seats = 98,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Durres", ToCountry = "albania", ToStreet = "Rruga Abdyl Frasheri"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(52).AddHours(14),
        End = DateTime.UtcNow.AddDays(52).AddHours(21),
        PriceAdult = 215, Type = "Bus", Seats = 150,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Kalabria", ToCountry = "wlochy", ToStreet = "Via del Corso"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(4),
        End = DateTime.UtcNow.AddDays(22).AddHours(13),
        PriceAdult = 253, Type = "Train", Seats = 193,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Gamal Abdel Nasser",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(20).AddHours(23),
        End = DateTime.UtcNow.AddDays(21).AddHours(3),
        PriceAdult = 192, Type = "Plane", Seats = 99,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Luz", ToCountry = "hiszpania", ToStreet = "Calle Mayor"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(11).AddHours(23),
        End = DateTime.UtcNow.AddDays(12).AddHours(7),
        PriceAdult = 62, Type = "Plane", Seats = 181,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Ramsis",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Atatürk Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(50).AddHours(18),
        End = DateTime.UtcNow.AddDays(51).AddHours(6),
        PriceAdult = 152, Type = "Bus", Seats = 71,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga 28 Nentori"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(85).AddHours(15),
        End = DateTime.UtcNow.AddDays(86).AddHours(1),
        PriceAdult = 129, Type = "Train", Seats = 114,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Atatürk Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Maksimirska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(34).AddHours(4),
        End = DateTime.UtcNow.AddDays(34).AddHours(13),
        PriceAdult = 68, Type = "Bus", Seats = 199,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga Abdyl Frasheri",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Vukovarska ulica"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(49).AddHours(8),
        End = DateTime.UtcNow.AddDays(49).AddHours(20),
        PriceAdult = 122, Type = "Plane", Seats = 94,
        FromCity = "Kalabria", FromCountry = "wlochy", FromStreet = "Via Veneto",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(22).AddHours(8),
        End = DateTime.UtcNow.AddDays(22).AddHours(19),
        PriceAdult = 292, Type = "Train", Seats = 70,
        FromCity = "Durres", FromCountry = "albania", FromStreet = "Rruga e Dibres",
        ToCity = "Turecka", ToCountry = "turcja", ToStreet = "Bağdat Caddesi"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(43).AddHours(21),
        End = DateTime.UtcNow.AddDays(44).AddHours(9),
        PriceAdult = 136, Type = "Train", Seats = 99,
        FromCity = "Sheikh", FromCountry = "egipt", FromStreet = "Sharia Salah Salem",
        ToCity = "Vlora", ToCountry = "albania", ToStreet = "Rruga e Kavajes"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(79).AddHours(4),
        End = DateTime.UtcNow.AddDays(79).AddHours(12),
        PriceAdult = 275, Type = "Train", Seats = 50,
        FromCity = "Alam", FromCountry = "egipt", FromStreet = "Sharia Tahrir",
        ToCity = "Sheikh", ToCountry = "egipt", ToStreet = "Sharia Salah Salem"
    },

    new QueryTransportOption
    {
        Id = Guid.NewGuid(), Start = DateTime.UtcNow.AddDays(75).AddHours(11),
        End = DateTime.UtcNow.AddDays(75).AddHours(22),
        PriceAdult = 194, Type = "Plane", Seats = 184,
        FromCity = "Turecka", FromCountry = "turcja", FromStreet = "Bağdat Caddesi",
        ToCity = "Riwiera", ToCountry = "chorwacja", ToStreet = "Trg bana Josipa Jelačića"
    },
    };
                modelBuilder.Entity<QueryTransportOption>().HasData(queryTransportOptions);
            }
        }
    }
