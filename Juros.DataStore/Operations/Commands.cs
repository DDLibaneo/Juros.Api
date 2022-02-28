using Juros.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Juros.DataStore.Operations
{
    public interface ICommands
    {
        Task<int> CreateJuroAsync(decimal taxa);
    }

    public class Commands : ICommands
    {
        private readonly JurosDbContext _jurosDbContext;

        public Commands(JurosDbContext jurosDbContext)
        {
            _jurosDbContext = jurosDbContext;
        }

        public async Task<int> CreateJuroAsync(decimal taxa)
        {
            var juro = new Juro
            {
                Taxa = taxa,
                CreationDate = DateTime.Now
            };

            _jurosDbContext.Juros.Add(juro);
            await _jurosDbContext.SaveChangesAsync();

            return juro.Id;
        }
    }
}
