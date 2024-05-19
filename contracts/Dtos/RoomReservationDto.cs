namespace contracts.Dtos;

public class RoomReservationDto
{
    public Guid Id { get; set; }
    public int Size { get; set; }
    public DateTime Start { get; set; }
    public int NumberOfNights { get; set; }
}