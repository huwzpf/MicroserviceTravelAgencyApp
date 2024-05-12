using contracts;
using MassTransit;

using userservice.Services.User;

public class LoginRequestConsumer : IConsumer<LoginRequest>
{
    private readonly ILogger<LoginRequestConsumer> _logger;
    private readonly UserService _userService;
    public LoginRequestConsumer(ILogger<LoginRequestConsumer> logger, UserService userService)
    {
        _logger = logger;
        _userService = userService;
    }
    
    public async Task Consume(ConsumeContext<LoginRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(LoginRequestConsumer), context.Message);
        await context.RespondAsync(_userService.Login(context.Message));
    }
}