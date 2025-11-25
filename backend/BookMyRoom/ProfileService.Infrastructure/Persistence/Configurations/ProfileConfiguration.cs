using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProfileService.Domain.Entities;

namespace ProfileService.Infrastructure.Persistence.Configurations;

public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.ToTable("profiles");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.UserId).HasColumnName("user_id");
        builder.Property(x => x.DateOfBirth).HasColumnName("date_of_birth");
        builder.Property(x => x.DisplayName).HasColumnName("display_name");
        builder.Property(x => x.CreatedAt).HasColumnName("created_at");
        builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
        builder.Property(x => x.ProfileImage).HasColumnName("profile_image");
        builder.Property(x => x.Gender).HasColumnName("gender");
        builder.Property(x => x.FullName).IsRequired().HasMaxLength(150).HasColumnName("full_name");
        builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(30).HasColumnName("phone_number");
        
        builder.HasMany(x => x.Addresses)
            .WithOne(x => x.Profile)
            .HasForeignKey(x => x.ProfileId);
    }
}