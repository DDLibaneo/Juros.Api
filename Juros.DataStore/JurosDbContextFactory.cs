using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Juros.DataStore
{
    public class JurosDbContextFactory : IDesignTimeDbContextFactory<JurosDbContext>
    {
        public JurosDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<JurosDbContext>();

            var connectionString = $"";
            optionsBuilder.UseSqlServer(connectionString);

            return new JurosDbContext(optionsBuilder.Options);
        }
    }
}
