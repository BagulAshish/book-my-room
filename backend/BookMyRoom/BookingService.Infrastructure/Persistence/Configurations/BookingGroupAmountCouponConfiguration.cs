using BookingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingService.Infrastructure.Persistence.Configurations;

public class BookingGroupAmountCouponConfiguration : IEntityTypeConfiguration<BookingGroupAmountCoupon>
{
    public void Configure(EntityTypeBuilder<BookingGroupAmountCoupon> builder)
    {
        builder.ToTable("booking_group_amount_coupons");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.BookingGroupAmountId).HasColumnName("booking_group_amount_id");
        builder.Property(x => x.CouponId).HasColumnName("coupon_id");
    }
}