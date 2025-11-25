using PropertyService.Domain.Enums;

namespace PropertyService.Domain.Entities;

public class Property
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public string? Name { get; set; }
    public string? Company { get; set; }
    public Guid OwnerId { get; set; }
    public PropertyType PropertyType { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public ICollection<RoomType>? RoomTypes { get; set; }
    public PropertyRule? PropertyRule { get; set; }
    public PropertyAddress? PropertyAddress { get; set; }
    public PropertyStars? PropertyStars { get; set; }
    public PropertyLocation? PropertyLocation { get; set; }
    public ICollection<PropertyPhoto>? PropertyPhotos { get; set; }
    public PropertyFeatured? PropertyFeatured { get; set; }
}