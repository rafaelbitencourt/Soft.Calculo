using Soft.CalculoJuros.Aplicacao.CalculoJuros;
using Microsoft.AspNetCore.Mvc;
using Soft.CalculoJuros.Aplicacao.CalculoJuros.Dtos;
using System.Threading.Tasks;

namespace Soft.CalculoJuros.API.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class CalculoJurosController : ControllerBase
    {
        private readonly IAplicCalculoJuros _aplicCalculo;

        public CalculoJurosController(IAplicCalculoJuros aplicCalculo)
        {
            _aplicCalculo = aplicCalculo;
        }

        [HttpGet]
        public async Task<IActionResult> CalcularJuros([FromQuery] CalcularJurosDto dto) =>
            Ok(await _aplicCalculo.CalcularJuros(dto));
    }
}
