using AuthService.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace AuthService.Infrastructure.Seed;

public class IdentitySeeder
{
    private static readonly string[] Roles = new[]
    {
        "Admin",
        "Owner",
        "Customer"
    };

    public static async Task SeedAsync(
        UserManager<ApplicationUser> userManager, 
        RoleManager<IdentityRole> roleManager)
    {
        foreach (var role in Roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }
    }
}