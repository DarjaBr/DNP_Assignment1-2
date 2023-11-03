using Shared.Dtos;
using Shared.Models;

namespace BlazorWasm.Services;

public interface IPostService
{
    Task CreatePostAsync(PostCreationDto dto);
    Task<ICollection<Post>> GetAsync(
        string? userName, 
        int? userId, 
        bool? completedStatus, 
        string? titleContains
    );
}