﻿using System.ComponentModel.DataAnnotations;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
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
    public List<InvestmentHouse.ContactPerson> ContactPersons { get; set; } = new();
    public List<InvestmentHouse.Director> Directors { get; set; } = new();
    public Boolean? CertificateOfIncorporation {get;set;}
    public Boolean? TaxClearanceCertificate {get;set;}
    public Boolean? TradingLicense {get;set;}
    public Boolean? Financials {get;set;}
    
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