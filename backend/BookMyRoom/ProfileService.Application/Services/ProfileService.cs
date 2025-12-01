using ProfileService.Application.Interfaces;
using ProfileService.Contracts.Models;
using ProfileService.Domain.Entities;
using ProfileService.Infrastructure.Persistence;
using Shared.Common;

namespace ProfileService.Application.Services;

public class ProfileService : IProfileService
{
    private readonly ProfileDbContext _profileDbContext;

    public ProfileService(ProfileDbContext profileDbContext)
    {
        _profileDbContext = profileDbContext ?? throw new ArgumentNullException(nameof(profileDbContext));
    }

    public async Task<Response<CreateProfileResponse>> CreateProfileAsync(Request<CreateProfileRequest> request)
    {
        if (request.Data == null)
        {
            return Response<CreateProfileResponse>.ErrorResponse("Invalid request");
        }

        var profile = new Profile()
        {
            UserId = request.Data.UserRefId,
            DisplayName = request.Data.DisplayName,
            FullName = request.Data.FullName,
            Gender = request.Data.Gender,
            DateOfBirth = request.Data.DateOfBirth,
            PhoneNumber = request.Data.PhoneNumber,
            ProfileImage = request.Data.ProfileImage,
            CreatedAt = DateTime.UtcNow
        };
        
        var createdProfile = _profileDbContext.Profiles.Add(profile);
        
        await _profileDbContext.SaveChangesAsync();
        
        return Response<CreateProfileResponse>.SuccessResponse(new CreateProfileResponse()
        {
            Id = createdProfile.Entity.Id,
            UserId = createdProfile.Entity.UserId,
            FullName = createdProfile.Entity.FullName
        });
    }
}