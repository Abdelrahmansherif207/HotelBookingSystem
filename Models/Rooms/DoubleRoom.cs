using HotelBookingSystem.Enums;

namespace HotelBookingSystem.Models.Rooms;

public class DoubleRoom : BaseRoom
{
    protected override decimal RoomPriceRatio { get; } = 3m;
    
    public DoubleRoom( ) : base(RoomTypeEnum.Double)
    {
        this.PricePerNight = this.CalculatePricePerNight();
        this.MaxOccupancy = OccupyEnum.Double;
    }

    protected override decimal CalculatePricePerNight()
    {
        return this.BasePrice * this.RoomPriceRatio;
    }
}