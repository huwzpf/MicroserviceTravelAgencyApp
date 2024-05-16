
using contracts.Dtos;

namespace contracts;

public record GetTransportOptionsResponse(IEnumerable<TransportOptionDto> TransportOptions);
