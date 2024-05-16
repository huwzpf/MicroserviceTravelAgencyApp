
namespace contracts;

public record GetAvailableRoomsRequest(Guid HotelId, DateTime Start, DateTime End);
