using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypeSecurityFacilityConfiguration : IEntityTypeConfiguration<RoomTypeSecurityFacility>
{
    public void Configure(EntityTypeBuilder<RoomTypeSecurityFacility> builder)
    {
        builder.ToTable("room_type_security_facilities");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomTypeId).HasColumnName("room_type_id");
        builder.Property(x => x.IsCctv).HasColumnName("is_cctv");
        builder.Property(x => x.IsSecurityAlarm).HasColumnName("is_security_alarm");
        builder.Property(x => x.IsFireExtinguisher).HasColumnName("is_fire_extinguisher");
        builder.Property(x => x.IsSwimmingPoolSafety).HasColumnName("is_swimming_pool_safety");
    }
}

