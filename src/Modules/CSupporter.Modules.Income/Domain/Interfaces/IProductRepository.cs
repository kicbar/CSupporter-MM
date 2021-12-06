using CSupporter.Modules.Products.Domain.Entities;
using System.Collections.Generic;

namespace CSupporter.Modules.Products.Domain.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        Product AddProduct(Product productDto);
        Product UpdateProduct(Product productDto);
        Product DeleteProduct(Product productDto);
    }
}
