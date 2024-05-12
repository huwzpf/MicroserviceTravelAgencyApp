using apigateway.Dtos.Auth;
using contracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly IRequestClient<LoginRequest> _client;

    public AuthController(ILogger<AuthController> logger, IRequestClient<LoginRequest> client)
    {
        _logger = logger;
        _client = client;
    }
    
    [HttpPost("Login", Name = "PostAuthLogin")]
    public async Task<ActionResult<TokenInfo>> PostLogin(LoginInfo loginInfo)
    {
        var loginResponse = await _client.GetResponse<LoginResponse>(
            new LoginRequest(Username: loginInfo.Username, Password: loginInfo.Password)
            );

        return loginResponse.Message.Token is null 
            ? BadRequest(new ProblemDetails()
            {
                Title = "Bad login credentials,",
                Detail = "Provided credentials do not match any account in the system.",
                Status = 400,
            }) 
            : Ok(new TokenInfo { Token = loginResponse.Message.Token });
    }
}