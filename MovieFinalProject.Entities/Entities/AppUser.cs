using Microsoft.AspNetCore.Identity;

namespace MovieFinalProject.DataContext.Entities;

public class AppUser : IdentityUser
{
    public string ? FullName { get; set; }
}
