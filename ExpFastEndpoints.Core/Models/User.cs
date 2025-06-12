using System.ComponentModel.DataAnnotations;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Models;

public class User : BaseEntity
{
    public string Name { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}