using Microsoft.EntityFrameworkCore;
using transportservice.Models;

namespace transportservice.Persistence;

public class TransportDbContext : DbContext
{
    public TransportDbContext(DbContextOptions<TransportDbContext> options) : base(options)
    {
    }

    public DbSet<TransportOption> TransportOptions { get; set; }
}