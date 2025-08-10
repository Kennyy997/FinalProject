using Microsoft.AspNetCore.Identity;

namespace MovieFinalProject.DataBase.Entities;

public class AppUser : IdentityUser
{
    public string ? FullName { get; set; }
}
