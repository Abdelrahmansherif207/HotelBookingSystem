namespace HotelBookingSystem.Interfaces;

public interface ISpecification<in T>
{
    bool IsSatisfiedBy(T obj);
}