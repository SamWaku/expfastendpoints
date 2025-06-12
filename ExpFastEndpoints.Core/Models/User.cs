using System.ComponentModel.DataAnnotations;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Models;

public class User
{
    public string? Name { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public string? Password { get; set; }
}