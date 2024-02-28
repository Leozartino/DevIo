using DevIo.Business.Model;
using System.ComponentModel.DataAnnotations;

namespace DevIo.Api.Dtos
{
    public class SupplierDto
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public SupplierType SupplierType { get; set; }
        public bool IsActive { get; set; }

         public AddressDto Addresses { get; set; }
         public IEnumerable<ProductDto> Products { get; set; }
    }
}
