using DevIo.Api.Dtos.Request;
using DevIo.Business.Interfaces;
using DevIo.Business.Interfaces.Repositories;
using DevIo.Business.Interfaces.Services;
using DevIo.Business.Model;
using FluentValidation;

namespace DevIo.Api.Services
{
    public class CreateSupplierService : ICreateService<SupplierCreateDto, Supplier>
    {
        private readonly IAdapter<SupplierCreateDto, Supplier> _adapter;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IValidator<SupplierCreateDto> _validator;

        public CreateSupplierService
            (
            IAdapter<SupplierCreateDto, Supplier> adapter, 
            ISupplierRepository supplierRepository, 
            IValidator<SupplierCreateDto> validator
            )
        {
            _adapter = adapter;
            _supplierRepository = supplierRepository;
            _validator = validator;
        }

        public async Task<Supplier> CreateAsync(SupplierCreateDto createDto)
        {
            var validationResult = await _validator.ValidateAsync(createDto);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            try
            {
                Supplier supplier = _adapter.ConvertToDestinationObject(createDto);

                await _supplierRepository.Add(supplier);

                return supplier;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
