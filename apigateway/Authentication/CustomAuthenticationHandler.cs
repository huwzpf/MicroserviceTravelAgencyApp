using System.Security.Claims;
using System.Text.Encodings.Web;
using contracts;
using MassTransit;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace apigateway.Authentication;

public class BasicAuthenticationOptions : AuthenticationSchemeOptions
{
}
 
public class CustomAuthenticationHandler : AuthenticationHandler<BasicAuthenticationOptions>
{
    private readonly IRequestClient<GetUserRequest> _client;
    
    public CustomAuthenticationHandler(
        IOptionsMonitor<BasicAuthenticationOptions> options, 
        ILoggerFactory logger, 
        UrlEncoder encoder, 
        ISystemClock clock, 
        IRequestClient<GetUserRequest> client) 
        : base(options, logger, encoder, clock)
    {
        _client = client;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey("Authorization"))
            return AuthenticateResult.Fail("Unauthorized");
        
        string token = Request.Headers["Authorization"];
        if (string.IsNullOrEmpty(token))
        {
            return AuthenticateResult.NoResult();
        }
        
        if (string.IsNullOrEmpty(token))
        {
            return AuthenticateResult.Fail("Unauthorized");
        }

        var getUserResponse = await _client.GetResponse<GetUserResponse>(new GetUserRequest(Token: token));
        
        if (getUserResponse.Message.UserId is null)
        {
            return AuthenticateResult.Fail("Unauthorized");
        }
        
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, getUserResponse.Message.UserId.ToString()!),
            new Claim("IsAdmin", getUserResponse.Message.IsAdmin.ToString()!),
        };

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new System.Security.Principal.GenericPrincipal(identity, null);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);
        return AuthenticateResult.Success(ticket);
        
    }
}