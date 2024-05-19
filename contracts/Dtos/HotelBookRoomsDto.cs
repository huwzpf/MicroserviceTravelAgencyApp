
namespace contracts.Dtos;

public class HotelBookRoomsDto
{
    public Guid Id { get; set; }
    public DateTime Start { get; set; }
    public int NumberOfNights { get; set; }
    public Dictionary<int, int> Sizes { get; set; }
}
