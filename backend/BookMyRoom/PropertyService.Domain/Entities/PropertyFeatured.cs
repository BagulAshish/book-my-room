namespace PropertyService.Domain.Entities;

public class PropertyFeatured
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PropertyId { get; set; }

    public Property? Property { get; set; }
}