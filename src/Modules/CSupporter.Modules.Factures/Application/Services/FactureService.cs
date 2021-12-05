using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class FactureService : IFactureService
    {
        private readonly IFactureRepository _factureRepository;

        public FactureService(IFactureRepository factureRepository)
        {
            _factureRepository = factureRepository;
        }

        public FactureDto AddFacture(FactureDto factureDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAsync(int factureId)
        {
            throw new NotImplementedException();
        }

        public List<FactureDto> GetAllFactures()
        {
            throw new NotImplementedException();
        }

        public FactureDto GetFacture(int factureId)
        {
            throw new NotImplementedException();
        }

        public FactureDto UpdateAsync(FactureDto facture)
        {
            throw new NotImplementedException();
        }
    }
}
