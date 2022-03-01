using AutoMapper;
using Juros.DataStore.Operations;
using Juros.Models.Dtos;
using Juros.Models.Entities;
using System;
using System.Threading.Tasks;

namespace Juros.Services
{
    public class JurosService : IJurosService
    {
        private readonly ICommands _commands;
        private readonly IQueries _queries;
        private readonly IMapper _mapper;

        public JurosService(ICommands commands, IQueries queries, IMapper mapper)
        {
            _commands = commands;
            _queries = queries;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taxa"></param>
        /// <returns>Returns the JuroId.</returns>
        public async Task<int> CreateJuroAsync(decimal taxa)
        {
            var juroId = await _commands.CreateJuroAsync(taxa);
            return juroId;
        }

        public async Task<JuroDto> GetLastJuro()
        {
            var juro = await _queries.GetLastJuroAsync();

            var juroDto = _mapper.Map<Juro, JuroDto>(juro);
            
            return juroDto;
        }
    }
}
