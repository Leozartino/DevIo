using DevIo.Api.Dtos.Request;
using DevIo.Api.Dtos.Response;
using DevIo.Business.Interfaces;
using DevIo.Business.Model;

namespace DevIo.Api.Adapters;

public class GetSupplierAdapter: IAdapter<Supplier, SupplierResponseDto>
{
    private readonly SupplierResponseDto _supplierResponseDto = new();
    public SupplierResponseDto ConvertToDestinationObject(Supplier source)
    {
        _supplierResponseDto.Name = source.Name;
        _supplierResponseDto.Document = source.Document;
        _supplierResponseDto.SupplierType = source.SupplierType;
        _supplierResponseDto.IsActive = source.IsActive;
        _supplierResponseDto.Address = ConvertToDestinationObject(source.Address);
        
        //TODO MAPPING Product to ProductDto
        
        return _supplierResponseDto;
    }
    
    private AddressDto ConvertToDestinationObject(Address source)
    {
        return new AddressDto
        {
            Street = source.Street,
            PostalCode = source.PostalCode,
            Number = source.Number,
            Neighbourhood = source.Neighbourhood,
            Municipality = source.Municipality,
            AdministrativeArea = source.AdministrativeArea,
            Complement = source.Complement       
        };
    }
}