using System.ServiceModel;
using ProfileService.Contracts.Models;
using Shared.Common;

namespace ProfileService.Contracts.Interfaces;

[ServiceContract]
public interface IProfileGrpcService
{
    [OperationContract]
    public Task<Response<CreateProfileResponse>> CreateProfileAsync(Request<CreateProfileRequest> request);
}