using System;
using Xunit;
using System.Threading.Tasks;
using Juros.DataStore.Operations;

namespace Juros.DataStore.Tests
{
    public class CommandsTests : IClassFixture<JurosDbContextFixture>
    {
        private readonly ICommands _commands;
        private readonly JurosDbContext _jurosDbContext;

        public CommandsTests(JurosDbContextFixture fixture)
        {
            _commands = new Commands(fixture.JurosDbContext);
            _jurosDbContext = fixture.JurosDbContext;
        }

        [Fact(DisplayName = "CreateJuroAsync - [Success] - Returns a tuple " +
            "with true and an integer")]
        public async Task CreateJuroAsync_Success()
        {
            // Arrange
            var taxa = 5.55m;

            // Act
            var result = await _commands.CreateJuroAsync(taxa);

            // Assert
            Assert.IsType<int>(result);
        }
    }
}
