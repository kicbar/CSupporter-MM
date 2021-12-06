using AutoMapper;
using CSupporter.Modules.Products.Domain.Entities;
using CSupporter.Shared.Infrastructure.Models.DTOs;

namespace CSupporter.Modules.Products.Infrastructure.Mappings
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
