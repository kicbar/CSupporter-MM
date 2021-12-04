using CSupporter.Modules.Contractors.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Services.Abstractions
{
    public interface IContractorService
    {
        Task AddAsync(ContractorDto dto);
        Task<ContractorDetailsDto> GetAsync(Guid id);
        Task<List<ContractorDto>> GetAllAsync();
        Task UpdateAsync(ContractorDto dto);
        Task DeleteAsync(Guid id);
    }
}
