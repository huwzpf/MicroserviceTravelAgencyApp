namespace contracts;

public interface ITourEvent
{
    Guid HotelId { get; }
    Guid ReservatonId { get; }
    Guid? ToTransportOptionId { get; }
    Guid? FromTransportOptionId { get; }
}