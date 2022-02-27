using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Net;
using Newtonsoft.Json.Linq;
using Juros.Models.Entities;
using Juros.Common.DataCreate;

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

        public async Task<(T ResponseObject, HttpStatusCode StatusCode)> GetInApiAsync<T>(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await Client.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            var dto = JToken.Parse(responseContent).ToObject<T>();

            return (dto, response.StatusCode);
        }

        public async Task<(T ResponseObject, HttpStatusCode StatusCode)> PostInApiAsync<T>(string url, string jsonBody)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);

            request.Content = CreateHttpJsonBody(jsonBody);

            var response = await Client.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            var dto = JToken.Parse(responseContent)
                .ToObject<T>();

            return (dto, response.StatusCode);
        }

        private HttpContent CreateHttpJsonBody(string jsonBody)
        {
            return new StringContent(jsonBody, Encoding.UTF8, "application/json");
        }

        public Juro SeedDbJuro(decimal taxa)
        {
            var localEnvironment = (LocalEnvironment)_environment;

            var juroDb = EntityCreate.SeedDbJuro(localEnvironment.JurosDbContext, taxa);

            return juroDb;
        }
    }
}
