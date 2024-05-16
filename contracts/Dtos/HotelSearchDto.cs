
namespace contracts.Dtos;

public class HotelSearchDto
{
    public int? MinimumGuests { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public DateTime? MinStart { get; set; }
    public DateTime? MaxEnd { get; set; }
    public int? MinDuration { get; set; }
    public int? MaxDuration { get; set; }
}
