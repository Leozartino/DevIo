using DevIo.Api.Dtos.Request;
using DevIo.Business.Model;

namespace DevIo.Api.Dtos.Response;

public class SupplierResponseDto
{
    public string Name { get; set; }
    public string Document { get; set; }
    public SupplierType SupplierType { get; set; }
    public bool IsActive { get; set; }
    public AddressDto Address { get; set; }

    public IEnumerable<ProductDto> Products { get; set; }
}