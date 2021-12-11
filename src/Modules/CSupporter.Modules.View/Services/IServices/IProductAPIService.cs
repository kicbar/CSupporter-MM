using CSupporter.Modules.View.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IProductAPIService
    {
        Task<List<ProductDto>> SendGetAllRequest();
        Task<ProductDto> SendGetRequest(int productId);
        Task<ProductDto> SendPostRequest(ProductDto productDto);
        Task<ProductDto> SendUpdateRequest(ProductDto productDto);
        Task<ProductDto> SendDeleteRequest(int productId);
    }
}
