using Soft.CalculoJuros.Dominio;
using Soft.CalculoJuros.Infra;

namespace Soft.CalculoJuros.Aplicacao
{
    public class AplicCalculo : IAplicCalculo
    {
        private readonly ICalculoService _calculoService;
        private readonly ITaxasHelper _taxasHelper;

        public AplicCalculo(ICalculoService calculoService, ITaxasHelper taxasHelper)
        {
            _calculoService = calculoService;
            _taxasHelper = taxasHelper;
        }

        public decimal CalcularJuros(decimal valorInicial, int meses)
        {
            var taxaDeJuros = _taxasHelper.RecuperarTaxaDeJuros();

            return _calculoService.CalcularJuros(valorInicial, taxaDeJuros, meses);
        }
    }
}
