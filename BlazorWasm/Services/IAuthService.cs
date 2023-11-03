using System.Security.Claims;
using Shared.Dtos;
using Shared.Models;

namespace BlazorWasm.Services;

public interface IAuthService
{
    public Task LoginAsync(string username, string password);
    public Task LogoutAsync();
    public Task RegisterAsync(User user);
    //Task<User> Create(UserRegistrationDto dto);
    public Task<ClaimsPrincipal> GetAuthAsync();
    public Task PostCreate(Post post);

    Task<UserBasicDto> GetUserByName(string username);

    public Action<ClaimsPrincipal> OnAuthStateChanged { get; set; }
}