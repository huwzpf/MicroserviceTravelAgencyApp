namespace contracts.Dtos;

public class RoomAvailabilityDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public IEnumerable<RoomsCount> Rooms { get; set; }
}