using HotelBookingSystem.Interfaces;
namespace HotelBookingSystem.Specs;

public class OrSpecification<T>(params ISpecification<T> [] specs) : ISpecification<T>
{
    public bool IsSatisfiedBy(T obj) => specs.Any(spec => spec.IsSatisfiedBy(obj));
}