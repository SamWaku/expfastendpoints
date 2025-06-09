namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities.CommercialPaper;

public class CreateCommercialPaperRequest
{
    public required string CompanyName { get; set; }
    public double InvestedAmount { get; set; }
    public double InterestRate { get; set; }
    public int Tenure { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly MaturityDate { get; set; }
}