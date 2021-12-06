using CSupporter.Modules.Products.Domain.Entities;
using CSupporter.Modules.Products.Domain.Interfaces;
using CSupporter.Modules.Products.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Products.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CSupporterDbContext _csupporterDbContext;

        public ProductRepository(CSupporterDbContext csupporterDbContext)
        {
            _csupporterDbContext = csupporterDbContext;
        }

        public Product AddProduct(Product productDto)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(Product productDto)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product productDto)
        {
            throw new NotImplementedException();
        }
    }
}
