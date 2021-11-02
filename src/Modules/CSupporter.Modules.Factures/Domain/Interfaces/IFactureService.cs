using CSupporter.Modules.Factures.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IFactureService
    {
        Task AddAsync(Facture facture);
        Task<Facture> GetAsync(Guid id);
        Task<IReadOnlyList<Facture>> GetAllAsync();
        Task UpdateAsync(Facture facture);
        Task DeleteAsync(Guid id);
    }
}
