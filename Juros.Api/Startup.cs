using Juros.Services;
using Juros.DataStore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juros.DataStore.Operations;
using Microsoft.EntityFrameworkCore;

namespace Juros.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            ConfigureApplicationServices(services);
            ConfigureDb(services);
        }

        protected virtual void ConfigureDb(IServiceCollection services)
        {
            services.AddDbContext<JurosDbContext>(options =>
            {
                options.UseSqlServer(" ", builder =>
                {
                    builder.EnableRetryOnFailure(maxRetryCount: 20, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null)
                        .CommandTimeout(300);
                });
            });
        }

        protected void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IJurosService, JurosService>();
            services.AddScoped<ICommands, Commands>();
            services.AddScoped<IQueries, Queries>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
