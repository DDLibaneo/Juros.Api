using Juros.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juros.Api.Controllers
{
    [ApiController]
    [Route("api/juros")]
    public class JurosController
    {
        private readonly IJurosService _jurosService;

        public JurosController(IJurosService jurosService)
        {
            _jurosService = jurosService;
        }

        [HttpGet("taxa/juros")]
        public async Task<IActionResult> GetLast()
        {
            throw new NotImplementedException();
        }

        [HttpPost("taxa/juros")]
        public async Task<IActionResult> CreateJuro(decimal taxa)
        {
            throw new NotImplementedException();
        }
    }
}
