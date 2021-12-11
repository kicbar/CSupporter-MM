using CSupporter.Modules.View.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IFactureAPIService
    {
        Task<List<FacturesDto>> SendGetAllRequest();
        Task<EntireFactureDto> SendGetRequest(int factureId);
        Task<FacturesDto> SendPostRequest(FacturesDto facturesDto);
        Task<FacturesDto> SendUpdateRequest(FacturesDto facturesDto);
        Task<FacturesDto> SendDeleteRequest(int factureId);
    }
}
