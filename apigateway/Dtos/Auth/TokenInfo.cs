using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Auth;
public class TokenInfo
{
    [Required]
    public string Token { get; set; }
}