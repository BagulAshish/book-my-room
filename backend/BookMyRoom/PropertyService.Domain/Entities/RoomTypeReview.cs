namespace PropertyService.Domain.Entities;

public class RoomTypeReview
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeId { get; set; }
    public int Stars { get; set; }
    public string? Description { get; set; }

    public RoomType? RoomType { get; set; }
    public ICollection<RoomTypeReviewPhoto>? RoomTypeReviewPhotos { get; set; }
}