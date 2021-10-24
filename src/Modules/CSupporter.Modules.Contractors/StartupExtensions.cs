using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "CSupporter.Core")]
namespace CSupporter.Modules.Contractors
{
    internal static class StartupExtensions
    {
        public static IServiceCollection AddContractorsConfiguration(this IServiceCollection services)
        {
            return services;
        }
    }
}
