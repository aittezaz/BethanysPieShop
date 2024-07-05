using BethanysPieShop.Models;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions;
using Microsoft.Extensions.DependencyInjection;


namespace BethanysPieShop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddMvc();
            services.AddHttpContextAccessor();
            services.AddScoped<IPieRepository, MockPieRepository>();
            services.AddScoped<ICategoryRepository, MockCategoryRepository>();
        services.AddControllersWithViews();

}
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); 
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
        
        
            app.UseEndpoints(Endpoint =>
        {
            Endpoint.MapControllerRoute(
                 name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
        });


        }
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
