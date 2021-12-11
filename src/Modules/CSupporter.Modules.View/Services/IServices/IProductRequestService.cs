using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IProductRequestService
    {
        Task<T> GetAllProducts<T>();
        Task<T> GetProductById<T>(int productId);
    }
}
