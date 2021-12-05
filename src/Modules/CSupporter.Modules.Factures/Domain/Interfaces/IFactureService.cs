using CSupporter.Shared.Infrastructure.Models.DTOs;
using System.Collections.Generic;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IFactureService
    {
        List<FactureDto> GetAllFactures();
        FactureDto GetFacture(int factureId);
        FactureDto AddFacture(FactureDto factureDto);
        FactureDto UpdateFacture(FactureDto factureDto);
        bool DeleteFacture(int factureId);
    }
}
