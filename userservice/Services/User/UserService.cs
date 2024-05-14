using System.Security.Cryptography;
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

        if (user is null)
        {
            return new LoginResponse(Token: null);
        }

        if (user.Password != userInfo.Password)
        {
            return new LoginResponse(Token: null);
        }
        
        byte[] tokenBytes = new byte[64];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(tokenBytes);
        }
        user.AuthToken = Convert.ToBase64String(tokenBytes);

        _dbContext.Update(user);
        _dbContext.SaveChanges();
        
        return new LoginResponse(Token: user.AuthToken);
    }

    public GetUserResponse GetUser(GetUserRequest getUserRequest)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.AuthToken == getUserRequest.Token);

        return user is null
            ? new GetUserResponse(UserId: null, IsAdmin: null)
            : new GetUserResponse(UserId: user.Id, IsAdmin: user.IsAdmin);
    }
}