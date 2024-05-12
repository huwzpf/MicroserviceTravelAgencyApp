using System.ComponentModel.DataAnnotations;

namespace apigateway.Dtos.Auth;

public class LoginInfo
{   
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}
