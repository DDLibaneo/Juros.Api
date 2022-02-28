using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Juros.DataStore.Operations
{
    public interface ICommands
    {
        Task<(bool, int)> CreateJuroAsync(decimal taxa);
    }

    public class Commands : ICommands
    {
        private readonly JurosDbContext _jurosDbContext;

        public Commands(JurosDbContext jurosDbContext)
        {
            _jurosDbContext = jurosDbContext;
        }
        public async Task<(bool, int)> CreateJuroAsync(decimal taxa)
        {
            throw new NotImplementedException();
        }
    }
}
