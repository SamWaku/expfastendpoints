using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Equity;
using FastEndpoints;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints;

public class CreateEquityEndpoint : Endpoint<CreateEquityRequest, CreateEquityResponse>
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
}