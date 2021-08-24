using Soft.CalculoJuros.Aplicacao.CalculoJuros;
using Microsoft.AspNetCore.Mvc;
using Soft.CalculoJuros.Aplicacao.CalculoJuros.Dtos;

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
        public IActionResult CalcularJuros([FromQuery] CalcularJurosDto dto) =>
            Ok(_aplicCalculo.CalcularJuros(dto));
    }
}
