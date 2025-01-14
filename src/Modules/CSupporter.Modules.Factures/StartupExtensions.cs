﻿using AutoMapper;
using CSupporter.Modules.Factures.Application.Services;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Modules.Factures.Infrastructure.Data;
using CSupporter.Modules.Factures.Infrastructure.Mappings;
using CSupporter.Modules.Factures.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "CSupporter.Core")]
namespace CSupporter.Modules.Factures
{
    internal static class StartupExtensions
    {
        public static IServiceCollection AddFacturesConfig(this IServiceCollection services)
        {
            services.AddTransient<IFactureRepository, FactureRepository>();
            services.AddTransient<IPositionRepository, PositionRepository>();
            services.AddScoped<IFactureService, FactureService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddDbContext<CSupporterDbContext>();

            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
