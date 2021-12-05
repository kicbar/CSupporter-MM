using AutoMapper;
using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using System.Collections.Generic;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class FactureService : IFactureService
    {
        private readonly IMapper _mapper;
        private readonly IFactureRepository _factureRepository;

        public FactureService(IFactureRepository factureRepository, IMapper mapper)
        {
            _mapper = mapper;
            _factureRepository = factureRepository;
        }

        public List<FactureDto> GetAllFactures()
        {
            List<Facture> factures = _factureRepository.GetAllFactures();
            return _mapper.Map<List<FactureDto>>(factures);
        }

        public FactureDto GetFacture(int factureId)
        {
            Facture facture = _factureRepository.GetFacture(factureId);
            return _mapper.Map<FactureDto>(facture);
        }

        public FactureDto AddFacture(FactureDto factureDto)
        {
            Facture facture = _factureRepository.AddFacture(_mapper.Map<Facture>(factureDto));
            return _mapper.Map<FactureDto>(facture);
        }

        public FactureDto UpdateFacture(FactureDto factureDto)
        {
            Facture facture = _factureRepository.UpdateFacture(_mapper.Map<Facture>(factureDto));
            return _mapper.Map<FactureDto>(facture);
        }

        public bool DeleteFacture(int factureId)
        {
            return _factureRepository.DeleteFacture(factureId);
        }
    }
}
