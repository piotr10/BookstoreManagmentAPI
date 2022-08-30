using BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;
using BookstoreManagment.Api;
using BookstoreManagment.Api.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreManagement.Api.Controllers
{
    /// <summary>
    /// CRUD Customer
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public class CustomerController : BaseController
    {
        /// <summary>
        /// Get Customer detalis
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetCustomerDetailQuery() { CustomerDetailId = id });
            return vm;
        }

        /// <summary>
        /// Create new Customer
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }
    }
}
