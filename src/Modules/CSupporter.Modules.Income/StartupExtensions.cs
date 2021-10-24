using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "CSupporter.Core")]
namespace CSupporter.Modules.Income
{
    internal static class StartupExtensions
    {
        public static IServiceCollection AddIncomeConfig(this IServiceCollection services)
        {
            return services;
        }
    }
}
