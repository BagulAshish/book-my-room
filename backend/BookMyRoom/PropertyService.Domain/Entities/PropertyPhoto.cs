namespace PropertyService.Domain.Entities;

public class PropertyPhoto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PropertyId { get; set; }
    public string? Photo { get; set; }

    public Property? Property { get; set; }
}