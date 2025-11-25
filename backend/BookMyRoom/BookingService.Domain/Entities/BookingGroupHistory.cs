using BookingService.Domain.Enums;

namespace BookingService.Domain.Entities;

public class BookingGroupHistory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BookingGroupId { get; set; }
    public BookingStatus OldStatus { get; set; }
    public BookingStatus NewStatus { get; set; }
    public DateTime ChangedAt { get; set; }
    
    public BookingGroup? BookingGroup { get; set; }
}