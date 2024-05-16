namespace contracts.Dtos;

public class RoomReservationDto
{
    public Guid Id { get; set; }
    public int Size { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}