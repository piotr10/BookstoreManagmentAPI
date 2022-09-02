using BookstoreManagement.Application.Author.Commands.CreateAuthor;
using BookstoreManagement.Application.Author.Queries.GetAllAuthors;
using BookstoreManagement.Application.Author.Queries.GetAuthorDetail;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreManagement.Api.Controllers
{
    /// <summary>
    /// CRUD Author
    /// </summary>
    [Route("api/authors")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public class AuthorController : BaseController
    {
        /// <summary>
        /// Get Author detalis
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetAuthorDetailQuery() {AuthorId = id});
            return vm;
        }

        /// <summary>
        /// Get all Authors
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<AuthorsVm>> GetAllAuthors()
        {
            var vm = await Mediator.Send(new GetAuthorsQuery() { });
            return vm;
        }

        /// <summary>
        /// Create new Author
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
