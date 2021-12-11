using CSupporter.Modules.View.Services;
using CSupporter.Modules.View.Services.IServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CSupporter.Modules.View
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
            services.AddHttpClient<IProductRequestService, ProductRequestService>();
            services.AddScoped<IProductRequestService, ProductRequestService>();
            services.AddHttpClient<IFactureRequestService, FactureRequestService>();
            services.AddScoped<IFactureRequestService, FactureRequestService>();
            services.AddHttpClient<IRequestSenderService, RequestSenderService>();
            services.AddScoped<IRequestSenderService, RequestSenderService>();
            services.AddHttpClient<IProductAPIService, ProductAPIService>();
            services.AddScoped<IProductAPIService, ProductAPIService>();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
