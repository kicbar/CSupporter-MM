using CSupporter.Modules.Products.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Products.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IProductService _productService;

        public ProductAPIController(IProductService productService)
        {
            this._response = new APIResponse();
            _productService = productService;
        }

        [HttpGet]
        [ActionName("GetProducts")]
        public async Task<object> GetProducts()
        {
            try
            {
                List<ProductDto> productsDto = _productService.GetAllProducts();
                _response.Result = productsDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("{productId}")]
        [ActionName("GetProduct")]
        public async Task<object> GetProduct(int productId)
        {
            try
            {
                ProductDto productDto = _productService.GetProductById(productId);
                _response.Result = productDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        [ActionName("AddProduct")]
        public async Task<object> AddProduct([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto productCreated = _productService.AddProduct(productDto);
                _response.Result = productCreated;
            }
            catch (Exception exc)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { exc.ToString() };
            }
            return _response;
        }


        [HttpPut]
        [ActionName("UpdateProduct")]
        public async Task<object> UpdateProduct([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto productUpdated = _productService.UpdateProduct(productDto);
                _response.Result = productUpdated;
            }
            catch (Exception exc)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { exc.ToString() };
            }
            return _response;
        }

        [HttpDelete("{productId}")]
        [ActionName("DeleteProduct")]
        public async Task<object> DeleteProduct(int productId)
        {
            try
            {
                bool isRemoved = _productService.DeleteProduct(productId);
                _response.Result = isRemoved;
            }
            catch (Exception exc)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { exc.ToString() };
            }
            return _response;
        }
    }
}
