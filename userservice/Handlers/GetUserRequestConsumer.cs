using contracts;
using MassTransit;
using userservice.Services.User;

namespace userservice.Handlers;

public class GetUserRequestConsumer : IConsumer<GetUserRequest>
{
    private readonly ILogger<GetUserRequestConsumer> _logger;
    private readonly UserService _userService;
    public GetUserRequestConsumer(ILogger<GetUserRequestConsumer> logger, UserService userService)
    {
        _logger = logger;
        _userService = userService;
    }
    
    public async Task Consume(ConsumeContext<GetUserRequest> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(LoginRequestConsumer), context.Message);
        await context.RespondAsync(_userService.GetUser(context.Message));
    }
}