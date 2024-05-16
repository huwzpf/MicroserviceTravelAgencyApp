
using contracts.Dtos;

namespace contracts;

public record HotelBookRoomsResponse(IEnumerable<RoomReservationDto> RoomReservations);
