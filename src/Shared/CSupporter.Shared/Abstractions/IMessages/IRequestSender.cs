using CSupporter.Shared.Infrastructure.Models;
using System;
using System.Threading.Tasks;

namespace CSupporter.Shared.Abstractions.IMessages
{
    public interface IRequestSender : IDisposable
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
