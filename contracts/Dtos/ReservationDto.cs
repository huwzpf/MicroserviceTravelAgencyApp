namespace contracts.Dtos;

public class ReservationDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public int NumAdults { get; set; }
    public int NumUnder3 { get; set; }
    public int NumUnder10 { get; set; }
    public int NumUnder18 { get; set; }
    public Guid ToDestinationTransport { get; set; }
    public List<Guid> HotelRoomReservations { get; set; }
    public Guid FromDestinationTransport { get; set; }
    public bool Finalized { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public string ToCity { get; set; }
    public string? FromCity { get; set; }
    public string TransportType { get; set; } // "Airplane", "Train", "Bus"
    public DateTime? ReservedUntil { get; set; }
}