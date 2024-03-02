using DevIo.Business.Interfaces.Repositories;
using DevIo.Business.Model;
using DevIo.Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace DevIo.Infra.Repositories
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {

        public SupplierRepository(ApiDbContext context) : base(context) { }

        public async Task<Supplier> GetSupplierWithAddressAsync(Guid id)
        {
            Supplier? supplier = await Db.Suppliers.AsNoTracking()
                                        .Include(x => x.Address)
                                        .FirstOrDefaultAsync();

            return ReturnsSupplier(supplier);

        }

        public async Task<Supplier> GetSupplierWithAddressAndProductsAsync(Guid id)
        {


            Supplier? supplier = await Db.Suppliers.AsNoTracking()
                            .Include(x => x.Products)
                            .Include(x => x.Address)
                            .FirstOrDefaultAsync(x => x.Id == id);

            return ReturnsSupplier(supplier);
        }

        private static Supplier ReturnsSupplier(Supplier? supplier)
        {
            if (supplier == null)
            {
                return new Supplier();
            }

            return supplier;
        }
    }
}
