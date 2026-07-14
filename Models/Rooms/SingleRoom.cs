using HotelBookingSystem.Enums;

namespace HotelBookingSystem.Models.Rooms;

public class SingleRoom : BaseRoom
{
    protected override decimal RoomPriceRatio { get;} = 1.5m;
    
    public SingleRoom() : base(RoomTypeEnum.Single)
    {
        this.PricePerNight = this.CalculatePricePerNight();
        this.MaxOccupancy = OccupyEnum.Single;
    }

    protected override decimal CalculatePricePerNight()
    {
        return this.BasePrice * this.RoomPriceRatio;
    }
}