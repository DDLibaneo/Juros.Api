using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Juros.DataStore.Tests
{
    public class JuroDbContextFixture
    {
        private readonly SqliteConnection _sqliteConnection;

        public JurosDbContext JurosDbContext { get; set; }

        public JuroDbContextFixture()
        {
            _sqliteConnection = new SqliteConnection("DataSource=:memory:");
            _sqliteConnection.Open();

            var options = new DbContextOptionsBuilder<JurosDbContext>()
                .UseSqlite()
        }
    }
}
