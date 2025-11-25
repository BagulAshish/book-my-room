using BookingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingService.Infrastructure.Persistence.Configurations;

public class BookingGroupAmountConfiguration : IEntityTypeConfiguration<BookingGroupAmount>
{
    public void Configure(EntityTypeBuilder<BookingGroupAmount> builder)
    {
        builder.ToTable("booking_group_amounts");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.BookingGroupId).HasColumnName("booking_group_id");
        builder.Property(x => x.ActualAmount).HasColumnName("actual_amount");
        builder.Property(x => x.IsCouponApplicable).HasColumnName("is_coupon_applicable");
        builder.Property(x => x.DiscountedAmount).HasColumnName("discounted_amount");
        builder.Property(x => x.TotalAmount).HasColumnName("total_amount");
        
        builder.HasMany(x => x.BookingGroupAmountCoupons).WithOne(x => x.BookingGroupAmount).HasForeignKey(x => x.BookingGroupAmountId);
    }
}