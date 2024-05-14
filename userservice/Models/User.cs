using Microsoft.EntityFrameworkCore;

namespace userservice.Models;

[Index(nameof(Username), IsUnique = true)]
[Index(nameof(AuthToken), IsUnique = true)]
public class User
{
    public Guid Id { get; init; }
    
    public string Username { get; init; }
    
    // Typically hashing would be used but for purposes of this is sufficient
    public string Password { get; init; }
    
    public bool IsAdmin { get; init; }
    
    // Typically JWT or different DB table would be used but for purposes of this is sufficient
    public string? AuthToken { get; set; }

    public User(
        Guid id,
        string username,
        string password, 
        string authToken,
        bool isAdmin
        )
    {
        Id = id;
        Username = username;
        Password = password;
        AuthToken = authToken;
        IsAdmin = isAdmin;
    }
}