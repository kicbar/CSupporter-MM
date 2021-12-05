using CSupporter.Modules.Factures.Domain.Entities;
using System.Collections.Generic;

namespace CSupporter.Modules.Factures.Domain.Interfaces
{
    public interface IFactureRepository
    {
        Facture GetFacture(int factureId);
        List<Facture> GetAllFactures();
        Facture AddFacture(Facture facture);
        Facture UpdateFacture(Facture facture);
        bool DeleteFacture(int factureId);
    }
}
