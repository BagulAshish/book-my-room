using ProtoBuf;

namespace AuthService.Contracts.Auth;

[ProtoContract]
public class RegisterRequest
{
    [ProtoMember(1)]
    public required string Email { get; set; }

    [ProtoMember(2)]
    public required string PhoneNumber { get; set; }

    [ProtoMember(3)]
    public required string Password { get; set; }

    [ProtoMember(4)]
    public required string Role { get; set; }
}