using Juros.Models.Dtos;
using System.Threading.Tasks;

namespace Juros.Services
{
    public interface IJurosService
    {
        Task<JuroDto> GetLastJuro();

        /// <summary>
        /// Creates a Juro.
        /// </summary>
        /// <returns>Returns the Juro Id.</returns>
        Task<int> CreateJuroAsync(decimal taxa);
    }
}
