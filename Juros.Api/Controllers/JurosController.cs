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
    [Route("api")]
    public class JurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;

        public JurosController(IJurosService jurosService)
        {
            _jurosService = jurosService;
        }

        [HttpGet("taxa/juros")]
        public async Task<IActionResult> GetLastJuroAsync()
        {
            var juro = await _jurosService.GetLastJuro();
            return Ok(juro);
        }

        [HttpPost("taxa/juros")]
        public async Task<IActionResult> CreateJuroAsync([FromBody]TaxaDtoIn taxaDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(m => m.Value.Errors)
                    .Where(m => m.Count > 0)
                    .ToList();

                return BadRequest(errors);
            }

            var idJuro = await _jurosService.CreateJuroAsync(taxaDto.Taxa);
            return Ok(idJuro);
        }
    }
}
