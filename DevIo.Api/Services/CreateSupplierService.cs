using DevIo.Api.Dtos.Request;
using DevIo.Business.Interfaces;
using DevIo.Business.Interfaces.Repositories;
using DevIo.Business.Interfaces.Services;
using DevIo.Business.Model;

namespace DevIo.Services.Services
{
    public class CreateSupplierService : ICreateService<SupplierRequestDto, Supplier>
    {
        private readonly IAdapter<SupplierRequestDto, Supplier> _adapter;
        private readonly ISupplierRepository _supplierRepository;

        public CreateSupplierService(
            IAdapter<SupplierRequestDto, Supplier> adapter,
            ISupplierRepository supplierRepository)
        {
            _adapter = adapter;
            _supplierRepository = supplierRepository;
        }

        public async Task<Supplier> CreateAsync(SupplierRequestDto createDto)
        {
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
