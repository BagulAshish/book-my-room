using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypeDiscountConfiguration : IEntityTypeConfiguration<RoomTypeDiscount>
{
    public void Configure(EntityTypeBuilder<RoomTypeDiscount> builder)
    {
        builder.ToTable("room_type_discounts");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomTypeId).HasColumnName("room_type_id");
        builder.Property(x => x.Name).HasMaxLength(150).HasColumnName("name");
        builder.Property(x => x.Rate).HasColumnName("rate");
    }
}

