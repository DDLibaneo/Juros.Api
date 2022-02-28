using Juros.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }        
    }
}
