using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace timedisplay
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder App)
        {
            App.UseMvc( routes => 
            {
                routes.MapRoute(
                    name: "Default", //The route's name is only for our own reference
                    template: "", // the pattern that the route matches
                    defaults: new {controller = "TimeDisplay", action = "Index"} // The controller and method to execute
                );
            });

            App.UseStaticFiles();
        }
    }
}