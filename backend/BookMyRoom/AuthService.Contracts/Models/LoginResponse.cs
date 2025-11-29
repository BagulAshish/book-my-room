using ProtoBuf;

namespace AuthService.Contracts.Auth;

[ProtoContract]
public class LoginResponse
{
    [ProtoMember(1)]
    public required bool Success { get; set; }

    [ProtoMember(2)]
    public string? Token { get; set; }

    [ProtoMember(3)]
    public string? UserRefId { get; set; }

    [ProtoMember(4)]
    public string? Message { get; set; }
}