using AutoMapper;
using CSupporter.Modules.Products.Application.Services;
using CSupporter.Modules.Products.Domain.Interfaces;
using CSupporter.Modules.Products.Infrastructure.Data;
using CSupporter.Modules.Products.Infrastructure.Mappings;
using CSupporter.Modules.Products.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "CSupporter.Core")]
namespace CSupporter.Modules.Income
{
    internal static class StartupExtensions
    {
        public static IServiceCollection AddIncomeConfig(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<CSupporterDbContext>();

            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
