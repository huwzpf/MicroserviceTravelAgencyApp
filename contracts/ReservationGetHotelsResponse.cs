
using contracts.Dtos;

namespace contracts;

public record ReservationGetHotelsResponse(IEnumerable<HotelDto> Hotels);
