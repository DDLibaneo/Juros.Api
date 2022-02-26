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

        [Fact(DisplayName = "GetJuro [Success] - Juro found")]
        public async Task GetJuro_Found_Success()
        {

        }
    }
}
