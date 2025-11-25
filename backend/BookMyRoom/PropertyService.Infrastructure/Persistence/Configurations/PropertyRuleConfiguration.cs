using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class PropertyRuleConfiguration : IEntityTypeConfiguration<PropertyRule>
{
    public void Configure(EntityTypeBuilder<PropertyRule> builder)
    {
        builder.ToTable("property_rules");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.PropertyId).HasColumnName("property_id");
        builder.Property(x => x.CheckInTime).HasColumnName("check_in_time");
        builder.Property(x => x.CheckOutTime).HasColumnName("check_out_time");
        builder.Property(x => x.IsCoupleFriendly).HasColumnName("is_couple_friendly");
        builder.Property(x => x.IsBachelorFriendly).HasColumnName("is_bachelor_friendly");
        builder.Property(x => x.IsIdRequired).HasColumnName("is_IdRequired");
        builder.Property(x => x.ArePetsAllowed).HasColumnName("are_pets_allowed");
        builder.Property(x => x.AdditionalRules).HasMaxLength(800).HasColumnName("additional_rules");
    }
}