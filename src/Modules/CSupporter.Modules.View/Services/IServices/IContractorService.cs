using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IContractorService
    {
        Task<T> GetAllContractorsAsync<T>();
    }
}
