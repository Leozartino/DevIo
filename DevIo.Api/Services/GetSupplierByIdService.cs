using DevIo.Business.Interfaces.Repositories;
using DevIo.Business.Interfaces.Services;
using DevIo.Business.Model;

namespace DevIo.Api.Services
{
    public class GetSupplierByIdService : IGetSupplierByIdService<Supplier>
    {
        private readonly ISupplierRepository _supplierRepository;

        public GetSupplierByIdService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<Supplier> GetSupplierById(Guid id)
        {
            try
            {
                return await _supplierRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
