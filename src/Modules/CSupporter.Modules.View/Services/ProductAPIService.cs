using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services
{
    public class ProductAPIService : IProductAPIService
    {
        public Task<ProductDto> SendDeleteRequest(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductDto>> SendGetAllRequest()
        {
            List<ProductDto> productDtos = new();
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync(ApiData.ApiAddress + "/api/product");
                string apiResponse = await response.Content.ReadAsStringAsync();
                ApiResponseDto apiResponseDto = JsonConvert.DeserializeObject<ApiResponseDto>(apiResponse);
                if (apiResponseDto != null && apiResponseDto.IsSuccess)
                {
                    productDtos = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(apiResponseDto.Result));
                }
            }
            return productDtos;
        }

        public async Task<ProductDto> SendGetRequest(int productId)
        {
            ProductDto productDto = new();
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync(ApiData.ApiAddress + "/api/product/" + productId);
                string apiResponse = await response.Content.ReadAsStringAsync();
                ApiResponseDto apiResponseDto = JsonConvert.DeserializeObject<ApiResponseDto>(apiResponse);

                if (apiResponseDto != null && apiResponseDto.IsSuccess)
                {
                    productDto = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(apiResponseDto.Result));
                }
            }
            return productDto;
        }

        public Task<ProductDto> SendPostRequest(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> SendUpdateRequest(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
