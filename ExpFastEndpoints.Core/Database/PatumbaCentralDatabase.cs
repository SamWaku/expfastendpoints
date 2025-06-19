using ExpFastEnpoints.ExpFastEndpoints.Core.Common;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Database;

public class PatumbaCentralDatabase(DbContextOptions<PatumbaCentralDatabase> options) : DbContext(options)
{
    public DbSet<InvestmentHouse> InvestmentHouses { get; set; }
    public DbSet<FixedTermDeposit> FixedTermDeposits { get; set; }
    public DbSet<Equity> Equities { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<InvestmentHouse>().ToTable("investment_houses");
        builder.Entity<FixedTermDeposit>().ToTable("fixed_term_deposits");
    }
}