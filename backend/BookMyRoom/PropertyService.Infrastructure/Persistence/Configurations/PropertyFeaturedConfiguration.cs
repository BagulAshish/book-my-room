using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class PropertyFeaturedConfiguration : IEntityTypeConfiguration<PropertyFeatured>
{
    public void Configure(EntityTypeBuilder<PropertyFeatured> builder)
    {
        builder.ToTable("property_featured");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.PropertyId).HasColumnName("property_id");
        builder.HasOne(x => x.Property).WithOne(x => x.PropertyFeatured);
    }
}