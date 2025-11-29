using ProtoBuf;

namespace AuthService.Contracts.Auth;

[ProtoContract]
public class LoginRequest
{
    [ProtoMember(1)]
    public required string Email {get;set;}

    [ProtoMember(2)]
    public required string Password {get;set;}
}