using BookingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingService.Infrastructure.Persistence.Configurations;

public class BookingGroupConfiguration : IEntityTypeConfiguration<BookingGroup>
{
    public void Configure(EntityTypeBuilder<BookingGroup> builder)
    {
        builder.ToTable("booking_groups");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.CustomerId).HasColumnName("customer_id");
        builder.Property(x => x.CreatedAt).HasColumnName("created_at");
        builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
        builder.Property(x => x.PropertyId).HasColumnName("property_id");
        builder.Property(x => x.CheckInDate).HasColumnName("check_in_date");
        builder.Property(x => x.CheckOutDate).HasColumnName("check_out_date");
        
        builder.HasMany(x => x.Bookings).WithOne(x => x.BookingGroup).HasForeignKey(x => x.BookingGroupId);
        builder.HasMany(x => x.BookingGroupHistories).WithOne(x => x.BookingGroup).HasForeignKey(x => x.BookingGroupId);
        builder.HasOne(x => x.BookingGroupAmount).WithOne(x => x.BookingGroup).HasForeignKey<BookingGroupAmount>(x => x.BookingGroupId);
    }
}