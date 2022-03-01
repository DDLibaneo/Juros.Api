using Juros.Common.DataCreate;
using Juros.DataStore.Operations;
using Juros.Models.Entities;
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

        [Fact(DisplayName = "GetJuro - [Success] - Retorna um objeto juro com a taxa fornecida.")]
        public async Task GetJuro_Success()
        {
            // Arrange
            var taxa = 9.99m;
            EntityCreate.SeedDbJuro(_context, taxa);

            // Act
            var result = await _queries.GetLastJuroAsync();

            // Assert
            Assert.Equal(taxa, result.Taxa);
            Assert.IsType<Juro>(result);
        }
    }
}
