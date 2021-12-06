using CSupporter.Modules.Products.Domain.Entities;
using CSupporter.Modules.Products.Domain.Interfaces;
using CSupporter.Modules.Products.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace CSupporter.Modules.Products.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CSupporterDbContext _csupporterDbContext;

        public ProductRepository(CSupporterDbContext csupporterDbContext)
        {
            _csupporterDbContext = csupporterDbContext;
        }

        public List<Product> GetAllProducts()
        {
            return _csupporterDbContext.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _csupporterDbContext.Products.Where(product => product.ProductId == productId).FirstOrDefault();
        }

        public Product AddProduct(Product product)
        {
            var result = _csupporterDbContext.Products.Add(product);
            _csupporterDbContext.SaveChanges();
            var newProduct = _csupporterDbContext.Products.Where(p => p.Name == product.Name).FirstOrDefault();
            return newProduct;
        }

        public Product UpdateProduct(Product product)
        {
            Product productExist = _csupporterDbContext.Products.Where(product => product.ProductId == product.ProductId).FirstOrDefault();

            if (productExist != null)
            {
                _csupporterDbContext.Products.Update(product);
                _csupporterDbContext.SaveChanges();
            }
            return product;
        }
        public bool DeleteProduct(int productId)
        {
            Product productExist = _csupporterDbContext.Products.Where(product => product.ProductId == productId).FirstOrDefault();

            if (productExist != null)
            {
                _csupporterDbContext.Products.Remove(productExist);
                _csupporterDbContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
