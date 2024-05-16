
using contracts.Dtos;

namespace contracts;

public record GetPopularDestinationsResponse(IEnumerable<TransportOptionDto> TransportOptions);
