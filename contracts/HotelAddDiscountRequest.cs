
using contracts.Dtos;

namespace contracts;

public record HotelAddDiscountRequest(Guid Id, DiscountDto Discount);
