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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Juro>()
                .Property(e => e.Taxa)
                .HasColumnType("DECIMAL(5,2)");
        }

        public DbSet<Juro> Juros { get; set; }
    }
}
