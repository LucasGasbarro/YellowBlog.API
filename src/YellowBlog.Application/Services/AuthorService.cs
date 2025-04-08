using YellowBlog.Application.DTOs.AuthorDto;
using YellowBlog.Application.Interfaces;
using YellowBlog.Domain.Entities;
using YellowBlog.Domain.Interfaces;

namespace YellowBlog.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<int> CreateAuthorAsync(AuthorDtoInput authorDto)
        {
            Author author = authorDto;
            return await _authorRepository.InsertAsync(author);
        }

        public async Task<List<AuthorDtoResponse>> GetAllAsync()
        {
            List<Author> authors = await _authorRepository.GetAllAsync();
            List<AuthorDtoResponse> authorsDtos = new List<AuthorDtoResponse>();
            foreach (var author in authors)
            {
                authorsDtos.Add(author);
            }
            return authorsDtos;
        }

        public async Task<AuthorDtoResponse> GetByIdAsync(int id)
        {
            return await _authorRepository.GetByIdAsync(id);
        }
    }
}
