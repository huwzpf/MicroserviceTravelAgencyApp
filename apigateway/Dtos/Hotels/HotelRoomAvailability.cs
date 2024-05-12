using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Hotels;


public class HotelRoomAvailability
{
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public IEnumerable<RoomsCount> Rooms { get; set; }
}