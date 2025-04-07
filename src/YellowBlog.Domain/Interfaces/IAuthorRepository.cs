using YellowBlog.Domain.Entities;

namespace YellowBlog.Domain.Interfaces
{
    public interface IAuthorRepository
    {
        Task<int> InsertAsync(Author author);
        Task<Author> GetByIdAsync(int id);
        Task<List<Author>> GetAllAsync();
    }
}
