using Microsoft.AspNetCore.Authorization;

namespace Shared.Models;

public class Post
{
    public int PostId { get; set; }
    public User Author { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    
    public Post(){}

    public Post(User author, string title)
    {
        Author = author;
        Title = title;
    }
}