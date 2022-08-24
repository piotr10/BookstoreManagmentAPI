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
        /// Create new Author
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }
    }
}
