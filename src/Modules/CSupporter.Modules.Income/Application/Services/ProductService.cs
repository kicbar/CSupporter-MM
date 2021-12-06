using CSupporter.Modules.Products.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Products.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductDto AddProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public ProductDto DeleteProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public List<ProductDto> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public ProductDto GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public ProductDto UpdateProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
