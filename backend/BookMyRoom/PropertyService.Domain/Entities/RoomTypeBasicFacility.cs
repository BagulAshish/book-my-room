namespace PropertyService.Domain.Entities;

public class RoomTypeBasicFacility
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid RoomTypeId { get; set; }
    public bool IsHouseKeeping { get; set; }
    public bool IsElevator { get; set; }
    public bool IsParking { get; set; }
    public bool IsCommonRoom { get; set; }
    public bool IsSwimmingPool { get; set; }
    public bool IsPowerBackup { get; set; }
    public bool IsLaundryService { get; set; }
    public bool IsLaundryServicePaid { get; set; }
    public bool IsNewsPaper { get; set; }

    public RoomType? RoomType { get; set; }
}