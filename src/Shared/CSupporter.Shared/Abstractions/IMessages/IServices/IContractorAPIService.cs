using System;
using System.Threading.Tasks;

namespace CSupporter.Shared.Abstractions.IMessages.IServices
{
    public interface IContractorAPIService
    {
        Task<T> GetContractorByIdAsync<T>(Guid id);
        Task<T> GetAllContractors<T>();
    }
}
