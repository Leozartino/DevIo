using DevIo.Business.Model;

namespace DevIo.Business.Interfaces.Repositories
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        Task<Supplier> GetSupplierWithAddressAsync(Guid id);
        Task<Supplier> GetSupplierWithAddressAndProductsAsync(Guid id);
    }
}
