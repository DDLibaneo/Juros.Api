using Juros.DataStore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace Juros.Api.Integration.Tests
{
    internal class LocalEnvironment : IEnvironment
    {
        public HttpClient Client { get; }
        public JurosDbContext JurosDbContext { get; internal set; }

        private readonly TestServer _server;
        private readonly DbContextOptions<JurosDbContext> _options;

        public LocalEnvironment()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            _options = new DbContextOptionsBuilder<JurosDbContext>()
                .UseSqlite(connection)
                .Options;

            JurosDbContext = new JurosDbContext(_options);

            JurosDbContext.Database.EnsureCreated();

            var builder = new WebHostBuilder()
                .ConfigureServices(servicesCollection =>
                    servicesCollection.AddScoped(async => _options))
                .UseStartup<TestStartup>();

            _server = new TestServer(builder);
            Client = _server.CreateClient();
        }
    }
}