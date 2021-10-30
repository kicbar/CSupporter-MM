using CSupporter.Modules.Contractors.Data;
using CSupporter.Modules.Contractors.Repositories;
using CSupporter.Modules.Contractors.Repositories.Abstractions;
using CSupporter.Modules.Contractors.Services;
using CSupporter.Modules.Contractors.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "CSupporter.Core")]
namespace CSupporter.Modules.Contractors
{
    internal static class StartupExtensions
    {
        public static IServiceCollection AddContractorsConfig(this IServiceCollection services)
        {
            services.AddTransient<IContractorRepository, ContractorRepository>();
            services.AddScoped<IContractorService, ContractorService>();

            services.AddDbContext<CSupporterDbContext>();
            return services;
        }
    }
}
