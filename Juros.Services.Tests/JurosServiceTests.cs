using AutoMapper;
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
        private readonly Mock<IMapper> _mapper = new Mock<IMapper>();

        public JurosServiceTests()
        {
            _jurosService = new JurosService(_commands.Object, _queries.Object, _mapper.Object);
        }
        
        [Fact(DisplayName = "CreateJuro - [Success] - Returns Juro Id")]
        public async Task CreateJuro_Success()
        {
            // Arrange
            var taxa = 8.95m;
            var expectedResult = 1;

            _commands.Setup(c => c.CreateJuroAsync(taxa))
                .ReturnsAsync(expectedResult);

            // Act
            var result = await _jurosService.CreateJuroAsync(taxa);

            // Assert
            Assert.Equal(expectedResult, result);

            var message = "CreateJuro should be called once.";
            _commands.Verify(c => c.CreateJuroAsync(taxa), Times.Once, message);
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

            var juroDto = new JuroDto
            {
                Id = juro.Id,
                Taxa = juro.Taxa,
                CreationDate = juro.CreationDate
            };

            _queries.Setup(q => q.GetLastJuroAsync())
                .ReturnsAsync(juro);
            _mapper.Setup(m => m.Map<Juro, JuroDto>(juro))
                .Returns(juroDto);

            // Act
            var result = await _jurosService.GetLastJuro();

            // Assert
            Assert.Equal(result.Id, juro.Id);
            Assert.Equal(result.Taxa, juro.Taxa);

            _queries
                .Verify(q => q.GetLastJuroAsync(), Times.Once, "GetLastJuro should be called once.");
        }
    }
}
