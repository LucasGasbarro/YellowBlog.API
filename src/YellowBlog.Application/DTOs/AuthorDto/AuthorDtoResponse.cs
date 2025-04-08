using YellowBlog.Domain.Entities;

namespace YellowBlog.Application.DTOs.AuthorDto
{
    public class AuthorDtoResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }


        #region Implicit mappers
        public static implicit operator Author(AuthorDtoResponse authorDto)
        {
            if (authorDto is null)
                return null;

            return new Author
            {
                Id = authorDto.Id,
                Name = authorDto.Name,
                CreatedAt = authorDto.CreatedAt
            };
        }

        public static implicit operator AuthorDtoResponse(Author author)
        {
            if (author is null)
                return null;

            return new AuthorDtoResponse
            {
                Id = author.Id,
                Name = author.Name,
                CreatedAt = author.CreatedAt
            };
        }
        #endregion
    }
}
