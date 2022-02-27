using Juros.Models.Dtos;
using System;
using System.Threading.Tasks;

namespace Juros.Services
{
    public interface IJurosService
    {
        Task<JuroDto> GetLastJuro();
    }

    public class JurosService : IJurosService
    {
        public Task<JuroDto> GetLastJuro()
        {
            throw new NotImplementedException();
        }
    }
}
