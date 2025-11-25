namespace PropertyService.Domain.Entities;

public class RoomTypeSecurityFacility
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeId { get; set; }
    public bool IsCctv { get; set; }
    public bool IsSecurityAlarm { get; set; }
    public bool IsFireExtinguisher { get; set; }
    public bool IsSwimmingPoolSafety { get; set; }

    public RoomType? RoomType { get; set; }
}