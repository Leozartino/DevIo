using DevIo.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Api.Controllers
{
    public class SupplierController : MainController
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<SupplierDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<SupplierDto>>> GetSuppliers()
        {
            return Ok();
        }
    }
}
