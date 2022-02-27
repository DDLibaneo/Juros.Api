using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Juros.DataStore.Tests
{
    public class JurosDbContextFixture
    {
        private readonly SqliteConnection _sqliteConnection;

        public JurosDbContext JurosDbContext { get; set; }

        public JurosDbContextFixture()
        {
            _sqliteConnection = new SqliteConnection("DataSource=:memory:");
            _sqliteConnection.Open();

            var options = new DbContextOptionsBuilder<JurosDbContext>()
                .UseSqlite(_sqliteConnection)
                .Options;

            JurosDbContext = new JurosDbContext(options);
            JurosDbContext.Database.EnsureCreated();
        }
    }
}
