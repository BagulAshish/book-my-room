using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProfileService.Domain.Entities;

namespace ProfileService.Infrastructure.Persistence.Configurations;

public class ProfileAddressConfiguration : IEntityTypeConfiguration<ProfileAddress>
{
    public void Configure(EntityTypeBuilder<ProfileAddress> builder)
    {
        builder.ToTable("profile_addresses");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.ProfileId).HasColumnName("profile_id");
        builder.Property(x => x.Area).HasMaxLength(150).HasColumnName("area");
        builder.Property(x => x.City).HasColumnName("city");
        builder.Property(x => x.State).HasColumnName("state");
        builder.Property(x => x.Country).HasColumnName("country");
        builder.Property(x => x.AddressLine1).HasMaxLength(200).HasColumnName("address_line1");
        builder.Property(x => x.AddressLine2).HasMaxLength(200).HasColumnName("address_line2");
        builder.Property(x => x.ZipCode).HasMaxLength(30).HasColumnName("zip_code");;
    }
}