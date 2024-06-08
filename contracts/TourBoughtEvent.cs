namespace contracts;
public record TourBoughtEvent(Guid HotelId, Guid ReservatonId, Guid? ToTransportOptionId, Guid? FromTransportOptionId) : ITourEvent;