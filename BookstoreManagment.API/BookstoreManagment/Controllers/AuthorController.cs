using BookstoreManagement.Application.Author.Commands.CreateAuthor;
using BookstoreManagement.Application.Author.Commands.DeleteAuthor;
using BookstoreManagement.Application.Author.Queries.GetAllAuthors;
using BookstoreManagement.Application.Author.Queries.GetAuthorDetail;
using Microsoft.AspNetCore.Authorization;
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
    [EnableCors("AllowAll")]
    [Authorize]
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
            var createNewAuthor = await Mediator.Send(command);
            return Ok(createNewAuthor);
        }

        /// <summary>
        /// Delete Author
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var response = await Mediator.Send(new DeleteAuthorCommand()
            {
                AuthorId = id
            });
            return NoContent();
        }
    }
}
