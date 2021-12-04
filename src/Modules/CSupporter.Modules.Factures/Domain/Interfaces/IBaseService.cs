using CSupporter.Shared.Infrastructure.Models;
using System;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IBaseService : IDisposable
    {
        Task<string> SendAsync<T>(APIRequest apiRequest);

    }
}
