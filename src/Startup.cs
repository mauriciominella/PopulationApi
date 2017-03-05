using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PopulationApi.Repositories;
using PopulationApi.Services;

namespace PopulationApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICityRepository, CityRepository>();
            services.AddTransient<IPopulationService, PopulationService>();
            services.AddMvc();
            
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
