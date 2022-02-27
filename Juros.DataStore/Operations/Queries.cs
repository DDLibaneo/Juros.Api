using System;
using System.Collections.Generic;
using System.Text;

namespace Juros.DataStore.Operations
{
    public interface IQueries
    {

    }

    public class Queries : IQueries
    {
        private readonly JurosDbContext _jurosDbContext;

        public Queries(JurosDbContext jurosDbContext)
        {
            _jurosDbContext = jurosDbContext;
        }
    }
}
