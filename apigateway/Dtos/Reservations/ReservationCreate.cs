using System.ComponentModel.DataAnnotations;


namespace apigateway.Dtos.Reservations;

public class ReservationCreate
{
    public Guid? ToHotelTransportOptionId { get; set; }
    public Guid? FromHotelTransportOptionId { get; set; }
    [Required]
    public Guid HotelId { get; set; }
    
    [Required]
    public int NumberOfAdults { get; set; }
    [Required]
    public int NumberOfUnder3 { get; set; }
    [Required]
    public int NumberOfUnder10 { get; set; }
    [Required]
    public int NumberOfUnder18 { get; set; }
    
    public DateTime? DateTime { get; set; }
    
    public int? NumberOfNights { get; set; }
    
    [Required]
    public bool FoodIncluded { get; set; }
    
    [Required]
    public IEnumerable<ReservationHotelRoom> Rooms { get; set; }
}