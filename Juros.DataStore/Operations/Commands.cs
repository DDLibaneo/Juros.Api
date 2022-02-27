using System;
using System.Collections.Generic;
using System.Text;

namespace Juros.DataStore.Operations
{
    public interface ICommands
    { 
    
    }

    public class Commands : ICommands
    {
        private readonly JurosDbContext _jurosDbContext;

        public Commands(JurosDbContext jurosDbContext)
        {
            _jurosDbContext = jurosDbContext;
        }
    }
}
