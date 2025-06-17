using System.Data.Entity;
using Microsoft.EntityFrameworkCore; 
using ExpFastEnpoints.ExpFastEndpoints.Core.Configs;
using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Common;

public interface IDatabaseService
{
    DbContext SelectDatabase(string prefix);
}

public class DatabaseService(ILogger<DatabaseService> logger,PostgresDatabase postgresDatabase, PatumbaCentralDatabase patumbaCentralDatabase) : IDatabaseService
{
    public DbContext SelectDatabase(string prefix)
    {
        try
        {
            if (prefix.Length > 1)
            {
                return prefix switch
                {
                    CoreConfigs.PostrgesDb => postgresDatabase,
                    CoreConfigs.PatumbaCentral => patumbaCentralDatabase,
                    _ => throw new NotSupportedException($"Unknown prefix: '{prefix}'.")
                };
            }
        }
        catch (Exception e)
        {
           logger.LogError(e, "Failed to resolve DbContext for prefix {Prefix}", prefix);
        }

        return null;
    }
}