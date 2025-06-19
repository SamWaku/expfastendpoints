using System.ComponentModel.DataAnnotations;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Models;

public class InvestmentHouse : BaseEntity
{
    public string? Name {get;set;} //existing field
    public string? InstitutionType {get;set;}
    public string? CompanyRegistrationNumber {get;set;}
    public string? Tpin {get;set;}
    public string? CountryOfIncorporation {get;set;}
    public DateOnly? DateOfIncorporation {get;set;}
    public string? Address {get;set;} //existing field
    public string? PostalAddress {get;set;}
    public string? TelephoneNumber {get;set;} //existing field
    public string? ContactNumber {get;set;}
    [EmailAddress]
    public string? EmailAddress {get;set;}
    public ICollection<ContactPerson> ContactPersons { get; set; } = new List<ContactPerson>();
    public ICollection<Director> Directors { get; set; } = new List<Director>();
    public Boolean? CertificateOfIncorporation {get;set;}
    public Boolean? TaxClearanceCertificate {get;set;}
    public Boolean? TradingLicense {get;set;}
    public Boolean? Financials {get;set;}
    public virtual ICollection<FixedTermDeposit> FixedTermDeposits { get; set; } = new List<FixedTermDeposit>();
    
    [Owned]
    public class ContactPerson
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Position { get; set; }
    }
    
    [Owned]
    public class Director
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Position { get; set; }
    }
}