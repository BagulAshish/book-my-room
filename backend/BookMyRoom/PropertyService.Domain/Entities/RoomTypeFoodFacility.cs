namespace PropertyService.Domain.Entities;

public class RoomTypeFoodFacility
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeId { get; set; }
    public bool IsFreeBreakfast { get; set; }
    public bool IsRestaurant  { get; set; }
    public bool IsBar { get; set; }
    public bool IsPureVegetarian { get; set; }
    public bool IsJain { get; set; }
    public bool IsFastingFoodAvailable { get; set; }
    
    public RoomType? RoomType { get; set; }
}