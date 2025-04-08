using System.Runtime.Serialization;
using YellowBlog.Domain.Entities;

namespace YellowBlog.Application.DTOs.AuthorDto
{
    public class AuthorDtoInput
    {
        public string Name { get; set; }
        private DateTime CreatedAt { get; set; } = DateTime.Now;


        #region Implicit mappers
        public static implicit operator Author(AuthorDtoInput authorDto)
        {
            if (authorDto is null)
                return null;

            return new Author
            {
                Name = authorDto.Name,
                CreatedAt = authorDto.CreatedAt
            };
        }

        public static implicit operator AuthorDtoInput(Author author)
        {
            if (author is null)
                return null;

            return new AuthorDtoInput
            {
                Name = author.Name,
                CreatedAt = author.CreatedAt
            };
        }
        #endregion
    }
}
