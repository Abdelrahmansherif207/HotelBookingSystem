using HotelBookingSystem.Enums;

namespace HotelBookingSystem.Models.Rooms;

public abstract class BaseRoom
{
    public Guid RoomNumber { get; }
    
    protected readonly decimal BasePrice = 50m;
    
    public required RoomTypeEnum RoomType { get; set; }

    public decimal PricePerNight { get; set; }

    public OccupyEnum MaxOccupancy { get; set; } = OccupyEnum.Single;
    
    protected abstract decimal RoomPriceRatio { get; }

    protected BaseRoom(RoomTypeEnum roomType)
    {
        this.RoomNumber = Guid.NewGuid();
        this.RoomType = roomType;
        this.PricePerNight = BasePrice;
    }
    
    protected abstract decimal CalculatePricePerNight();

}
