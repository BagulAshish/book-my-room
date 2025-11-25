namespace PropertyService.Domain.Entities;

public class RoomType
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public Guid PropertyId { get; set; }
    public string? Name { get; set; }
    public int? AdultsCapacity { get; set; }
    public int? ChildrenCapacity { get; set; }
    public string? Description { get; set; }
    public double? BasePrice { get; set; }
    public double? DiscountPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Property? Property { get; set; }
    public ICollection<Room>? Rooms { get; set; }
    public RoomTypeBasicFacility?  RoomTypeBasicFacility { get; set; }
    public RoomTypeFoodFacility?  RoomTypeFoodFacility { get; set; }
    public RoomTypeStaffService?  RoomTypeStaffService { get; set; }
    public RoomTypeSecurityFacility? RoomTypeSecurityFacility{ get; set; }
    public ICollection<RoomTypeOtherFacility>? RoomTypeOtherFacilities { get; set; }
    public ICollection<RoomTypePhoto>? RoomTypePhotos { get; set; }
    public ICollection<RoomTypeReview>? RoomTypeReviews { get; set; }
    public ICollection<RoomTypeDiscount>?  RoomTypeDiscounts { get; set; }
}