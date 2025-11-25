namespace BookingService.Domain.Entities;

public class Booking
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BookingGroupId { get; set; }
    public Guid RoomId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public bool IsCancelled { get; set; }
    public int Adults { get; set; }
    public int Children { get; set; }
    
    public BookingGroup? BookingGroup { get; set; }
    public ICollection<BookingGuest>? BookingGuests { get; set; }
}