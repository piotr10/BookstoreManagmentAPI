using BookstoreManagement.Application.Book.Queries.GetBookDetail;
using BookstoreManagement.Application.Order.Commands.CreateOrder;
using BookstoreManagement.Application.Order.Queries.GetAllOrders;
using BookstoreManagement.Application.Order.Queries.GetOrderDetail;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreManagement.Api.Controllers
{
    /// <summary>
    /// CRUD Order
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public class OrderController : BaseController
    {
        /// <summary>
        /// Get Order detalis
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetailVm>> GetDetails(int id, int bookId, int customerId)
        {
            var vm = await Mediator.Send(new GetOrderDetailQuery() { OrderId = id, BookDetailId = bookId, CustomerDetailId = customerId});

            return vm;
        }

        /// <summary>
        /// Get all Orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<OrdersVm>> GetAllOrders()
        {
            var vm = await Mediator.Send(new GetOrdersQuery() { });
            return vm;
        }

        /// <summary>
        /// Create new Order
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderCommand command)
        {
            var createNewOrder = await Mediator.Send(command);
            return Ok(createNewOrder);
        }
    }
}
