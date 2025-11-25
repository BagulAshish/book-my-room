using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class PropertyLocationConfiguration : IEntityTypeConfiguration<PropertyLocation>
{
    public void Configure(EntityTypeBuilder<PropertyLocation> builder)
    {
        builder.ToTable("property_locations");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.PropertyId).HasColumnName("property_id");
        builder.Property(x => x.Longitude).HasMaxLength(50).IsRequired().HasColumnName("longitude");
        builder.Property(x => x.Latitude).HasMaxLength(50).IsRequired().HasColumnName("latitude");
    }
}
