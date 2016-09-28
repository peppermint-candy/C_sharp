using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace surveyform
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
                    name: "Default",
                    template: "",
                    defaults: new {controller = "Surveyform", action = ""}
                );
            });

            App.UseStaticFiles();
        }
    }
}