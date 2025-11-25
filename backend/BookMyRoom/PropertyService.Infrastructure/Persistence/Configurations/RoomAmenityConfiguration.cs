using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomAmenityConfiguration : IEntityTypeConfiguration<RoomAmenity>
{
    public void Configure(EntityTypeBuilder<RoomAmenity> builder)
    {
        builder.ToTable("room_amenities");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomId).HasColumnName("room_id");
        builder.Property(x => x.IsSofa).HasColumnName("is_sofa");
        builder.Property(x => x.IsAirConditioner).HasColumnName("is_air_conditioner");
        builder.Property(x => x.IsTv).HasColumnName("is_tv");
        builder.Property(x => x.IsRefrigerator).HasColumnName("is_refrigerator");
        builder.Property(x => x.IsToiletries).HasColumnName("is_toiletries");
        builder.Property(x => x.IsDentalKit).HasColumnName("is_dental_kit");
        builder.Property(x => x.IsHairDryer).HasColumnName("is_hair_dryer");
        builder.Property(x => x.IsWorkDesk).HasColumnName("is_work_desk");
        builder.Property(x => x.IsGeyser).HasColumnName("is_geyser");
        builder.Property(x => x.IsBalcony).HasColumnName("is_balcony");
        builder.Property(x => x.IsBathtub).HasColumnName("is_bathtub");
        builder.Property(x => x.IsMineralWater).HasColumnName("is_mineral_water");
        builder.Property(x => x.IsBathTowel).HasColumnName("is_bath_towel");
    }
}