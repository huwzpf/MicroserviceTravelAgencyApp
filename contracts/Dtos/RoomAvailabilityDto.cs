namespace contracts.Dtos;

public class AvailableRoomsCount
{
    public int Size { get; set; }
    public int Count { get; set; }
}
public class RoomAvailabilityDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public IEnumerable<AvailableRoomsCount> Rooms { get; set; }
}