namespace PropertyService.Domain.Entities;

public class PropertyAddress
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public Guid PropertyId { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? Area { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }

    public Property? Property { get; set; }
}