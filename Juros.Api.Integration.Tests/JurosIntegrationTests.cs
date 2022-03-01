using Juros.Models.Dtos;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Juros.Api.Integration.Tests
{
    public class JurosIntegrationTests : IClassFixture<CommonFixture>
    {
        private readonly JurosApiFixture _apifixture;
        private readonly string URL = "/api/taxa/juros";


        public JurosIntegrationTests(CommonFixture commonFixture)
        {
            _apifixture = commonFixture.JurosApiFixture;
        }

        [Fact(DisplayName = "GetLastJuro - [Success] - Juro found")]
        public async Task GetLastJuro_Success_Found()
        {
            // Arrange
            var taxa = 10.15m;
            _apifixture.SeedDbJuro(taxa);

            // Act
            var (responseObject, statusCode) = await _apifixture.GetInApiAsync<JuroDto>(URL);

            // Assert
            Assert.IsType<JuroDto>(responseObject);
            Assert.Equal(200, (int)statusCode);
            Assert.Equal(taxa, responseObject.Taxa);
        }

        [Fact(DisplayName = "CreateJuro - [Success] - Juro created")]
        public async Task CreateJuro_Success_Created()
        {
            // Arrange
            var taxa = 4.95m;

            var taxaDto = new TaxaDtoIn
            {
                Taxa = taxa
            };

            // Act
            var (id, statusCodePost) = await _apifixture
                .PostInApiAsync<int>(URL, JToken.FromObject(taxaDto).ToString());

            // Assert
            Assert.Equal(200, (int)statusCodePost);
            Assert.IsType<int>(id);

            var (responseObject, statusCodeGet) = await _apifixture.GetInApiAsync<JuroDto>(URL);
            Assert.IsType<JuroDto>(responseObject);
            Assert.Equal(200, (int)statusCodeGet);
            Assert.Equal(taxa, responseObject.Taxa);
        }
    }
}
