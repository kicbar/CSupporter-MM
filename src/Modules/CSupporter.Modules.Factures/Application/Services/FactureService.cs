using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class FactureService : IFactureService
    {
        private readonly IFactureRepository _factureRepository;

        public FactureService(IFactureRepository factureRepository)
        {
            _factureRepository = factureRepository;
        }

        public Task AddAsync(Facture facture)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
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
