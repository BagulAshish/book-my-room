using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypeReviewPhotoConfiguration : IEntityTypeConfiguration<RoomTypeReviewPhoto>
{
    public void Configure(EntityTypeBuilder<RoomTypeReviewPhoto> builder)
    {
        builder.ToTable("room_type_review_photos");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomTypeReviewId).HasColumnName("room_type_review_id");
        builder.Property(x => x.ReviewPhoto).HasMaxLength(500).HasColumnName("review_photo");
    }
}

