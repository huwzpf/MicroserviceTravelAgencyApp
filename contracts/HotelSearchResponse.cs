
using contracts.Dtos;

namespace contracts;

public record HotelSearchResponse(IEnumerable<HotelDto> Hotels);
