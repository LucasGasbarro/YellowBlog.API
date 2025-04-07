using YellowBlog.Domain.Entities;
using YellowBlog.Domain.Interfaces;
using YellowBlog.Infrastructure.Context;

namespace YellowBlog.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly YellowBlogDbContext _context;
        public AuthorRepository(YellowBlogDbContext context)
        {
            _context = context;
        }

        public Task<List<Author>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertAsync(Author author)
        {
            try
            {
                _context.Authors.Add(author);
                await _context.SaveChangesAsync();
                return author.Id;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
