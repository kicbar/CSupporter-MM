using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Infrastructure.Repositories
{
    public class FactureRepository : IFactureRepository
    {
        public Task AddAsync(Facture facture)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Facture facture)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Facture>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Facture> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Facture facture)
        {
            throw new NotImplementedException();
        }
    }
}
