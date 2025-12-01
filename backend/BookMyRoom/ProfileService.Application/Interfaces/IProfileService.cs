using ProfileService.Contracts.Models;
using Shared.Common;

namespace ProfileService.Application.Interfaces;

public interface IProfileService
{
    public Task<Response<CreateProfileResponse>> CreateProfileAsync(Request<CreateProfileRequest> request);
}