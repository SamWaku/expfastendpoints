using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.CommercialPaper;
using FastEndpoints;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints.Get;

public class GetCommercialPaperEndpoint : Endpoint<CommercialPaperRequest, CommercialPaperResponse>
{
    public override void Configure()
    {
        Get("exp/get-commercial-papers");
        Summary(s =>
        {
            s.Summary = "Get Commercial Papers";
        });
        AllowAnonymous();
    }
}