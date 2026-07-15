using HotelBookingSystem.Interfaces;
using HotelBookingSystem.Models.Rooms;
using HotelBookingSystem.Specs;

namespace HotelBookingSystem.Models;

public class Hotel
{
    private List<BaseRoom> _rooms = [];
    
    public IReadOnlyList<BaseRoom> Rooms => _rooms;
    
    public void AddRoom(BaseRoom room) => _rooms.Add(room);
    
    public void AddBulkRooms(List<BaseRoom> bulkRooms) => _rooms.AddRange(bulkRooms);

    public IReadOnlyList<BaseRoom> GetAvailableRooms(ISpecification<BaseRoom> spec)
    {
        var availabilitySpec = new AvailabilitySpecification(true);
        var mergedSpec = new AndSpecification<BaseRoom>(spec,availabilitySpec);
        
        IReadOnlyList<BaseRoom> filteredRooms = 
            Rooms
                .Where(mergedSpec.IsSatisfiedBy) 
                .ToList();
        return filteredRooms;
    }
    
    public Hotel() {}
}