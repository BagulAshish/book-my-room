using System.ServiceModel;
using Microsoft.AspNetCore.Mvc;
using ProfileService.Application.Interfaces;
using ProfileService.Contracts.Interfaces;
using ProfileService.Contracts.Models;
using Shared.Common;

namespace ProfileService.Api.Controllers;

[ApiController]
[Route("profile")]
[ServiceContract]
public class ProfileGrpcController : ControllerBase, IProfileGrpcService
{
    private readonly IProfileService _profileService;
    
    public ProfileGrpcController(IProfileService profileService)
    {
        _profileService = profileService;
    }
    
    [HttpPost("create")]
    [OperationContract]
    public async Task<Response<CreateProfileResponse>> CreateProfileAsync(Request<CreateProfileRequest> request)
    {
        return await _profileService.CreateProfileAsync(request);
    }
}