using CSupporter.Modules.Contractors.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services.IServices
{
    public interface IRequestSenderService
    {
        Task<List<ContractorDto>> SendGetAllRequest();
        Task<ContractorDto> SendGetRequest(Guid id);
        Task<ContractorDto> SendPostRequest(ContractorDto contractorDto);
        Task<ContractorDto> SendUpdateRequest(ContractorDto contractorDto);
    }
}
