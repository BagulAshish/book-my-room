namespace BookingService.Domain.Entities;

public class BookingGuest
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BookingId { get; set; }
    public string? FullName { get; set; }
    public int Age { get; set; }
    
    public Booking? Booking { get; set; }
}