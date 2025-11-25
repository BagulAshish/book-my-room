using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    {
        builder.ToTable("properties");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Name).HasMaxLength(200).IsRequired().HasColumnName("name");
        builder.Property(x => x.Company).HasMaxLength(200).HasColumnName("company");
        builder.Property(x => x.OwnerId).HasColumnName("owner_id");
        builder.Property(x => x.PropertyType).HasColumnName("property_type");
        builder.Property(x => x.CreatedAt).HasColumnName("created_at");
        builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
    
        builder.HasMany(x => x.RoomTypes).WithOne(x => x.Property).HasForeignKey(x => x.PropertyId);
        builder.HasMany(x => x.PropertyPhotos).WithOne(x => x.Property).HasForeignKey(x => x.PropertyId);
        builder.HasOne(x => x.PropertyRule).WithOne(x => x.Property).HasForeignKey<PropertyRule>(x => x.PropertyId);
        builder.HasOne(x => x.PropertyAddress).WithOne(x => x.Property).HasForeignKey<PropertyAddress>(x => x.PropertyId);
        builder.HasOne(x => x.PropertyLocation).WithOne(x => x.Property).HasForeignKey<PropertyLocation>(x => x.PropertyId);
        builder.HasOne(x => x.PropertyStars).WithOne(x => x.Property).HasForeignKey<PropertyStars>(x => x.PropertyId);
    }
}