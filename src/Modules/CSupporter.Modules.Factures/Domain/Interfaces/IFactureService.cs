using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IFactureService
    {
        FactureDto AddFacture(FactureDto factureDto);
        FactureDto GetFacture(int factureId);
        List<FactureDto> GetAllFactures();
        FactureDto UpdateAsync(FactureDto facture);
        bool DeleteAsync(int factureId);
    }
}
