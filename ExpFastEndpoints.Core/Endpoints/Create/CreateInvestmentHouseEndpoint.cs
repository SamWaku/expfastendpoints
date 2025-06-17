using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using FastEndpoints;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints;

public class InvestmentHouseResponse
{
    public string Message { get; set; }
}

public class CreateInvestmentHouseEndpoint(PostgresDatabase postgresDb) : Endpoint<InvestmentHouseRequest, InvestmentHouseResponse>
{
    public override void Configure()
    {
        Post("exp/create-investment-house");
        Summary(s => s.Summary = "Create Investment House");
        // AllowAnonymous();
    }

    public override async Task HandleAsync(InvestmentHouseRequest req, CancellationToken ct)
    {
        var database = postgresDb;
        var newInvestmentHouse = new InvestmentHouse
        {
            Name = req.CompanyName,
            InstitutionType = req.InstitutionType,
            CompanyRegistrationNumber = req.CompanyRegistrationNumber,
            Tpin = req.Tpin,
            CountryOfIncorporation = req.CountryOfIncorporation,
            DateOfIncorporation = req.DateOfIncorporation,
            Address = req.PhysicalAddress,
            PostalAddress = req.PostalAddress,
            TelephoneNumber = req.TelephoneNumber,
            ContactNumber =  req.MobileNumber,
            EmailAddress = req.EmailAddress,
            ContactPersons = req.ContactPersons,
            Directors = req.Directors,
            CertificateOfIncorporation = req.CertificateOfIncorporation,
            TaxClearanceCertificate = req.TaxClearanceCertificate,
            TradingLicense = req.TradingLicense,
            Financials = req.Financials,
        };

        database.Set<InvestmentHouse>().Add(newInvestmentHouse);
        await database.SaveChangesAsync(cancellationToken: ct);
        await SendOkAsync(new InvestmentHouseResponse
        {
            Message = "Investment House Created",
        });
    }
}