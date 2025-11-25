using BookingService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingService.Infrastructure.Persistence.Configurations;

public class BookingGroupHistoryConfiguration : IEntityTypeConfiguration<BookingGroupHistory>
{
    public void Configure(EntityTypeBuilder<BookingGroupHistory> builder)
    {
        builder.ToTable("booking_group_histories");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.BookingGroupId).HasColumnName("booking_group_id");
        builder.Property(x => x.OldStatus).HasColumnName("old_status");
        builder.Property(x => x.NewStatus).HasColumnName("new_status");
        builder.Property(x => x.ChangedAt).HasColumnName("changed_at");
    }
}