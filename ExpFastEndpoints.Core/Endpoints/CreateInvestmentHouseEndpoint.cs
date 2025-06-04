using FastEndpoints;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints;

public class CreateInvestmentHouseEndpoint : Endpoint<InvestmentHouseRequest>
{
    public override void Configure()
    {
        Post("exp/create-investment-house");
        Summary(s => s.Summary = "Create Investment House");
        AllowAnonymous();
    }
}