using System.ServiceModel;
using AuthService.Contracts.Auth;
using Shared.Common;

namespace AuthService.Contracts.Interfaces;

[ServiceContract]
public interface IAuthService
{
    [OperationContract]
    Task<Response<RegisterResponse>> RegisterAsync(Request<RegisterRequest> request);

    [OperationContract]
    Task<Response<LoginResponse>> LoginAsync(Request<LoginRequest> request);
}