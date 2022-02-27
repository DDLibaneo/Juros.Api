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

        [Fact(DisplayName = "InsertJuro - [Success]")]
        public async Task InsertJuro_Success()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
