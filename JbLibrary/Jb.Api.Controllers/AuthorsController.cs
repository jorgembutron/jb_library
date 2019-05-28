using Jb.Api.Models;
using Jb.Api.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Jb.Api.Controllers
{
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost()]
        public async Task<ActionResult> AddAsync([FromBody]AuthorCreationDto authorDto)
        {
            await _authorService.AddAuthorAsync().ConfigureAwait(false);

            return Ok();
        }
    }
}
