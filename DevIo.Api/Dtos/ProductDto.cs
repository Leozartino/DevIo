using System.ComponentModel.DataAnnotations;

namespace DevIo.Api.Dtos
{
    public class ProductDto
    {
        [Key]
        public Guid Id {  get; set; }    
        public Guid? SupplierId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUpload { get; set; }
        public string Image { get; set; }
        public decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public string? SupplierName { get; set; }
    }
}