namespace contracts;

public record TourReservedEvent(Guid HotelId, Guid ReservatonId, Guid? ToTransportOptionId, Guid? FromTransportOptionId);