using System.ComponentModel.DataAnnotations;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities;

public class InvestmentHousesResponse : BaseEntity
{
    public string CompanyName { get; set; } = null!;

    public string PhysicalAddress { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;
    public string? InstitutionType {get;set;}
    public string? CompanyRegistrationNumber {get;set;}
    public string? Tpin {get;set;}
    public string? CountryOfIncorporation {get;set;}
    public DateOnly? DateOfIncorporation {get;set;}
    public string? PostalAddress {get;set;}
    public string? TelephoneNumber {get;set;} //existing field
    [EmailAddress]
    public string? EmailAddress {get;set;}
    public ICollection<InvestmentHouse.ContactPerson> ContactPersons { get; set; } = new List<InvestmentHouse.ContactPerson> ();
    public ICollection<InvestmentHouse.Director>  Directors { get; set; } = new List<InvestmentHouse.Director>();
    public Boolean? CertificateOfIncorporation {get;set;}
    public Boolean? TaxClearanceCertificate {get;set;}
    public Boolean? TradingLicense {get;set;}
    public Boolean? Financials {get;set;}
}