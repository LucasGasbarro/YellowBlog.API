using YellowBlog.Application.DTOs.AuthorDto;
using YellowBlog.Domain.Entities;

namespace YellowBlog.Application.Interfaces
{
    public interface IAuthorService
    {
        Task<int> CreateAuthorAsync(AuthorDtoInput authorDto);
        Task<AuthorDtoResponse> GetByIdAsync(int id);
        Task<List<AuthorDtoResponse>> GetAllAsync();
    }
}
