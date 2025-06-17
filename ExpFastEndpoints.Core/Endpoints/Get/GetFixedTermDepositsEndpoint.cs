using ExpFastEnpoints.ExpFastEndpoints.Core.Common;
using Microsoft.EntityFrameworkCore; 
using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Extensions;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Pagination;
using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using FastEndpoints;

public class FixedTermDepositsRequest : PaginationFilter
{
    // public virtual InvestmentHouse InvestmentHouse { get; set; } = null!;
}

public class FixedTermDepositsEndpoint(IDatabaseService databaseService, PostgresDatabase postgresDb) : Endpoint<FixedTermDepositsRequest, PaginatedResponse<FixedTermDepositsResponse>>
{
    public override void Configure()
    {
        Get("exp/fixed-term-deposits");
        Summary(s => s.Summary = "Get fixed-term-deposits");
        // AllowAnonymous();
    }

    public override async Task HandleAsync(FixedTermDepositsRequest req, CancellationToken ct)
    {
        var database = databaseService.SelectDatabase("PatumbaCentral");
        var db = database.Set<FixedTermDeposit>();
        var fixedTermDeposits = await db
            .OrderByDescending(x => x.Id)
            .Include(x => x.InvestmentHouse)
            .Skip((req.PageNumber - 1) * req.PageSize)
            .Take(req.PageSize)
            .ToListAsync(cancellationToken: ct);

        var totals = fixedTermDeposits.Count();
        var result = fixedTermDeposits.Select(x => new FixedTermDepositsResponse
        {
            Id = x.Id,
            InvestmentHouseId = x.InvestmentHouseId,
            Amount = x.Amount,
            InterestRate = x.InterestRate,
            Tenure = x.Tenure,
            StartDate = x.StartDate,
            MaturityDate = x.MaturityDate,
            InterestAmount = x.InterestAmount,
            MaturityAmount = x.MaturityAmount,
            DateCreated = x.DateCreated,
            UpdatedAt = x.UpdatedAt,
            InvestmentHouse = x.InvestmentHouse.CompanyName

        }).ToPagedResponse(totals, req);
        
        await SendOkAsync(result, cancellation: ct);
    }
}