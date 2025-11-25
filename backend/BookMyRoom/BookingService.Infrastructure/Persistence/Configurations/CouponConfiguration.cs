using BookingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingService.Infrastructure.Persistence.Configurations;

public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
{
    public void Configure(EntityTypeBuilder<Coupon> builder)
    {
        builder.ToTable("coupons");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Code).HasMaxLength(25).HasColumnName("code");
        builder.Property(x => x.CouponType).HasColumnName("coupon_type");
        builder.Property(x => x.Discount).HasColumnName("discount");
        builder.Property(x => x.StartDate).HasColumnName("start_date");
        builder.Property(x => x.EndDate).HasColumnName("end_date");
        
        builder.HasMany(x => x.BookingGroupAmountCoupons).WithOne(x => x.Coupon).HasForeignKey(x => x.CouponId);
    }
}