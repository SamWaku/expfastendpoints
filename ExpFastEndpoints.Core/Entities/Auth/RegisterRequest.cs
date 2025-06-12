using System.ComponentModel.DataAnnotations;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Auth;

public class RegisterRequest
{
    public string Name { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}