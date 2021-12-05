using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Modules.Factures.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSupporter.Modules.Factures.Infrastructure.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly CSupporterDbContext _csupporterDbContext;

        public PositionRepository(CSupporterDbContext csupporterDbContext)
        {
            _csupporterDbContext = csupporterDbContext;
        }

        public List<Position> GetAllPositionsForFacture(int factureId)
        {
            CalculateFactureValue(factureId);
            return _csupporterDbContext.Positions.Where(position => position.FactureId == factureId).ToList();
        }

        public Position AddPositionToFacture(Position position)
        {
            _csupporterDbContext.Add(position);
            CalculateFactureValue(position.FactureId);
            _csupporterDbContext.SaveChanges();
            return position;
        }

        public bool RemovePositionFromFacture(int positionId)
        {
            try
            {
                Position position = _csupporterDbContext.Positions.Where(position => position.PositionId == positionId).FirstOrDefault();

                if (position != null)
                {
                    _csupporterDbContext.Remove(position);
                    CalculateFactureValue(position.FactureId);
                    _csupporterDbContext.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void CalculateFactureValue(int factureId)
        {
            double factureValue = 0;
            List<Position> positions = _csupporterDbContext.Positions.Where(position => position.FactureId == factureId).ToList();

            foreach (Position position in positions)
            {
                factureValue += position.ProductPrice * position.ProductAmount;
            }

            Facture facture = _csupporterDbContext.Factures.Where(facture => facture.FactureId == factureId).FirstOrDefault();
            facture.Value = factureValue;
            _csupporterDbContext.SaveChanges();
        }
    }
}
