using CSupporter.Shared.Abstractions.IMessages.IServices;
using CSupporter.Shared.Infrastructure.Messages.Services;
using CSupporter.Shared.Infrastructure.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "CSupporter.Core")]
namespace CSupporter.Shared.Infrastructure
{
    internal static class StartupExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddHttpClient<IContractorAPIService, ContractorAPIService>();
            services.AddScoped<IContractorAPIService, ContractorAPIService>();

            services.AddHttpClient<IProductAPIService, ProductAPIService>();
            services.AddScoped<IProductAPIService, ProductAPIService>();

            services.AddControllers();
            services.AddScoped<LimitRequestsMiddleware>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CSupporter.Core", Version = "v1" });
            });

            return services;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CSupporter.Core v1"));

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseMiddleware<LimitRequestsMiddleware>();
            app.UseMiddleware<LoggingRequestsMiddleware>();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}
