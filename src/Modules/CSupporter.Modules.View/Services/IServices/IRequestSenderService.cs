using CSupporter.Modules.Contractors.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IRequestSenderService
    {
        Task<List<ContractorDto>> SendGetAllRequest();
    }
}
