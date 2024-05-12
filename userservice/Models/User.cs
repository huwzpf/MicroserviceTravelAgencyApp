namespace userservice.Models;

public class User
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public string PasswordHash { get; init; }

    public User(
        Guid id,
        string username,
        string passwordHash
        )
    {
        Id = id;
        Username = username;
        PasswordHash = passwordHash;
    }
}