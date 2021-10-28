using CSupporter.Modules.Contractors.Entities;
using CSupporter.Modules.Contractors.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Repositories
{
    internal class ContractorRepository : IContractorRepository
    {
        public Task<Contractor> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Contractor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Contractor contractor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Contractor contractor)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Contractor contractor)
        {
            throw new NotImplementedException();
        }
    }
}
