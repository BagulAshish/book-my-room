namespace PropertyService.Domain.Entities;

public class RoomTypeDiscount
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeId { get; set; }
    public string? Name { get; set; }
    public double Rate { get; set; }

    public RoomType? RoomType { get; set; }
}