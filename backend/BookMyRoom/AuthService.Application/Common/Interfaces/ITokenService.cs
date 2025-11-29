using AuthService.Domain.Entities;
using Shared.Common;

namespace AuthService.Application.Common.Interfaces;

public interface ITokenService
{
    public Task<Response<string>> GenerateToken(ApplicationUser user);
}