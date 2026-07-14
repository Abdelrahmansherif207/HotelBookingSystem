using HotelBookingSystem.Enums;

namespace HotelBookingSystem.Models.Rooms;

public class Suite : BaseRoom
{
    protected override decimal RoomPriceRatio { get; } = 6m;
    
    public Suite() : base(RoomTypeEnum.Suite)
    {
        this.PricePerNight = this.CalculatePricePerNight();
        this.MaxOccupancy = OccupyEnum.Suite;
    }
    protected override decimal CalculatePricePerNight()
    {
        return this.BasePrice * RoomPriceRatio;
    }
}