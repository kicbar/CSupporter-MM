using CSupporter.Modules.Contractors;
using CSupporter.Modules.Factures;
using CSupporter.Modules.Income;
using CSupporter.Modules.Products;
using CSupporter.Shared.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CSupporter.Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInfrastructure()
                    .AddContractorsConfig()
                    .AddFacturesConfig()
                    .AddIncomeConfig()
                    .AddProductsConfig();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseInfrastructure();
        }
    }
}
