using ProfileService.Domain.Enums;
using ProtoBuf;

namespace ProfileService.Contracts.Models;

[ProtoContract]
public class CreateProfileRequest
{
    [ProtoMember(1)]
    public Guid UserRefId { get; set; }

    [ProtoMember(2)]
    public string? FullName { get; set; }
    
    [ProtoMember(3)]
    public string? DisplayName { get; set; }
    
    [ProtoMember(4)]
    public Gender Gender { get; set; }
    
    [ProtoMember(5)]
    public DateOnly DateOfBirth { get; set; }
    
    [ProtoMember(6)]
    public string? PhoneNumber { get; set; }
    
    [ProtoMember(7)]
    public string? ProfileImage { get; set; }
}