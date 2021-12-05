using CSupporter.Shared.Infrastructure.Models.DTOs;
using System.Collections.Generic;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IPositionService
    {
        List<PositionDto> GetAllPositionsForFacture(int factureId);
        PositionDto AddPositionToFacture(PositionDto positionDto, int factureId);
        bool RemovePositionFromFacture(int positionId);
    }
}
