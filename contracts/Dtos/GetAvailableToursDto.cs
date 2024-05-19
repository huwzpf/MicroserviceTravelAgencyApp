namespace contracts.Dtos;

public class GetAvailableToursDto
{
    public int NumPeople { get; set; }
    public string? SourceCity { get; set; }
    public string? SourceCountry { get; set; }
    public string? DestinationCity { get; set; }
    public string? DestinationCountry { get; set; }
    public string? Type { get; set; } // "Plane", "Train", "Bus"
    public DateTime? MinStart { get; set; }
    public DateTime? MaxEnd { get; set; }
    public int? MinDuration { get; set; }
    public int? MaxDuration { get; set; }
}