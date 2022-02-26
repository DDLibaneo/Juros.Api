using Juros.DataStore;
using Microsoft.AspNetCore.TestHost;
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
            var connection = new SqlLiteConnection("DataSource=:memory:");
            connection.Open();


        }
    }
}