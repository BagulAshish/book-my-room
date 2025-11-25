namespace PropertyService.Domain.Entities;

public class PropertyRule
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public Guid PropertyId { get; set; }
    public TimeOnly CheckInTime { get; set; }
    public TimeOnly CheckOutTime { get; set; }
    public bool IsCoupleFriendly { get; set; }
    public bool IsBachelorFriendly { get; set; }
    public bool IsIdRequired { get; set; }
    public bool ArePetsAllowed { get; set; }
    public string? AdditionalRules { get; set; }

    public Property? Property { get; set; }
}