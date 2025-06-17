using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Extensions;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Pagination;
using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints;

public class InvestmentHousesRequest : PaginationFilter
{
    public string? CompanyName { get; set; }
}

public class GetInvestmentHousesEndpoint(PostgresDatabase postgresDb) : Endpoint<InvestmentHousesRequest, PaginatedResponse<InvestmentHousesResponse>>
{
    public override void Configure()
    {
        Get("exp/investment-houses");
        Summary(s => s.Summary = "Get investment houses");
        // AllowAnonymous();
    }

    public override async Task HandleAsync(InvestmentHousesRequest req, CancellationToken ct)
    {
        var database = postgresDb.InvestmentHouse;
        var investmentHouses = await database
            .OrderByDescending(x => x.Id)
            .ConditionalWhere(req.CompanyName != null, x => x.Name == req.CompanyName)
            .Skip((req.PageNumber - 1) * req.PageSize)
            .Take(req.PageSize)
            .ToListAsync(cancellationToken: ct);

        var totals = investmentHouses.Count();
        var result = investmentHouses.Select(x => new InvestmentHousesResponse
        {
            Id = x.Id,
            DateCreated = x.DateCreated,
            CompanyName = x.Name,
            InstitutionType = x.InstitutionType,
            CompanyRegistrationNumber = x.CompanyRegistrationNumber,
            Tpin = x.Tpin,
            CountryOfIncorporation = x.CountryOfIncorporation,
            DateOfIncorporation = x.DateOfIncorporation,
            PhysicalAddress = x.Address,
            PostalAddress = x.PostalAddress,
            TelephoneNumber = x.TelephoneNumber,
            MobileNumber = x.ContactNumber,
            EmailAddress = x.EmailAddress,
            ContactPersons = x.ContactPersons,
            Directors = x.Directors,
            CertificateOfIncorporation = x.CertificateOfIncorporation,
            TaxClearanceCertificate = x.TaxClearanceCertificate,
            TradingLicense = x.TradingLicense,
            Financials = x.Financials,
        }).ToPagedResponse(totals, req);
        
        await SendOkAsync(result, cancellation: ct);
    }
}