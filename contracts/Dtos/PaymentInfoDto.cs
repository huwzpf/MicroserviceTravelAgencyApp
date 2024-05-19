namespace contracts.Dtos;

public class PaymentInfoDto
{
    public string CreditCardNumber { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string SecurityNumber { get; set; }
}