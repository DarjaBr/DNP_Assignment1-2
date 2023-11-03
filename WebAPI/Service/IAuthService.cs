using Shared.Dtos;
using Shared.Models;

namespace WebAPI.Service;

public interface IAuthService
{
    Task<User> GetUser(string username, string password);
    Task RegisterUser(UserRegistrationDto dto);

    Task<User> ValidateUser(string username, string password);
}