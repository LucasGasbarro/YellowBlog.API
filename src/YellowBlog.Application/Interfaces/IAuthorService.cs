using YellowBlog.Application.DTOs;

namespace YellowBlog.Application.Interfaces
{
    public interface IAuthorService
    {
        Task<int> CreateAuthorAsync(AuthorDto authorDto);
    }
}
