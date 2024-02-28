using DevIo.Business.Model;

namespace DevIo.Business.Interfaces.Repositories
{
    interface ISupplierRepository: IRepository<Supplier>
    {
        Task<Supplier> GetSupplierWithAddress(Guid id);
        Task<Supplier> GetSupplierWithAddressAndProducts(Guid id);

    }
}
