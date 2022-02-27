using Juros.Common.DataCreate;
using Juros.DataStore.Operations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Juros.DataStore.Tests
{

    public class QueriesTests : IClassFixture<JurosDbContextFixture>
    {
        private readonly Queries _queries;
        private readonly JurosDbContext _context;

        public QueriesTests(JurosDbContextFixture fixture)
        {
            _queries = new Queries(fixture.JurosDbContext);
            _context = fixture.JurosDbContext;
        }

        [Fact(DisplayName = "GetJuro - [Success] -")]
        public async Task GetJuro_Success()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
