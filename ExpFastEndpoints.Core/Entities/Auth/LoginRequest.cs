using System.ComponentModel.DataAnnotations;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Auth;

public class LoginRequest
{
    public string Name { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public string Password { get; set; }
}