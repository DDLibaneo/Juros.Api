using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace Juros.Api.Integration.Tests
{
    internal class LocalEnvironment : IEnvironment
    {
        public HttpClient Client { get; }

        private readonly TestServer _server;
        //private readonly DbContextOptions<>
    }
}