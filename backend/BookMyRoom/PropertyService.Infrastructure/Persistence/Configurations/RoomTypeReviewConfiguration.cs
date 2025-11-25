using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypeReviewConfiguration : IEntityTypeConfiguration<RoomTypeReview>
{
    public void Configure(EntityTypeBuilder<RoomTypeReview> builder)
    {
        builder.ToTable("room_type_reviews");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomTypeId).HasColumnName("room_type_id");
        builder.Property(x => x.Stars).HasColumnName("stars");
        builder.Property(x => x.Description).HasMaxLength(1500).HasColumnName("description");
        
        builder.HasMany(x => x.RoomTypeReviewPhotos).WithOne(x => x.RoomTypeReview).HasForeignKey(x => x.RoomTypeReviewId);
    }
}

