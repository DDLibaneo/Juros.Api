using System;
using Xunit;
using System.Threading.Tasks;
using Juros.Api.Controllers;
using Moq;
using Juros.Services;

namespace Juros.Api.Tests
{
    public class JurosControllerTests
    {
        private readonly JurosController _jurosController;
        private readonly Mock<IJurosService> _jurosService = new Mock<IJurosService>();

        public JurosControllerTests(JurosController jurosController)
        {
            _jurosController = jurosController;
        }

        [Fact(DisplayName = "CreateJuro - [Success] - Returns success status code and Juro Id")]
        public async Task CreateJuro_Success()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
