namespace PropertyService.Domain.Entities;

public class RoomAmenity
{
    public Guid Id { get; set; }
    public Guid RoomId { get; set; }
    public bool IsSofa { get; set; }
    public bool IsAirConditioner { get; set; }
    public bool IsTv { get; set; }
    public bool IsRefrigerator { get; set; }
    public bool IsToiletries { get; set; }
    public bool IsDentalKit { get; set; }
    public bool IsHairDryer { get; set; }
    public bool IsWorkDesk { get; set; }
    public bool IsGeyser { get; set; }
    public bool IsBalcony { get; set; }
    public bool IsBathtub { get; set; }
    public bool IsMineralWater { get; set; }
    public bool IsBathTowel { get; set; }

    public Room? Room { get; set; }
}