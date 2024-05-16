namespace contracts.Dtos;

public class TourDto
{
    public Guid ToDestinationTransportOption { get; set; }
    public Guid Hotel { get; set; }
    public Guid FromDestinationTransportOption { get; set; }
    public string TransportType { get; set; } // "Airplane", "Train", "Bus"
    public string FromCity { get; set; }
    public string ToCity { get; set; }
    public DateTime StartDate { get; set; }
    public int DurationDays { get; set; }
}