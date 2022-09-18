using BookstoreManagement.Application.Customer.Commands.CreateCustomer;
using BookstoreManagement.Application.Customer.Commands.DeleteCustomer;
using BookstoreManagement.Application.Customer.Queries.GetAllCustomers;
using BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;
using BookstoreManagment.Api;
using BookstoreManagement.Api.Models;
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
    [EnableCors("AllowAll")]
    public class CustomerController : BaseController
    {
        /// <summary>
        /// Get Customer detalis
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetCustomerDetailQuery() {CustomerDetailId = id});
            return vm;
        }

        /// <summary>
        /// Get all Customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<CustomersVm>> GetAllCustomers()
        {
            var vm = await Mediator.Send(new GetCustomersQuery() { });
            return vm;
        }

        /// <summary>
        /// Create new Customer
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand command)
        {
            var createNewCustomer = await Mediator.Send(command);
            return Ok(createNewCustomer);
        }

        /// <summary>
        /// Delete Customer
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var response = await Mediator.Send(new DeleteCustomerCommand()
            {
                CustomerId = id
            });
            return NoContent();
        }
    }
}
