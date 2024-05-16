
using contracts.Dtos;

namespace contracts;

public record TransportOptionSearchResponse(IEnumerable<TransportOptionDto> TransportOptions);
