using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IProductRequestService
    {
        Task<string> GetAllProducts<T>();
        Task<string> GetProductById<T>(int factureId);
    }
}
