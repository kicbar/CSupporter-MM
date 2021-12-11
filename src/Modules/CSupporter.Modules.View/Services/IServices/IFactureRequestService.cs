using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IFactureRequestService
    {
        Task<string> GetAllFactures<T>();
        Task<string> GetFactureById<T>(int factureId);
    }
}
