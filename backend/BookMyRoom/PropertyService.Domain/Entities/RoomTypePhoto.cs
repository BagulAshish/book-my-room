namespace PropertyService.Domain.Entities;

public class RoomTypePhoto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeId { get; set; }
    public string? Photo { get; set; }

    public RoomType? RoomType { get; set; }
}