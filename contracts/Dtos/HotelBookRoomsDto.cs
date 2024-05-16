
namespace contracts.Dtos;

public class HotelBookRoomsDto
{
    public Guid Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public Dictionary<int, int> Sizes { get; set; }
}
