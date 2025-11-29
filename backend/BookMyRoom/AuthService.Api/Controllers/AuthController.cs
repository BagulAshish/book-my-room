using System.ServiceModel;
using AuthService.Contracts.Auth;
using AuthService.Contracts.Interfaces;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Shared.Common;
using LoginRequest = AuthService.Contracts.Auth.LoginRequest;
using RegisterRequest = AuthService.Contracts.Auth.RegisterRequest;

namespace AuthService.Api.Controllers;

[ApiController]
[Route("auth")]
[ServiceContract]
public class AuthController : ControllerBase, IAuthService
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    
    [HttpPost("register")]
    [OperationContract]
    public async Task<Response<RegisterResponse>> RegisterAsync(Request<RegisterRequest> request)
    {
        return await _authService.RegisterAsync(request);
    }

    [HttpPost("login")]
    [OperationContract]
    public async Task<Response<LoginResponse>> LoginAsync(Request<LoginRequest> request)
    {
        return await _authService.LoginAsync(request);
    }
}