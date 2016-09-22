using Microsoft.Extensions.DependencyInjection;
namespace basic
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }   
    }
}