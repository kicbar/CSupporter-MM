using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class PositionService : IPositionService
    {
        public PositionDto AddPositionToFacture(PositionDto positionDto, int factureId)
        {
            throw new NotImplementedException();
        }

        public List<PositionDto> GetAllPositionsForFacture(int factureId)
        {
            throw new NotImplementedException();
        }

        public bool RemovePositionFromFacture(int positionId)
        {
            throw new NotImplementedException();
        }
    }
}
