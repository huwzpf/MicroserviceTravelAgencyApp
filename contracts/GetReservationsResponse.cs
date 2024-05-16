
using contracts.Dtos;

namespace contracts;

public record GetReservationsResponse(IEnumerable<ReservationDto> Reservations);
