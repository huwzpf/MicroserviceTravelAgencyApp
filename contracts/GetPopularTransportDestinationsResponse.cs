
using contracts.Dtos;

namespace contracts;

public record GetPopularTransportDestinationsResponse(Dictionary<string, List<string>> PopularCities);
