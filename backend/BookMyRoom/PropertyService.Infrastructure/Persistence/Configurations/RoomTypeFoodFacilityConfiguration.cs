using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypeFoodFacilityConfiguration : IEntityTypeConfiguration<RoomTypeFoodFacility>
{
    public void Configure(EntityTypeBuilder<RoomTypeFoodFacility> builder)
    {
        builder.ToTable("room_type_food_facilities");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomTypeId).HasColumnName("room_type_id");
        builder.Property(x => x.IsFreeBreakfast).HasColumnName("is_free_breakfast");
        builder.Property(x => x.IsRestaurant).HasColumnName("is_restaurant");
        builder.Property(x => x.IsBar).HasColumnName("is_bar");
        builder.Property(x => x.IsPureVegetarian).HasColumnName("is_pure_vegetarian");
        builder.Property(x => x.IsJain).HasColumnName("is_jain");
        builder.Property(x => x.IsFastingFoodAvailable).HasColumnName("is_fasting_food_available");
    }
}

