﻿using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Common;

public static class DatabaseExtension
{
    public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var databaseConnection = configuration.GetConnectionString("Postgres");
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(databaseConnection).EnableUnmappedTypes();
        dataSourceBuilder.EnableDynamicJson();
        dataSourceBuilder.RegisterEnumTypeConversion("public");
        var dataSource = dataSourceBuilder.Build();

        services.AddDbContext<PostgresDatabase>(options =>
        {
            options.UseNpgsql(dataSource, opt => opt
                    .EnableRetryOnFailure()
                    .MigrationsHistoryTable("__EFMigrationsHistory", "public"))
                .UseSnakeCaseNamingConvention();;
        });
    }
}