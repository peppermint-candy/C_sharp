using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace ninjagold
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder App)
        {
            App.UseSession();
            App.UseStaticFiles();

            App.UseMvc();
            

        }
    }
}