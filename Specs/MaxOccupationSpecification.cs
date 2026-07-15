using HotelBookingSystem.Enums;
using HotelBookingSystem.Interfaces;
using HotelBookingSystem.Models.Rooms;

namespace HotelBookingSystem.Specs;

public class MaxOccupationSpecification (OccupyEnum occupation) : ISpecification<BaseRoom>
{
    public bool IsSatisfiedBy(BaseRoom obj) => obj.MaxOccupancy == occupation;
}