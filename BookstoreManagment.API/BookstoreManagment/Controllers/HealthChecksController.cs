using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.V5.Pages.Internal;
using Microsoft.AspNetCore.Mvc;
using ErrorModel = BookstoreManagement.Api.Models.ErrorModel;

namespace BookstoreManagement.Api.Controllers
{
    /// <summary>
    /// Checking controller
    /// </summary>
    [Route("api/hc")]
    [ApiController]
    public class HealthChecksController : ControllerBase
    {
        /// <summary>
        /// Healthy response
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetAsync()
        {
            return "Healthy";
        }
    }
}
