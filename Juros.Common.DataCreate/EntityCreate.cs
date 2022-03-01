using Juros.DataStore;
using Juros.Models.Entities;
using System;
using System.Linq;

namespace Juros.Common.DataCreate
{
    public static class EntityCreate
    {
        public static void SeedDbJuro(JurosDbContext jurosDbContext, decimal taxa)
        {
            var juro = new Juro
            {
                Taxa = taxa,
                CreationDate = DateTime.Now,
            };

            jurosDbContext.Juros.Add(juro);
            jurosDbContext.SaveChanges();
        }
    }
}
