using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Modules.Factures.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace CSupporter.Modules.Factures.Infrastructure.Repositories
{
    public class FactureRepository : IFactureRepository
    {
        private readonly CSupporterDbContext _csupporterDbContext;

        public FactureRepository(CSupporterDbContext csupporterDbContext)
        {
            _csupporterDbContext = csupporterDbContext;
        }
        public Facture GetFacture(int factureId)
        {
            return _csupporterDbContext.Factures.Where(f => f.FactureId == factureId).FirstOrDefault();
        }

        public List<Facture> GetAllFactures()
        {
            List<Facture> factures = _csupporterDbContext.Factures.ToList();
            return factures;
        }

        public Facture AddFacture(Facture facture)
        {
            _csupporterDbContext.Add(facture);
            _csupporterDbContext.SaveChanges();

            return facture;
        }

        public Facture UpdateFacture(Facture facture)
        {
            _csupporterDbContext.Update(facture);
            _csupporterDbContext.SaveChanges();

            return facture;
        }

        public bool DeleteFacture(int factureId)
        {
            try
            {
                Facture factureExist = _csupporterDbContext.Factures.Where(f => f.FactureId == factureId).FirstOrDefault();
                if (factureExist == null)
                    return false;

                _csupporterDbContext.Remove(factureExist);
                _csupporterDbContext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
