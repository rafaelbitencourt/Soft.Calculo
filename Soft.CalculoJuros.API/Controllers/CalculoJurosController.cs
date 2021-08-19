using Soft.CalculoJuros.Aplicacao;
using Microsoft.AspNetCore.Mvc;

namespace Soft.CalculoJuros.API.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class CalculoJurosController : ControllerBase
    {
        private readonly IAplicCalculo _aplicCalculo;

        public CalculoJurosController(IAplicCalculo aplicCalculo)
        {
            _aplicCalculo = aplicCalculo;
        }

        [HttpGet]
        public string CalcularJuros([FromQuery] decimal valorinicial, [FromQuery] int meses)
        {
            return _aplicCalculo.CalcularJuros(valorinicial, meses).ToString("0.00");
        }
    }
}
