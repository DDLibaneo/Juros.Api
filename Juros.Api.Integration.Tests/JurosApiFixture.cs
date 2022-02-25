using System;
using System.Net.Http;

namespace Juros.Api.Integration.Tests
{
    public class JurosApiFixture
    {
        private readonly IEnvironment _environment;

        public HttpClient Client => _environment.Client;

        public JurosApiFixture()
        {
            Initialize();
        }

        private void Initialize()
        {
            var localEnvironment = (LocalEnvironment)_environment;
        }
    }
}
