using Juros.DataStore;
using Juros.Models.Entities;
using System;
using System.Linq;

namespace Juros.Common.DataCreate
{
    public static class EntityCreate
    {
        public static Juro SeedDbJuro(JurosDbContext jurosDbContext, decimal taxa)
        {
            var juro = new Juro
            {
                Taxa = taxa,
            };

            jurosDbContext.Juros.Add(juro);

            jurosDbContext.SaveChanges();

            var juroDb = jurosDbContext.Juros.FirstOrDefault();

            return juroDb;
        }
    }
}
