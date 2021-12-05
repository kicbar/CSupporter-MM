using CSupporter.Modules.Factures.Domain.Entities;
using System.Collections.Generic;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IFactureRepository
    {
        Facture GetFacture(int factureId);
        List<Facture> GetAllFactures();
        void AddFacture(Facture facture);
        void UpdateFacture(Facture facture);
        void DeleteFacture(Facture facture);
    }
}
