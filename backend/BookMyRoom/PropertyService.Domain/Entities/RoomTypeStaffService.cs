namespace PropertyService.Domain.Entities;

public class RoomTypeStaffService
{
    public Guid Id { get; set; }
    public Guid RoomTypeId { get; set; }
    public bool IsLuggageAssist { get; set; }
    public bool IsFullDayRoomService { get; set; }
    public bool IsWheelchairAvailable { get; set; }
    public bool IsConcierge { get; set; }
    public bool IsDoctorOnCall { get; set; }

    public RoomType? RoomType { get; set; }
}