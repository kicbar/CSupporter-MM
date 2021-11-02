using CSupporter.Modules.Factures.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IFactureRepository
    {
        Task<Facture> GetAsync(Guid id);
        Task<IReadOnlyList<Facture>> GetAllAsync();
        Task AddAsync(Facture facture);
        Task UpdateAsync(Facture facture);
        Task DeleteAsync(Facture facture);
    }
}
