using CSupporter.Shared.Infrastructure.Models.DTOs;
using System.Collections.Generic;

namespace CSupporter.Modules.Products.Domain.Interfaces
{
    public interface IProductService
    {
        List<ProductDto> GetAllProducts();
        ProductDto GetProductById(int productId);
        ProductDto AddProduct(ProductDto productDto);
        ProductDto UpdateProduct(ProductDto productDto);
        ProductDto DeleteProduct(ProductDto productDto);
    }
}
