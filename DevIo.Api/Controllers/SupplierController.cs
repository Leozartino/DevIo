using DevIo.Api.Dtos.Request;
using DevIo.Api.Dtos.Response;
using DevIo.Business.Interfaces.Services;
using DevIo.Business.Model;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Api.Controllers
{
    public class SupplierController : MainController
    {
        private readonly ICreateService<SupplierCreateDto, Supplier> _createService;
        private readonly IGetSupplierByIdService<Supplier> _getSupplierByIdService;

        public SupplierController
            (
            ICreateService<SupplierCreateDto, Supplier> createService,
            IGetSupplierByIdService<Supplier> getSupplierByIdService
            )
        {
            _createService = createService;
            _getSupplierByIdService = getSupplierByIdService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Supplier), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SupplierResponseDto>> GetSupplier([FromRoute] Guid id)
        {
            var supplier = await _getSupplierByIdService.GetSupplierById(id);

            if (supplier is null)
            {
                return NotFound();
            }
            
            return Ok(supplier);
        }
        
        [HttpPost]
        [ProducesResponseType(typeof(Supplier), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SupplierResponseDto>> CreateSupplier([FromBody] SupplierCreateDto request)
        {
            var supplier = await _createService.CreateAsync(request);

            return CreatedAtAction("GetSupplier", supplier);

        }
    }
}
