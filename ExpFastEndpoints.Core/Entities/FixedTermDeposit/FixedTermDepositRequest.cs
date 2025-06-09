using ExpFastEnpoints.ExpFastEndpoints.Core.Models;

public class FixedTermDepositRequest
{
    public int InvestmentHouseId { get; set; }

    public double Amount { get; set; }

    public double InterestRate { get; set; }

    public int Tenure { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly MaturityDate { get; set; }

    public double InterestAmount { get; set; }

    public double MaturityAmount { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual InvestmentHouse InvestmentHouse { get; set; } = null!;
}