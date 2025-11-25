using PropertyService.Domain.Enums;

namespace PropertyService.Domain.Entities;

public class PropertyStars
{
    public Guid Id { get; set; } =   Guid.NewGuid();
    public Guid PropertyId { get; set; }
    public PropertyStarType PropertyStarType { get; set; }

    public Property? Property { get; set; }
}