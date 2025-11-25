using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class PropertyStarsConfiguration : IEntityTypeConfiguration<PropertyStars>
{
    public void Configure(EntityTypeBuilder<PropertyStars> builder)
    {
        builder.ToTable("property_stars");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.PropertyId).HasColumnName("property_id");
        builder.Property(x => x.PropertyStarType).HasColumnName("property_star_type");
    }
}