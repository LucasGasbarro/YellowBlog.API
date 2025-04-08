using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Author>> GetAllAsync()
        {
            return await _context.Authors.AsNoTracking().OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            return await _context.Authors.AsNoTracking().FirstAsync(x => x.Id == id);
        }

        public async Task<int> InsertAsync(Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return author.Id;

        }
    }
}
