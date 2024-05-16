using contracts.Dtos;
namespace contracts;

public record BuyRequest(Guid ReservationId, PaymentInfoDto PaymentInfo);
