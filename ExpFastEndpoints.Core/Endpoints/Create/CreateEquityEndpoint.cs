using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Equity;
using FastEndpoints;

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
        var newequity = new 
        await SendOkAsync(cancellation: ct);
    }
}