using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Database;

public class PostgresDatabase(DbContextOptions<PostgresDatabase> options) : DbContext(options)
{
    public DbSet<SmsInactivity> SmsInactivity { get; set; }
    public DbSet<InvestmentHouse> InvestmentHouse { get; set; }
    public DbSet<FixedTermDeposit> FixedTermDeposit { get; set; }
    public DbSet<Equity> Equity { get; set; }
    public DbSet<CommercialPaper> CommercialPaper { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("public");
        base.OnModelCreating(builder);
    }
}