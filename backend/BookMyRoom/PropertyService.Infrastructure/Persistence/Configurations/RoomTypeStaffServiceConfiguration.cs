using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyService.Domain.Entities;

namespace PropertyService.Infrastructure.Persistence.Configurations;

public class RoomTypeStaffServiceConfiguration : IEntityTypeConfiguration<RoomTypeStaffService>
{
    public void Configure(EntityTypeBuilder<RoomTypeStaffService> builder)
    {
        builder.ToTable("room_type_staff_services");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.RoomTypeId).HasColumnName("room_type_id");
        builder.Property(x => x.IsLuggageAssist).HasColumnName("is_luggage_assist");
        builder.Property(x => x.IsFullDayRoomService).HasColumnName("is_full_day_room_service");
        builder.Property(x => x.IsWheelchairAvailable).HasColumnName("is_wheelchair_available");
        builder.Property(x => x.IsConcierge).HasColumnName("is_concierge");
        builder.Property(x => x.IsDoctorOnCall).HasColumnName("is_doctor_on_call");
    }
}

