using Soft.CalculoJuros.Infra;

namespace Soft.CalculoJuros.Aplicacao
{
    public class AplicCalculo : IAplicCalculo
    {
        private readonly ITaxasService _taxasHelper;

        public AplicCalculo(ITaxasService taxasHelper)
        {
            _taxasHelper = taxasHelper;
        }

        public decimal CalcularJuros(decimal valorInicial, int meses)
        {
            var taxaDeJuros = _taxasHelper.RecuperarTaxaDeJuros();

            var calculoJuros = new Dominio.CalculoJuros(valorInicial, meses, taxaDeJuros);

            calculoJuros.Calcular();

            return calculoJuros.ValorFinal;
        }
    }
}
