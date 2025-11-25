namespace BookingService.Domain.Entities;

public class BookingGroupAmount
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BookingGroupId { get; set; }
    public decimal ActualAmount { get; set; }
    public bool IsCouponApplicable { get; set; }
    public decimal DiscountedAmount { get; set; }
    public decimal TotalAmount { get; set; }
    
    public BookingGroup? BookingGroup { get; set; }
    public ICollection<BookingGroupAmountCoupon>? BookingGroupAmountCoupons { get; set; }
}