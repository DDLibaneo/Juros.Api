using Juros.DataStore.Operations;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Juros.Services.Tests
{
    public class JurosServiceTests
    {
        private readonly JurosService _service;
        private readonly Mock<ICommands> _commands = new Mock<ICommands>();
        
        [Fact(DisplayName = "CreateJuro - [Success] - Returns Juro Id")]
        public async Task CreateJuro_Success(string taxa)
        {
            // Arrange
             
            // Act

            // Assert
        }
    }
}
