using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Juros.DataStore.Operations
{
    public interface ICommands
    {
        Task<(bool, int)> CreateJuro(decimal taxa);
    }

    public class Commands : ICommands
    {
        private readonly JurosDbContext _jurosDbContext;

        public Commands(JurosDbContext jurosDbContext)
        {
            _jurosDbContext = jurosDbContext;
        }
        public Task<(bool, int)> CreateJuro(decimal taxa)
        {
            throw new NotImplementedException();
        }
    }
}
