using System.ComponentModel.DataAnnotations;
using apigateway.Dtos.TransportOptions;

namespace apigateway.Dtos.Tours;

public class Tour
{
    public Guid? ToHotelTransportOptionId { get; set; }
    [Required]
    public Guid FromHotelTransportOptionId { get; set; }
    public Guid? HotelId { get; set; }
    
    [Required]
    public string HotelName { get; set; }
    
    [Required]
    public string HotelCity { get; set; }
    
    [Required]
    public TypeOfTransport TypeOfTransport { get; set; }
    
    public string? FromCity { get; set; }
    
    [Required]
    public DateTime DateTime { get; set; }
    
    [Required]
    public int NumberOfNights { get; set; }
}