using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "CSupporter.Core")]
namespace CSupporter.Modules.Factures
{
    internal static class StartupExtensions
    {
        public static IServiceCollection AddFacturesConfig(this IServiceCollection services)
        {
            return services;
        }
    }
}
