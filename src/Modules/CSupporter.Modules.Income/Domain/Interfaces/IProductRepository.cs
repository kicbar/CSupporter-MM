using CSupporter.Modules.Products.Domain.Entities;
using System.Collections.Generic;

namespace CSupporter.Modules.Products.Domain.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        bool DeleteProduct(int productId);
    }
}
