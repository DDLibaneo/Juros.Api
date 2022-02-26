using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using Newtonsoft.Json.Linq;

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

        public async Task<(T ResponseObject, HttpStatusCode StatusCode)> GetInApi<T>(string url, string adProfile = null)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await Client.SendAsync(request);

            var responseContent = await response.Content.ReadAsStringAsync();
            var dto = JToken.Parse(responseContent).ToObject<T>();

            return (dto, response.StatusCode);
        }
    }
}
