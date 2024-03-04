using DevIo.Api.Dtos.Request;
using DevIo.Business.Interfaces;
using DevIo.Business.Model;

namespace DevIo.Api.Adapters
{
    public class SupplierAdapter : IAdapter<SupplierRequestDto, Supplier>
    {
        private Supplier supplier = new Supplier();

        public Supplier ConvertToDestinationObject(SupplierRequestDto source)
        {

            supplier.Name = source.Name;
            supplier.Document = source.Document;
            supplier.IsActive = source.IsActive;
            supplier.SupplierType = source.SupplierType;
            supplier.Address = ConvertToDestinationObject(source.Address);
            
            return supplier;

        }

        private Address ConvertToDestinationObject(AddressRequestDto source)
        {
            return new Address
            {
                Street = source.Street,
                SupplierId = supplier.Id,
                PostalCode = source.PostalCode,
                Number = source.Number,
                Neighbourhood = source.Neighbourhood,
                Municipality = source.Municipality,
                AdministrativeArea = source.AdministrativeArea,
                Complement = source.Complement
            };
        }
    }
}
