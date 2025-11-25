namespace BookingService.Domain.Entities;

public class BookingGroupAmountCoupon
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BookingGroupAmountId { get; set; }
    public Guid CouponId { get; set; }
    
    public BookingGroupAmount? BookingGroupAmount { get; set; }
    public Coupon? Coupon { get; set; }
}