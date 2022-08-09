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
        [HttpGet("{id}")]
        public async Task<ActionResult> GetDetails()
        {
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok();
        }
    }
}
