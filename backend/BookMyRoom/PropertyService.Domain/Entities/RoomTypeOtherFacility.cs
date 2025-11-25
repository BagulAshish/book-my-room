namespace PropertyService.Domain.Entities;

public class RoomTypeOtherFacility
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeId { get; set; }
    public string? Name { get; set; }
    
    public RoomType? RoomType { get; set; }
}