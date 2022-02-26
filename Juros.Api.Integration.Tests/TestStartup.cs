using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Juros.DataStore;

namespace Juros.Api.Integration.Tests
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) 
            : base(configuration)
        { }

        protected override void ConfigureDb(IServiceCollection services)
        {
            var controllersAssemblyType = typeof(Startup).GetTypeInfo().Assembly;
            services.AddMvc().AddApplicationPart(controllersAssemblyType);

            var serviceProvider = services.BuildServiceProvider();
            var options = serviceProvider.GetService<DbContextOptions<JurosDbContext>>();
            services.AddScoped(s => new JurosDbContext(options));
        }
    }
}