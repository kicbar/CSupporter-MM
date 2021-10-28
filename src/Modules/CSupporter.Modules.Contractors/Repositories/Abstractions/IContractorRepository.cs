using CSupporter.Modules.Contractors.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Repositories.Abstractions
{
    public interface IContractorRepository
    {
        Task<Contractor> GetAsync(Guid id);
        Task<IReadOnlyList<Contractor>> GetAllAsync();
        Task AddAsync(Contractor contractor);
        Task UpdateAsync(Contractor contractor);
        Task DeleteAsync(Contractor contractor);
    }
}
