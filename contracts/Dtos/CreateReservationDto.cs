namespace contracts.Dtos;

public class CreateReservationDto
{
    public Guid UserId { get; set; }
    public int NumAdults { get; set; }
    public int NumUnder3 { get; set; }
    public int NumUnder10 { get; set; }
    public int NumUnder18 { get; set; }
    public Guid ToDestinationTransport { get; set; }
    public Guid Hotel { get; set; }
    public Dictionary<int, int> Rooms { get; set; } // size : number
    public Guid FromDestinationTransport { get; set; }
    public bool WithFood { get; set; }
}