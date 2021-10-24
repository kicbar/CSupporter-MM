using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "CSupporter.Core")]

namespace CSupporter.Modules.Products
{
    internal static class StartupExtensions
    {
        public static IServiceCollection AddProductsConfig(this IServiceCollection services)
        {
            return services;
        }
    }
}
