using Soft.CalculoJuros.Aplicacao.CalculoJuros.Dtos;
using Soft.CalculoJuros.Infra.Taxas;

namespace Soft.CalculoJuros.Aplicacao.CalculoJuros
{
    public class AplicCalculoJuros : IAplicCalculoJuros
    {
        private readonly ITaxasService _taxasHelper;

        public AplicCalculoJuros(ITaxasService taxasHelper)
        {
            _taxasHelper = taxasHelper;
        }

        public decimal CalcularJuros(CalcularJurosDto dto)
        {
            var taxaDeJuros = _taxasHelper.RecuperarTaxaDeJuros();

            var calculoJuros = new Dominio.CalculoJuros(dto.ValorInicial, dto.Meses, taxaDeJuros);

            calculoJuros.Calcular();

            return calculoJuros.ValorFinal;
        }
    }
}
