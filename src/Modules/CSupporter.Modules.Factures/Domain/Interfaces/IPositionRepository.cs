using CSupporter.Modules.Factures.Domain.Entities;
using System.Collections.Generic;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IPositionRepository
    {
        List<Position> GetAllPositionsForFacture(int factureId);
        Position AddPositionToFacture(Position position);
        bool RemovePositionFromFacture(int positionId);
    }
}
