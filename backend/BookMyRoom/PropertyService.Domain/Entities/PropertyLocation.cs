namespace PropertyService.Domain.Entities;

public class PropertyLocation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PropertyId { get; set; }
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }

    public Property? Property { get; set; }
}