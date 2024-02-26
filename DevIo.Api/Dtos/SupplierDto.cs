using System.ComponentModel.DataAnnotations;

namespace DevIo.Api.Dtos
{
    public class SupplierDto
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public int SupplierType { get; set; }
        public bool IsActive { get; set; }

         public AddressDto Addresses { get; set; }
         public IEnumerable<ProductDto> Products { get; set; }
    }
}
