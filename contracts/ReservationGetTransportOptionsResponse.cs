
using contracts.Dtos;

namespace contracts;

public record ReservationGetTransportOptionsResponse(IEnumerable<TransportOptionDto> TransportOptions);
