using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
namespace basic
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
            App.UseMvc( routes => 
            {
                routes.MapRoute(
                    name: "Default", // the route's name is only for our own reference
                    template: "", // the pattern that the route matchs
                    defaults: new {controller = "Hello", action = "Index"} // the controller and method to execute
                );
            });

            App.UseStaticFiles();

            App.UseSession();
        }   
    }
}