using ExpFastEnpoints.ExpFastEndpoints.Core.Common;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities.CommercialPaper;

public class CommercialPaperResponse : BaseEntity
{
    public required string CompanyName { get; set; }
    public double InvestedAmount { get; set; }
    public double InterestRate { get; set; }
    public int Tenure { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime MaturityDate { get; set; }
}