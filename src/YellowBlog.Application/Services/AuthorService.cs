using YellowBlog.Application.DTOs;
using YellowBlog.Application.Interfaces;
using YellowBlog.Domain.Entities;
using YellowBlog.Domain.Interfaces;

namespace YellowBlog.Application.Services
{
    public  class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<int> CreateAuthorAsync(AuthorDto authorDto)
        {
            Author author = new Author
            {
                Name = authorDto.Name
            };

            return await _authorRepository.InsertAsync(author);
        }
    }
}
