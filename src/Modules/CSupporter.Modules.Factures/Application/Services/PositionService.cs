using AutoMapper;
using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Abstractions.IMessages.IServices;
using CSupporter.Shared.Infrastructure.Models;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class PositionService : IPositionService
    {
        private readonly IMapper _mapper;
        private readonly IProductAPIService _productAPIService;
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository, IProductAPIService productAPIService, IMapper mapper)
        {
            _mapper = mapper;
            _productAPIService = productAPIService;
            _positionRepository = positionRepository;
        }

        public async Task<List<PositionDto>> GetAllPositionsForFactureAsync(int factureId)
        {
            List<Position> positions = _positionRepository.GetAllPositionsForFacture(factureId);

            List<PositionDto> positionsDto = new();
            foreach (Position position in positions)
            {
                var response = await _productAPIService.GetProductByIdAsync<APIResponse>(position.PositionId);

                ProductDto productDto = new();
                if (response != null && response.IsSuccess)
                {
                    productDto = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
                }

                PositionDto positionDto = new();
                positionDto.PositionNo = positionDto.PositionNo + 1;
                positionDto.ProductName = productDto.Name;
                positionDto.ProductPrice = productDto.Price;
                positionDto.ProductAmount = position.ProductAmount;
                positionsDto.Add(positionDto);
            }

            return positionsDto;
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
