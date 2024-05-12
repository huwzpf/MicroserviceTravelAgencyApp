using userservice.Models;

namespace userservice.Dtos;

public record UserWithoutPasswordDto(Guid Id, string Username)
{
    public static UserWithoutPasswordDto FromModel(User user)
    {
        return new UserWithoutPasswordDto(
            Id: user.Id,
            Username: user.Username
        );
    }
}