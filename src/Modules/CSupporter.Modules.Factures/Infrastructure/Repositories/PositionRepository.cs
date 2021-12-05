using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Infrastructure.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        public Position AddPositionToFacture(Position position)
        {
            throw new NotImplementedException();
        }

        public List<Position> GetAllPositionsForFacture(int factureId)
        {
            throw new NotImplementedException();
        }

        public bool RemovePositionFromFacture(int positionId)
        {
            throw new NotImplementedException();
        }
    }
}
