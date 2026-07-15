using HotelBookingSystem.Interfaces;
using HotelBookingSystem.Models.Rooms;

namespace HotelBookingSystem.Specs;

public class PriceSpecification(decimal price, string op) : ISpecification<BaseRoom>
{
    public bool IsSatisfiedBy(BaseRoom obj)
    {
        return op switch
        {
            "<"  => obj.PricePerNight < price,
            "<=" => obj.PricePerNight <= price,
            ">"  => obj.PricePerNight > price,
            ">=" => obj.PricePerNight >= price,
            "==" => obj.PricePerNight == price,
            "!=" => obj.PricePerNight != price,
            _ => throw new ArgumentException(
                $"Unsupported operator '{op}'. Supported operators are: <, <=, >, >=, ==, !=")
        };
    }
}