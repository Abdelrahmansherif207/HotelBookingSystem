using HotelBookingSystem.Interfaces;
using HotelBookingSystem.Models.Rooms;

namespace HotelBookingSystem.Specs;

public class AvailabilitySpecification(bool isAvailable) : ISpecification<BaseRoom>
{
    public bool IsSatisfiedBy(BaseRoom obj)
    {
        return obj.IsAvailable == isAvailable;
    }
}
