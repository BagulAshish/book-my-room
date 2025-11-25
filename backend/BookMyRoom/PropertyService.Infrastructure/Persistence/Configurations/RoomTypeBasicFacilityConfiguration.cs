using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypeBasicFacilityConfiguration : IEntityTypeConfiguration<RoomTypeBasicFacility>
{
    public void Configure(EntityTypeBuilder<RoomTypeBasicFacility> builder)
    {
        builder.ToTable("room_type_basic_facilities");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomTypeId).HasColumnName("room_type_id");
        builder.Property(x => x.IsHouseKeeping).HasColumnName("is_house_keeping");
        builder.Property(x => x.IsElevator).HasColumnName("is_elevator");
        builder.Property(x => x.IsParking).HasColumnName("is_parking");
        builder.Property(x => x.IsCommonRoom).HasColumnName("is_common_room");
        builder.Property(x => x.IsSwimmingPool).HasColumnName("is_swimming_pool");
        builder.Property(x => x.IsPowerBackup).HasColumnName("is_power_backup");
        builder.Property(x => x.IsLaundryService).HasColumnName("is_laundry_service");
        builder.Property(x => x.IsLaundryServicePaid).HasColumnName("is_laundry_service_paid");
        builder.Property(x => x.IsNewsPaper).HasColumnName("is_news_paper");
    }
}

