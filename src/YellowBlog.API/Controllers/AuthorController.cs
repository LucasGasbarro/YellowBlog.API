using Microsoft.AspNetCore.Mvc;
using YellowBlog.Application.DTOs;
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
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorDto request)
        {
            var id = await _authorService.CreateAuthorAsync(request);
            return CreatedAtAction(nameof(CreateAuthor), new { id }, new { id });

        }
    }
}
