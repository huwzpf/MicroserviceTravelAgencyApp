
using contracts.Dtos;

namespace contracts;

public record GetAvailableToursResponse(IEnumerable<TourDto> Tours);
