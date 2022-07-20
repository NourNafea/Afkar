using Microsoft.AspNetCore.Identity;

namespace Afkar.Entities;

public class ApplicationUser : IdentityUser
{
    public DateTime? Birthdate {get; set; }
}