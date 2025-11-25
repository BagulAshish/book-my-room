namespace PropertyService.Domain.Entities;

public class RoomTypeReviewPhoto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeReviewId { get; set; }
    public string? ReviewPhoto { get; set; }

    public RoomTypeReview? RoomTypeReview { get; set; }
}