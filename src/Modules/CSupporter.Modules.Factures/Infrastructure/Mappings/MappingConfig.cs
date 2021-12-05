using AutoMapper;
using CSupporter.Modules.Factures.Domain.Entities;
using CSupporter.Shared.Infrastructure.Models.DTOs;

namespace CSupporter.Modules.Factures.Infrastructure.Mappings
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<FactureDto, Facture>().ReverseMap();
                config.CreateMap<PositionDto, Position>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
