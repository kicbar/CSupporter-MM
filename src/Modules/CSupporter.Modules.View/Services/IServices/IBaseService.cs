using CSupporter.Modules.View.Models;
using System;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ApiResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
