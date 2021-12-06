using AutoMapper;
using CSupporter.Modules.Products.Domain.Entities;
using CSupporter.Modules.Products.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using System.Collections.Generic;

namespace CSupporter.Modules.Products.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public List<ProductDto> GetAllProducts()
        {
            List<Product> products = _productRepository.GetAllProducts();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public ProductDto GetProductById(int productId)
        {
            Product product = _productRepository.GetProductById(productId);
            return _mapper.Map<ProductDto>(product);
        }

        public ProductDto AddProduct(ProductDto productDto)
        {
            Product product = _productRepository.AddProduct(_mapper.Map<Product>(productDto));
            return _mapper.Map<ProductDto>(product);
        }

        public ProductDto UpdateProduct(ProductDto productDto)
        {
            Product product = _productRepository.UpdateProduct(_mapper.Map<Product>(productDto));
            return _mapper.Map<ProductDto>(product);
        }

        public bool DeleteProduct(int productId)
        {
            return _productRepository.DeleteProduct(productId);
        }
    }
}
