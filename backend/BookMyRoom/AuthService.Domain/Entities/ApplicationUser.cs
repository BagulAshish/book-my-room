using Microsoft.AspNetCore.Identity;

namespace AuthService.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public Guid UserRefId { get; set; } = Guid.NewGuid();
}