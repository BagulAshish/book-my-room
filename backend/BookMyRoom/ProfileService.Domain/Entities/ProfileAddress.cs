namespace ProfileService.Domain.Entities;

public class ProfileAddress
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public Guid ProfileId { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? Area { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }

    public Profile? Profile { get; set; }
}