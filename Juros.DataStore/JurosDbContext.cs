using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using Microsoft.EntityFrameworkCore;
using Juros.Models.Entities;

namespace Juros.DataStore
{
    public class JurosDbContext : DbContext
    {
        public JurosDbContext(DbContextOptions<JurosDbContext> options) 
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Juro> Juros { get; set; }
    }
}
