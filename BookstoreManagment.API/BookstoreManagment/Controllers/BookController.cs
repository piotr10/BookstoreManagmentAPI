using BookstoreManagement.Application.Book.Commands.CreateBook;
using BookstoreManagement.Application.Book.Queries.GetAllBooks;
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
        /// Get all Books
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<BookDetailsVm>> GetAllBooks()
        {
            var vm = await Mediator.Send(new GetBookDetailsQuery() { });
            return vm;
        }

        /// <summary>
        /// Create new Book
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateBookCommand command)
        {
            var createNewBook = await Mediator.Send(command);
            return Ok(createNewBook);
        }
    }
}
