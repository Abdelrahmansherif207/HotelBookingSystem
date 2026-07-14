using HotelBookingSystem.Enums;

namespace HotelBookingSystem.Models.Rooms;

public class DoubleRoom : BaseRoom
{
    protected override decimal RoomPriceRatio { get; } = 3m;
    
    public DoubleRoom(RoomTypeEnum roomType) : base(roomType)
    {
        this.RoomType = roomType;
        this.PricePerNight = this.CalculatePricePerNight();
        this.MaxOccupancy = OccupyEnum.Double;
    }

    protected override decimal CalculatePricePerNight()
    {
        return this.BasePrice * this.RoomPriceRatio;
    }
}