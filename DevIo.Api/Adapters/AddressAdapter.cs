using DevIo.Api.Dtos.Request;
using DevIo.Business.Interfaces;
using DevIo.Business.Model;

namespace DevIo.Api.Adapters
{
    public class AddressAdapter : IAdapter<AddressRequestDto, Address>
    {
        public Address ConvertToDestinationObject(AddressRequestDto source)
        {
            return new Address
            {
                Street = source.Street,
                SupplierId = source.SupplierId,
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
