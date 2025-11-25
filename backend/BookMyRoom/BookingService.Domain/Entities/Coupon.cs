using BookingService.Domain.Enums;

namespace BookingService.Domain.Entities;

public class Coupon
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Code { get; set; }
    public CouponType CouponType { get; set; }
    public decimal Discount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public ICollection<BookingGroupAmountCoupon>? BookingGroupAmountCoupons { get; set; }
}