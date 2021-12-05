using System;
using System.Threading.Tasks;

namespace CSupporter.Shared.Abstractions.IMessages.IServices
{
    public interface IContractorAPIService
    {
        Task<T> GetContractorByIdAsync<T>(string contractorId);
        Task<T> GetAllContractors<T>();
    }
}
