using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypePhotoConfiguration : IEntityTypeConfiguration<RoomTypePhoto>
{
    public void Configure(EntityTypeBuilder<RoomTypePhoto> builder)
    {
        builder.ToTable("room_type_photos");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomTypeId).HasColumnName("room_type_id");
        builder.Property(x => x.Photo).HasMaxLength(500).HasColumnName("photo");
    }
}

