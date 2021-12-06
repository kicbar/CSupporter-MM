using CSupporter.Shared.Infrastructure.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IPositionService
    {
        Task<List<PositionDto>> GetAllPositionsForFactureAsync(int factureId);
        PositionDto AddPositionToFacture(PositionDto positionDto, int factureId);
        bool RemovePositionFromFacture(int positionId);
    }
}
