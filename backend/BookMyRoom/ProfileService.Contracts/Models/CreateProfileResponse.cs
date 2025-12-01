using ProtoBuf;

namespace ProfileService.Contracts.Models;

[ProtoContract]
public class CreateProfileResponse
{
    [ProtoMember(1)]
    public Guid Id { get; set; }
    
    [ProtoMember(2)]
    public Guid UserId { get; set; }
    
    [ProtoMember(3)]
    public string? FullName { get; set; }
}