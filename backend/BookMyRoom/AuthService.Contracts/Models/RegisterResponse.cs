using ProtoBuf;

namespace AuthService.Contracts.Auth;

[ProtoContract]
public class RegisterResponse
{
    [ProtoMember(1)]
    public bool Success {get;set;}
    
    [ProtoMember(2)]
    public string? Message { get; set; }
    
    [ProtoMember(3)]
    public string? UserName { get; set; }

    [ProtoMember(4)]
    public string? UserRefId { get; set; }
    
    [ProtoMember(5)]
    public string? Email { get; set; }
}