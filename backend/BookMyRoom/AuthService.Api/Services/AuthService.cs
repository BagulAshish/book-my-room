using AuthService.Application.Common.Interfaces;
using AuthService.Contracts.Auth;
using AuthService.Contracts.Interfaces;
using AuthService.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Shared.Common;

namespace AuthService.Api.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenService _tokenService;

    public AuthService(
        UserManager<ApplicationUser> userManager,
        ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    public async Task<Response<RegisterResponse>> RegisterAsync(Request<RegisterRequest> request)
    {
        if (request.Data == null)
        {
            return Response<RegisterResponse>.ErrorResponse("Invalid request payload");
        }

        var user = new ApplicationUser()
        {
            UserName = request.Data.Email,
            Email = request.Data.Email,
            PhoneNumber = request.Data.PhoneNumber
        };

        var result = await _userManager.CreateAsync(user, request.Data.Password);
        
        if (!result.Succeeded)
        {
            return Response<RegisterResponse>.ErrorResponse(
                string.Join(",", result.Errors.Select(e => e.Description)));
        }
        
        await _userManager.AddToRoleAsync(user, request.Data.Role);
        
        return Response<RegisterResponse>.SuccessResponse(
            new RegisterResponse()
            {
                Success = true,
                Message = "User registered successfully",
                UserName = user.UserName,
                UserRefId = user.UserRefId.ToString(),
                Email = user.Email
            });
    }

    public async Task<Response<LoginResponse>> LoginAsync(Request<LoginRequest> request)
    {
        if (request.Data == null)
        {
            return Response<LoginResponse>.ErrorResponse("Invalid request payload");
        }

        var user = await _userManager.FindByEmailAsync(request.Data.Email);
        
        if (user == null || !await _userManager.CheckPasswordAsync(user, request.Data.Password))
        {
            return Response<LoginResponse>.ErrorResponse("Invalid email or password");
        }
        
        var token = await _tokenService.GenerateToken(user);
        
        if (token.Data == null)
        {
            return Response<LoginResponse>.ErrorResponse("Failed to generate token");
        }
        
        return Response<LoginResponse>.SuccessResponse(
            new LoginResponse()
            {
                Success = true,
                Token = token.Data,
                UserRefId = user.UserRefId.ToString(),
                Message = "Login successful"
            });
    }
}