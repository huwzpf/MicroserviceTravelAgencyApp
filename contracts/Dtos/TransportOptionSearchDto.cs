
namespace contracts.Dtos;

public class TransportOptionSearchDto
{
    public string? Type { get; set; }
    public int? SeatsMinimum { get; set; }
    public string? SourceCity { get; set; }
    public string? SourceCountry { get; set; }
    public string? DestinationCity { get; set; }
    public string? DestinationCountry { get; set; }
    public DateTime? MinStart { get; set; }
    public DateTime? MaxEnd { get; set; }
}
