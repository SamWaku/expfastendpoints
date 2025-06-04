using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using FastEndpoints;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints;

public class CreateFixedTermDepositEndpoint(PostgresDatabase postgresDb) : Endpoint<FixedTermDepositRequest>
{
    public override void Configure()
    {
        Post("exp/create-fixed-term-deposit");
        Summary(s => s.Summary = "Create Fixed Term Deposit");
        AllowAnonymous();
    }

    public override async Task HandleAsync(FixedTermDepositRequest req, CancellationToken ct)
    {
        var database = postgresDb;
        var newFixedTermDeposit = new FixedTermDeposit
        {
            Amount = req.Amount,
            InterestRate = req.InterestRate,
            Tenure = req.Tenure,
            StartDate = req.StartDate,
            MaturityDate = req.MaturityDate,
            InterestAmount = req.InterestAmount,
            MaturityAmount = req.MaturityAmount,
        };

        database.Set<FixedTermDeposit>().Add(newFixedTermDeposit);
        await database.SaveChangesAsync(ct);
    }
}