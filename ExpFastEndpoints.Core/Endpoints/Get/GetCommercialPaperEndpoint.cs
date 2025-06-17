using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Extensions;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Pagination;
using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.CommercialPaper;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints.Get;

public class GetCommercialPaperEndpoint(PostgresDatabase postgresDatabase) : Endpoint<CommercialPaperRequest, PaginatedResponse<CommercialPaperResponse>>
{
    public override void Configure()
    {
        Get("exp/get-commercial-papers");
        Summary(s =>
        {
            s.Summary = "Get Commercial Papers";
        });
        // AllowAnonymous();
    }

    public override async Task HandleAsync(CommercialPaperRequest req, CancellationToken ct)
    {
        var query = postgresDatabase.CommercialPaper
            .OrderByDescending(x => x.Id);

        var commercialPapers = await query
            .OrderAndPaginate(req)
            .ToListAsync(cancellationToken: ct);

        var total = await query.CountAsync(cancellationToken: ct);

        var response = commercialPapers.Select(x => new CommercialPaperResponse
        {
            Id = x.Id,
            DateCreated = x.DateCreated,
            CompanyName = x.CompanyName,
            InvestedAmount = x.InvestedAmount,
            InterestRate = x.InterestRate,
            Tenure = x.Tenure,
            StartDate = x.StartDate,
            MaturityDate = x.MaturityDate,

        }).ToPagedResponse(total, req);
        await SendOkAsync(response,cancellation: ct);
    }
}