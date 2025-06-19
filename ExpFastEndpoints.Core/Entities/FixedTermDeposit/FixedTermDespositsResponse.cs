using ExpFastEnpoints.ExpFastEndpoints.Core.Common;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;

public class FixedTermDepositsResponse : BaseEntity
{
    public string? InvestmentHouse { get; set; } = null!;
    public int? InvestmentHouseId { get; set; }

    public double? Amount { get; set; }

    public double? InterestRate { get; set; }

    public int? Tenure { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public double? InterestAmount { get; set; }

    public double? MaturityAmount { get; set; }
    
    public FixedTermStatus? Status { get; set; }

    // public DateTime? DateCreated { get; set; }
    //
    // public DateTime? UpdatedAt { get; set; }

}