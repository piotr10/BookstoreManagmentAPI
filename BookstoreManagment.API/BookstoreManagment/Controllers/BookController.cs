using BookstoreManagement.Application.Book.Queries.GetBookDetail;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreManagement.Api.Controllers
{
    /// <summary>
    /// CRUD Book
    /// </summary>
    [Route("api/books")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public class BookController : BaseController
    {
        /// <summary>
        /// Get Book detalis
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<BookDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetBookDetailQuery() { BookDetailId = id });
            return vm;
        }

        /// <summary>
        /// Create new Book
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }
    }
}
