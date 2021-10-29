using CSupporter.Modules.Contractors.Data;
using CSupporter.Modules.Contractors.Entities;
using CSupporter.Modules.Contractors.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        private readonly CSupporterDbContext _dbContext;
        private readonly ILogger<ContractorRepository> _logger;

        public ContractorRepository(CSupporterDbContext dbContext, ILogger<ContractorRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<Contractor> GetAsync(Guid id)
        {
            return await _dbContext.Contractors.Where(product => product.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<Contractor>> GetAllAsync()
        {
            return await _dbContext.Contractors.ToListAsync();
        }

        public Task AddAsync(Contractor contractor)
        {
            _dbContext.Contractors.AddAsync(contractor);

            _logger.LogInformation("ADD ASYNC WYKONANY POPRAWNIE");

            _dbContext.SaveChangesAsync();
            return Task.CompletedTask;
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
