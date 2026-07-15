using HotelBookingSystem.Enums;
using HotelBookingSystem.Interfaces;
using HotelBookingSystem.Models.Rooms;

namespace HotelBookingSystem.Specs;

public class RoomTypeSpecification(RoomTypeEnum roomType) : ISpecification<BaseRoom>
{
    public bool IsSatisfiedBy(BaseRoom obj)
    {
        return obj.RoomType == roomType;
    }
}