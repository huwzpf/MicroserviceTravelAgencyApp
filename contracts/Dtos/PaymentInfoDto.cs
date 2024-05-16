namespace contracts.Dtos;

public class PaymentInfoDto
{
    public string CreditCardNumber { get; set; }
    public Tuple<string, string> CreditCardExpirationDate { get; set; } // (Month, Year)
    public string CardSecurityCode { get; set; }
}