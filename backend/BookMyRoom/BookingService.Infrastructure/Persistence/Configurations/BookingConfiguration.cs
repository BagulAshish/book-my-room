using BookingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingService.Infrastructure.Persistence.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.ToTable("bookings");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.BookingGroupId).HasColumnName("booking_group_id");
        builder.Property(x => x.RoomId).HasColumnName("room_id");
        builder.Property(x => x.CheckInDate).HasColumnName("check_in_date");
        builder.Property(x => x.CheckOutDate).HasColumnName("check_out_date");
        builder.Property(x => x.IsCancelled).HasColumnName("is_cancelled");
        builder.Property(x => x.Adults).HasColumnName("adults");
        builder.Property(x => x.Children).HasColumnName("children");
        
        builder.HasMany(x => x.BookingGuests).WithOne(x => x.Booking).HasForeignKey(x => x.BookingId);
    }
}