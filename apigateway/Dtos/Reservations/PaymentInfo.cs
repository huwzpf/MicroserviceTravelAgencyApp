using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Reservations;

public class PaymentInfo
{
    [Required]
    public string CreditCardNumber { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime ExpirationDate { get; set; }
    
    [Required]
    public string SecurityNumber { get; set; }
}