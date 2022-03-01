using Juros.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Juros.DataStore.Operations
{
    public interface IQueries
    {
        Task<Juro> GetLastJuroAsync();
    }

    public class Queries : IQueries
    {
        private readonly JurosDbContext _jurosDbContext;

        public Queries(JurosDbContext jurosDbContext)
        {
            _jurosDbContext = jurosDbContext;
        }

        public async Task<Juro> GetLastJuroAsync()
        {
            var juros = _jurosDbContext.Juros;

            var lastJuro = await juros
                .FirstOrDefaultAsync(j => j.CreationDate == juros.Max(j => j.CreationDate));

            return lastJuro;
        }
    }
}
