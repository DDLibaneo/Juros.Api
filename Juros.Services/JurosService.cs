using Juros.Models.Dtos;
using System;
using System.Threading.Tasks;

namespace Juros.Services
{

    public class JurosService : IJurosService
    {

        public async Task<int> CreateJuro(decimal taxa)
        {
            throw new NotImplementedException();
        }

        public async Task<JuroDto> GetLastJuro()
        {
            throw new NotImplementedException();
        }
    }
}
