using CSupporter.Modules.Contractors.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Services.Abstractions
{
    internal interface IContractorService
    {
        Task AddAsync(ContractorDto dto);
        Task<ContractorDetailsDto> GetAsync(ContractorDto dto);
        Task<IReadOnlyList<ContractorDto>> GetAllAsync();
        Task UpdateAsync(ContractorDto dto);
        Task DeleteAsync(Guid id);
    }
}
