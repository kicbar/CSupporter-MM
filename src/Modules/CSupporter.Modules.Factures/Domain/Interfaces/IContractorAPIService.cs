using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IContractorAPIService
    {
        Task<string> GetContractorByIdAsync<T>(int contractorId);
    }
}
