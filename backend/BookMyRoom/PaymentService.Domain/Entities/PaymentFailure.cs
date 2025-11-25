namespace PaymentService.Domain.Entities;

public class PaymentFailure
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PaymentId { get; set; }
    public string? Reason { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public Payment? Payment { get; set; }
}