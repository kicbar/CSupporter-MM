using AutoMapper;
using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using System.Collections.Generic;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class PositionService : IPositionService
    {
        private readonly IMapper _mapper;
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository, IMapper mapper)
        {
            _mapper = mapper;
            _positionRepository = positionRepository;
        }

        public List<PositionDto> GetAllPositionsForFacture(int factureId)
        {
            return _mapper.Map<List<PositionDto>>(_positionRepository.GetAllPositionsForFacture(factureId));
        }

        public PositionDto AddPositionToFacture(PositionDto positionDto, int factureId)
        {
            Position position = _mapper.Map<Position>(positionDto);
            position.FactureId = factureId;
            _positionRepository.AddPositionToFacture(position);

            return positionDto;
        }

        public bool RemovePositionFromFacture(int positionId)
        {
            return _positionRepository.RemovePositionFromFacture(positionId);
        }
    }
}
