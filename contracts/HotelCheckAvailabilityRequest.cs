
using contracts.Dtos;

namespace contracts;

public record HotelCheckAvailabilityRequest(Guid Id, DateTime Start, DateTime End, int NumPeople);
