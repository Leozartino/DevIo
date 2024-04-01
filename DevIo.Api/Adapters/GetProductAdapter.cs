using DevIo.Api.Dtos;
using DevIo.Business.Interfaces;
using DevIo.Business.Model;

namespace DevIo.Api.Adapters
{
    public class GetProductAdapter : IAdapter<Product, ProductDto>
    {
        public ProductDto ConvertToDestinationObject(Product source)
        {
            return new ProductDto
            {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                IsActive = source.IsActive,
                ImageUpload = source.Image,
                Value = source.Value,
                SupplierId = source.SupplierId,
                CreatedAt = source.CreatedAt,
            };
        }
    }
}
