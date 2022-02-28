using System;
using Xunit;
using System.Threading.Tasks;
using Juros.Api.Controllers;
using Moq;
using Juros.Services;
using Juros.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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

        [Fact(DisplayName = "GetJuro - [Success] - Returns JuroDto and success status code")]
        public async Task GetJuro_Success()
        {
            // Arrange
            var id = 1;
            var taxa = 10.12m;

            var expectedJuroDto = new JuroDto
            {
                Id = id,
                Taxa = taxa
            };

            _jurosService.Setup(j => j.GetLastJuro())
                .ReturnsAsync(expectedJuroDto);

            // Act
            var response = await _jurosController.GetLastJuro();

            // Assert
            var objectResult = Assert.IsType<OkObjectResult>(response);
            Assert.Equal(StatusCodes.Status200OK, objectResult.StatusCode);

            var juroDtoResult = Assert.IsType<JuroDto>(objectResult.Value);            

            Assert.Equal(juroDtoResult.Id, id);
            Assert.Equal(juroDtoResult.Taxa, taxa);

            _jurosService
                .Verify(j => j.GetLastJuro(), Times.Once(), "GetLastJuro should be called once.");
        }

        [Fact(DisplayName = "CreateJuro - [Success] - Returns success status code and Juro Id")]
        public async Task CreateJuro_Success()
        {
            // Arrange
            var id = 1;
            var taxa = 9.21m;

            _jurosService.Setup(j => j.CreateJuro(taxa))
                .ReturnsAsync(id);

            // Act
            var response = await _jurosController.CreateJuro(taxa);

            // Assert
            var objectResult = Assert.IsType<int>(response);
            Assert.Equal(objectResult, id);

            _jurosService
                .Verify(j => j.CreateJuro(taxa), Times.Once(), "CreateJuro must be called once.");
        }
    }
}
