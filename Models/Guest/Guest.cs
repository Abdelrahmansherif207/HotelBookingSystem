namespace HotelBookingSystem.Models.Guest;

public class Guest(
    string firstName,
    string lastName,
    string email,
    string phoneNumber,
    short familyMembers = 0)
{
    public Guid GuestId { get; } = Guid.NewGuid();

    public string FirstName { get; init; } = firstName;

    public string LastName { get; init; } = lastName;

    public string Email { get; init; } = email;

    public string PhoneNumber { get; init; } = phoneNumber;

    public short FamilyMembers { get; set; } = familyMembers;

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {PhoneNumber}";
    }
}