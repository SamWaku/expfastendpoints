using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Database;

public class PostgresDatabase(DbContextOptions<PostgresDatabase> options) : DbContext(options)
{
    public DbSet<SmsInactivity> SmsInactivity { get; set; }
}