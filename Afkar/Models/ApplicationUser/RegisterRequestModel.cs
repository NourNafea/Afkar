using System.ComponentModel.DataAnnotations;

namespace Afkar.Models.ApplicationUser;

public class RegisterRequestModel
{
    [Required(ErrorMessage = "User Name is required")]
    public string? UserName { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string? Email { get; set; }

    public DateTime Birthdate { get; set; }
    
    [Required(ErrorMessage = "PhoneNumber is required")]
    [MinLength(11)]
    [RegularExpression("([0-9]+)")] 
    public string? PhoneNumber { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; }

    public string? ConfirmPassword { get; set; }
    
    
}