using CSupporter.Shared.Infrastructure.Models;
using System;
using System.Threading.Tasks;

namespace CSupporter.Shared.Abstractions.IMessages
{
    public interface IRequestSender : IDisposable
    {
        APIResponse ResponseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
