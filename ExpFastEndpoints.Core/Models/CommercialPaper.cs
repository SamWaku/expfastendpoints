using ExpFastEnpoints.ExpFastEndpoints.Core.Common;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Models;

public class CommercialPaper : BaseEntity
{
    public string CompanyName { get; set; }
    public double InvestedAmount { get; set; }
    public double InterestRate { get; set; }
    public int Tenure { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly MaturityDate { get; set; }
}