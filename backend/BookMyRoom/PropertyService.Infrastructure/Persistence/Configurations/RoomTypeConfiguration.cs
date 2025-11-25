using Microsoft.EntityFrameworkCore;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RoomType> builder)
    {
        builder.ToTable("room_types");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.PropertyId).HasColumnName("property_id");
        builder.Property(x => x.Name).HasMaxLength(150).HasColumnName("name");
        builder.Property(x => x.Description).HasMaxLength(500).HasColumnName("description");
        builder.Property(x => x.CreatedAt).HasColumnName("created_at");
        builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
        builder.Property(x => x.AdultsCapacity).HasColumnName("adults_capacity");
        builder.Property(x => x.ChildrenCapacity).HasColumnName("children_capacity");
        builder.Property(x => x.BasePrice).HasColumnName("base_price");
        builder.Property(x => x.DiscountPrice).HasColumnName("discount_price");
        
        builder.HasMany(x => x.Rooms).WithOne(x => x.RoomType).HasForeignKey(x => x.RoomTypeId);
        builder.HasMany(x => x.RoomTypeDiscounts).WithOne(x => x.RoomType).HasForeignKey(x => x.RoomTypeId);
        builder.HasMany(x => x.RoomTypeOtherFacilities).WithOne(x => x.RoomType).HasForeignKey(x => x.RoomTypeId);
        builder.HasMany(x => x.RoomTypeReviews).WithOne(x => x.RoomType).HasForeignKey(x => x.RoomTypeId);
        builder.HasMany(x => x.RoomTypePhotos).WithOne(x => x.RoomType).HasForeignKey(x => x.RoomTypeId);
        builder.HasOne(x => x.RoomTypeBasicFacility).WithOne(x => x.RoomType).HasForeignKey<RoomTypeBasicFacility>(x => x.RoomTypeId);
        builder.HasOne(x => x.RoomTypeFoodFacility).WithOne(x => x.RoomType).HasForeignKey<RoomTypeFoodFacility>(x => x.RoomTypeId);
        builder.HasOne(x => x.RoomTypeStaffService).WithOne(x => x.RoomType).HasForeignKey<RoomTypeStaffService>(x => x.RoomTypeId);
        builder.HasOne(x => x.RoomTypeSecurityFacility).WithOne(x => x.RoomType).HasForeignKey<RoomTypeSecurityFacility>(x => x.RoomTypeId);
    }
}