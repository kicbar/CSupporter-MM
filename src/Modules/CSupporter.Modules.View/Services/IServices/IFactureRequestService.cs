using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IFactureRequestService
    {
        Task<T> GetAllFactures<T>();
        Task<T> GetFactureById<T>(int factureId);
    }
}
