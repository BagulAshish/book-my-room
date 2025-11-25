namespace BookingService.Domain.Entities;

public class BookingGroup
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid CustomerId { get; set; }
    public Guid PropertyId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public ICollection<Booking>? Bookings { get; set; }
    public BookingGroupAmount? BookingGroupAmount { get; set; }
    public ICollection<BookingGroupHistory>? BookingGroupHistories { get; set; }
}