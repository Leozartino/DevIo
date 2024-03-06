using DevIo.Api.Dtos.Request;
using DevIo.Business.Interfaces.Services;
using DevIo.Business.Model;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Api.Controllers
{
    public class SupplierController : MainController
    {
        private readonly ICreateService<SupplierRequestDto, Supplier> _createService;

        public SupplierController
            (
            ICreateService<SupplierRequestDto, Supplier> createService
            )
        {
            _createService = createService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Supplier), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Supplier>> CreateSupplier([FromBody] SupplierRequestDto request)
        {
            var supplier = await _createService.CreateAsync(request);

            return CreatedAtAction("GetSupplier", supplier);

        }
    }
}
