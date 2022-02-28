using Juros.Models.Dtos;
using Juros.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juros.Api.Controllers
{
    [ApiController]
    [Route("api/juros")]
    public class JurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;

        public JurosController(IJurosService jurosService)
        {
            _jurosService = jurosService;
        }

        [HttpGet("taxa/juros")]
        public async Task<IActionResult> GetLastJuro()
        {
            var juro = await _jurosService.GetLastJuro();
            return Ok(juro);
        }

        [HttpPost("taxa/juros/{id}")]
        public async Task<IActionResult> CreateJuro(decimal taxa)
        {
            var idJuro = _jurosService.CreateJuro(taxa);
            return Ok(idJuro);
        }
    }
}
