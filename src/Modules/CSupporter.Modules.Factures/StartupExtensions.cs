using CSupporter.Modules.Factures.Application.Services;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Modules.Factures.Infrastructure.Data;
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
            services.AddScoped<IFactureService, FactureService>();
            services.AddDbContext<CSupporterDbContext>();

            return services;
        }
    }
}
