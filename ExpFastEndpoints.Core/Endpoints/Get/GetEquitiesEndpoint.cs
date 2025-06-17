using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Extensions;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Pagination;
using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Equity;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints.Get;

public class GetEquitiesEndpoint(PostgresDatabase postgresDatabase) : Endpoint<EquitiesRequest, PaginatedResponse<EquitiesResponse>>
{
    public override void Configure()
    {
        Get("exp/get-equities");
        Summary(s =>
        {
            s.Summary = "Get Equities";
        });
        // AllowAnonymous();
    }

    public override async Task HandleAsync(EquitiesRequest req, CancellationToken ct)
    {
        var query = postgresDatabase.Equity
            .ConditionalWhere(req.Id != null, x => x.Id == req.Id)
            .ConditionalWhere(req.SearchQuery != null, x => x.Company == req.SearchQuery)
            .OrderByDescending(x => x.Id);

        var equities = await query
            .OrderAndPaginate(req)
            .ToListAsync(cancellationToken: ct);

        var total = await query.CountAsync(cancellationToken: ct);

        var response = equities.Select(x => new EquitiesResponse
        {
            Id = x.Id,
            DateCreated = x.DateCreated,
            OrderType = x.OrderType,
            Company = x.Company,
            Quantity = x.Quantity,
            SharePrice = x.SharePrice,
            TotalConsideration = TotalConsideration(x.Quantity, x.SharePrice)
        }).ToPagedResponse(total, req);
        await SendOkAsync(response, cancellation: ct);
    }
    
    private static double TotalConsideration(double quantity, double sharePrice)
    {
        var totalConsideration = quantity * sharePrice;
        return totalConsideration;
    }
}