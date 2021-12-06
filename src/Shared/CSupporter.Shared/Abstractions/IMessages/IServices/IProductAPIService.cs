using System.Threading.Tasks;

namespace CSupporter.Shared.Abstractions.IMessages.IServices
{
    public interface IProductAPIService
    {
        Task<T> GetAllProducts<T>();
        Task<T> GetProductByIdAsync<T>(int productId);
    }
}
