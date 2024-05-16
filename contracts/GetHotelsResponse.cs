
using contracts.Dtos;

namespace contracts;

public record GetHotelsResponse(IEnumerable<HotelDto> Hotels);
