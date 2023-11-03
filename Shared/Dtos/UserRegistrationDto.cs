namespace Shared.Dtos;

public class UserRegistrationDto
{
    public int UserId { get; set; }
    public string Username { get; }
    public string Password { get; }

    public UserRegistrationDto(string userName, string password)
    {
        Username = userName;
        Password = password;
    }
}