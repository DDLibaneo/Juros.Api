using Juros.DataStore.Operations;
using Juros.Models.Dtos;
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
            var juroDto = new JuroDto
            {
                Id = 1,
                Taxa = 21.50m,
                CreationDate = DateTime.Now
            };

            _queries.Setup()

            // Act
            var result = await _jurosService.GetLastJuro();

            // Assert
        }
    }
}
