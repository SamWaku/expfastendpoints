using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.CommercialPaper;
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
        AllowAnonymous();
    }
    
}