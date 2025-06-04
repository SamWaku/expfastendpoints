using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class InvestmentHouseRequest 
{
    public string? CompanyName {get;set;}
    public string? InstitutionType {get;set;}
    public string? CompanyRegistrationNumber {get;set;}
    public string? Tpin {get;set;}
    public string? CountryOfIncorporation {get;set;}
    public DateOnly DateOfIncorporation {get;set;}
    public string? PhysicalAddress {get;set;}
    public string? PostalAddress {get;set;}
    public string? TelephoneNumber {get;set;}
    public string? MobileNumber {get;set;}
    [EmailAddress]
    public string? EmailAddress {get;set;}
    protected List<ContactPerson> ContactPersons { get; set; } = new();
    protected List<Director> Directors { get; set; } = new();
    public Boolean? CertificateOfIncorporation {get;set;}
    public Boolean? TaxClearanceCertificate {get;set;}
    public Boolean? TradingLicense {get;set;}
    public Boolean? Financials {get;set;}
    
    protected class ContactPerson
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Position { get; set; }
    }
    
    protected class Director
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Position { get; set; }
    }
}