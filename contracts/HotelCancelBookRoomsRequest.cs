
namespace contracts;

public record HotelCancelBookRoomsRequest(Guid Id, List<Guid> Bookings);
