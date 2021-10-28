using CSupporter.Modules.Contractors.Data;
using CSupporter.Modules.Contractors.Entities;
using CSupporter.Modules.Contractors.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        private readonly CSupporterDbContext _dbContext;

        public ContractorRepository(CSupporterDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Contractor> GetAsync(Guid id)
        {
            return await _dbContext.Contractors.Where(product => product.Id == id).FirstOrDefaultAsync();
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
