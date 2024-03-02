using DevIo.Api.Dtos;
using DevIo.Business.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Api.Controllers
{
    public class SupplierController : MainController
    {

        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<SupplierDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<SupplierDto>>> GetSuppliers()
        {
            var suppliers = await _supplierRepository.GetAll();

            if (suppliers.Count == 0)
            { 
                return Ok(suppliers);
            }

            var suppliersDto = suppliers.Select(supplier =>
            {
                return new SupplierDto
                {
                    Id = supplier.Id,
                    Name = supplier.Name,
                    Document = supplier.Document,
                    SupplierType = supplier.SupplierType,
                    IsActive = supplier.IsActive,
                    Address = new AddressDto
                    {
                        Id = supplier.Address.Id,
                        Street = supplier.Address.Street,
                        Number = supplier.Address.Number,
                        Complement = supplier.Address.Complement,
                        PostalCode = supplier.Address.PostalCode,
                        Neighbourhood = supplier.Address.Neighbourhood,
                        Municipality = supplier.Address.Municipality,
                        AdministrativeArea = supplier.Address.AdministrativeArea,
                    },

                    Products = supplier.Products.Select(product =>
                    {
                        return new ProductDto
                        {
                            Id = product.Id,
                            Name = product.Name,
                            Description = product.Description,
                            Image = product.Image,
                            ImageUpload = "S3 URL",
                            IsActive = product.IsActive,
                            //SupplierName = supplier.Name,
                            Value = product.Value,
                            CreatedAt = product.CreatedAt,
                        };
                    }),
                };
            });

            return Ok(suppliersDto);
        }
    }
}
