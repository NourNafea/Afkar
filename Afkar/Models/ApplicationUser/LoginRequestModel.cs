using System.ComponentModel.DataAnnotations;

namespace Afkar.Models.ApplicationUser;

public class LoginRequestModel
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }
}