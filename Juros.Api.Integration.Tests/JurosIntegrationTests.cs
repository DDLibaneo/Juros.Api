using Juros.Models.Dtos;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Juros.Api.Integration.Tests
{
    public class JurosIntegrationTests : IClassFixture<CommonFixture>
    {
        private readonly JurosApiFixture _apifixture;

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
            var (responseObject, statusCode) = await _apifixture.GetInApiAsync<JuroDto>($"/api/juros");

            // Assert
            Assert.IsType<JuroDto>(responseObject);
            Assert.Equal(200, (int)statusCode);
            Assert.Equal(taxa, responseObject.Taxa);
        }

        [Fact(DisplayName = "CreateJuro - [Success] - Juro created")]
        public async Task CreateJuro_Success_Created()
        {
            // Arrange
            var taxa = 4.95;

            // Act
            var (_, statusCode) = await _apifixture.PostInApiAsync<decimal>($"/api/juros/{taxa}", null);

            // Assert
            Assert.Equal(200, (int)statusCode);            
        }
    }
}
