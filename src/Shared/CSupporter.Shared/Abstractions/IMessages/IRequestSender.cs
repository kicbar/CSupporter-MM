using CSupporter.Shared.Infrastructure.Models;
using System;
using System.Threading.Tasks;

namespace CSupporter.Shared.Abstractions.IMessages
{
    public interface IRequestSender : IDisposable
    {
        Task<string> SendAsync<T>(APIRequest apiRequest);
    }
}
