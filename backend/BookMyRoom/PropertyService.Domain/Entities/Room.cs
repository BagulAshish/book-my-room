using PropertyService.Domain.Enums;

namespace PropertyService.Domain.Entities;

public class Room
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeId { get; set; }
    public string? Name { get; set; }
    public RoomStatus RoomStatus { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public RoomType? RoomType { get; set; }
    public RoomAmenity? RoomAmenity { get; set; }
}