using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Database;

public class PostgresDatabase(DbContextOptions<PostgresDatabase> options) : DbContext(options)
{
    public DbSet<SmsInactivity> SmsInactivity { get; set; }
    public DbSet<InvestmentHouse> InvestmentHouse { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("public");
        base.OnModelCreating(builder);
    }
}