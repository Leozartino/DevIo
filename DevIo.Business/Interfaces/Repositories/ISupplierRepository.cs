using DevIo.Business.Model;

namespace DevIo.Business.Interfaces.Repositories
{
    interface ISupplierRepository : IRepository<Supplier>
    {
        Task<Supplier> GetSupplierWithAddressAsync(Guid id);
        Task<Supplier> GetSupplierWithAddressAndProductsAsync(Guid id);
    }
}
