using Juros.DataStore.Operations;
using Juros.Models.Dtos;
using Juros.Models.Entities;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Juros.Services.Tests
{
    public class JurosServiceTests
    {
        private readonly JurosService _jurosService;
        private readonly Mock<IQueries> _queries = new Mock<IQueries>();
        private readonly Mock<ICommands> _commands = new Mock<ICommands>();

        public JurosServiceTests()
        {
            _jurosService = new JurosService();
        }
        
        [Fact(DisplayName = "CreateJuro - [Success] - Returns Juro Id")]
        public async Task CreateJuro_Success()
        {
            // Arrange

            // Act
            

            // Assert

        }

        [Fact(DisplayName = "GetLastJuro - [Success] - Returns JuroDto")]
        public async Task GetLastJuro_Success()
        {
            // Arrange
            var juro = new Juro
            {
                Id = 1,
                Taxa = 21.50m,
                CreationDate = DateTime.Now
            };

            _queries.Setup(q => q.GetLastJuro())
                .ReturnsAsync(juro);

            // Act
            var result = await _jurosService.GetLastJuro();

            // Assert
            Assert.Equal(result.Id, juro.Id);
            Assert.Equal(result.Taxa, juro.Taxa);

            _queries
                .Verify(q => q.GetLastJuro(), Times.Once, "GetLastJuro should be called once.");
        }
    }
}
