using Microsoft.AspNetCore.Mvc;
using YellowBlog.Application.DTOs.AuthorDto;
using YellowBlog.Application.Interfaces;
using YellowBlog.Application.Services;

namespace YellowBlog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorDtoInput request)
        {
            var id = await _authorService.CreateAuthorAsync(request);
            return CreatedAtAction(nameof(CreateAuthor), new { id }, new { id });
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllAuthors()
        {
            try
            {
                var authors = await _authorService.GetAllAsync();
                if (authors != null && authors.Any())
                    return Ok(authors);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException + "\n" + ex.Message);
            }
            
        }

        [HttpGet]
        [Route("id/{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            try
            {
                AuthorDtoResponse author = await _authorService.GetByIdAsync(id);

                if (author != null)
                    return Ok(author);
                else
                    return NotFound();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException + "\n" + ex.Message);
            }
        }
    }
}
