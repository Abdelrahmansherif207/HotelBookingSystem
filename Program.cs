using HotelBookingSystem.Enums;
using HotelBookingSystem.Interfaces;
using HotelBookingSystem.Models;
using HotelBookingSystem.Models.Rooms;
using HotelBookingSystem.Specs;

Hotel hotel = new Hotel();

var single1 = new SingleRoom();
var single2 = new SingleRoom();
var double1 = new DoubleRoom();
var double2 = new DoubleRoom();
var suite1 = new Suite();
var suite2 = new Suite();

hotel.AddBulkRooms([single1, single2, double1, double2, suite1, suite2]);

// Mark some rooms unavailable
double2.ToggleAvailability();
suite2.ToggleAvailability();

Console.WriteLine("=== Filter 1: Available Suites ===");
ISpecification<BaseRoom> suiteFilter =
    new RoomTypeSpecification(RoomTypeEnum.Suite);
foreach (var r in hotel.GetAvailableRooms(suiteFilter))
    Console.WriteLine($"  {r.RoomNumber} - {r.RoomType} - ${r.PricePerNight}");

Console.WriteLine("\n=== Filter 2: Available rooms under $150 ===");
ISpecification<BaseRoom> priceFilter =
    new PriceSpecification(150m, "<=");
foreach (var r in hotel.GetAvailableRooms(priceFilter))
    Console.WriteLine($"  {r.RoomNumber} - {r.RoomType} - ${r.PricePerNight}");

Console.WriteLine("\n=== Filter 3: Available Double OR Suite (combined) ===");
ISpecification<BaseRoom> orFilter = new OrSpecification<BaseRoom>(
    new RoomTypeSpecification(RoomTypeEnum.Double),
    new RoomTypeSpecification(RoomTypeEnum.Suite)
);
foreach (var r in hotel.GetAvailableRooms(orFilter))
    Console.WriteLine($"  {r.RoomNumber} - {r.RoomType} - ${r.PricePerNight}");

Console.WriteLine("\n=== Filter 4: Available Single rooms under $100 ===");
ISpecification<BaseRoom> combined = new AndSpecification<BaseRoom>(
    new RoomTypeSpecification(RoomTypeEnum.Single),
    new PriceSpecification(100m, "<")
);
foreach (var r in hotel.GetAvailableRooms(combined))
    Console.WriteLine($"  {r.RoomNumber} - {r.RoomType} - ${r.PricePerNight}");