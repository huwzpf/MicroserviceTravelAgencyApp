using contracts;
using userservice.Persistence;

namespace userservice.Services.User;

public class UserService
{
    private readonly UserDbContext _dbContext;

    public UserService(UserDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    private Models.User? GetUser(string username)
    {
        return _dbContext.Users.FirstOrDefault(u => u.Username == username);
    }

    public LoginResponse Login(LoginRequest userInfo)
    {
        var user = GetUser(userInfo.Username);
        // TODO verify password
        return user is null ? new LoginResponse(Token: null) : new LoginResponse(Token: "TOKEN");
    }
}