using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Equity;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using FastEndpoints;
using OrderType = ExpFastEnpoints.ExpFastEndpoints.Core.Models.OrderType;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints;

public class CreateEquityEndpoint(PostgresDatabase postgresDatabase) : Endpoint<CreateEquityRequest, CreateEquityResponse>
{
    public override void Configure()
    {
       Post("exp/create-equity");
       Summary(s =>
       {
           s.Summary = "Create Equity";
       });
       AllowAnonymous();
    }

    public override async Task HandleAsync(CreateEquityRequest req, CancellationToken ct)
    {
        var newEquity = new Equity
        {
            DateCreated = default,
            OrderType = req.OrderType,
            Company = req.Company,
            Quantity = req.Quantity,
            SharePrice = req.SharePrice
        };
        await SendOkAsync(cancellation: ct);
    }
}