using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class PropertyAddressConfiguration : IEntityTypeConfiguration<PropertyAddress>
{
    public void Configure(EntityTypeBuilder<PropertyAddress> builder)
    {
        builder.ToTable("property_addresses");
     
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.PropertyId).HasColumnName("property_id");
        builder.Property(x => x.AddressLine1).HasMaxLength(300).HasColumnName("address_line1");
        builder.Property(x => x.AddressLine2).HasMaxLength(300).HasColumnName("address_line2");
        builder.Property(x => x.Area).HasColumnName("area");
        builder.Property(x => x.City).HasColumnName("city");
        builder.Property(x => x.State).HasColumnName("state");
        builder.Property(x => x.Country).HasColumnName("country");
        builder.Property(x => x.ZipCode).HasMaxLength(30).HasColumnName("zip_code");
    }
}