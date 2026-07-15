using HotelBookingSystem.Interfaces;
using HotelBookingSystem.Models.Rooms;

namespace HotelBookingSystem.Specs;

public class AndSpecification<T>(params ISpecification<T>[] specs) : ISpecification<T>
{
    public bool IsSatisfiedBy(T obj) => specs.All(spec => spec.IsSatisfiedBy(obj));
}