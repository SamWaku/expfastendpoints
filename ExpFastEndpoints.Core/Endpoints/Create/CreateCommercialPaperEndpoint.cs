﻿using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.CommercialPaper;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using FastEndpoints;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints;

public class CreateCommercialPaperEndpoint(PostgresDatabase postgresDatabase) : Endpoint<CreateCommercialPaperRequest, CreateCommercialPaperResponse>
{
    public override void Configure()
    {
        Post("exp/create-commercial-paper");
        Summary(s =>
        {
            s.Summary = "Create commercial paper";
        });
        // AllowAnonymous();
    }

    public override async Task HandleAsync(CreateCommercialPaperRequest req, CancellationToken ct)
    { 
        var database = postgresDatabase;
        var maturityDate = new DateTime().AddDays(req.Tenure);
        
        var newCommercialPaper = new CommercialPaper
        {
            DateCreated = DateTime.UtcNow,
            CompanyName = req.CompanyName,
            InvestedAmount = req.InvestedAmount,
            InterestRate = req.InterestRate,
            Tenure = req.Tenure,
            StartDate = req.StartDate,
            MaturityDate = maturityDate
        };

        database.Set<CommercialPaper>().Add(newCommercialPaper);
        await database.SaveChangesAsync(cancellationToken: ct);
        await SendOkAsync( new CreateCommercialPaperResponse{ Message = "Commercial paper created"},cancellation: ct);
    }
    
    
}