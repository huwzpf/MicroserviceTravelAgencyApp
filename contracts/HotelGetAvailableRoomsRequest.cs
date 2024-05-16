
using contracts.Dtos;

namespace contracts;

public record HotelGetAvailableRoomsRequest(Guid HotelId, DateTime Start, DateTime End);
