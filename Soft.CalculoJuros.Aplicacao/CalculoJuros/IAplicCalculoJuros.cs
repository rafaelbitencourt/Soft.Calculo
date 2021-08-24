using Soft.CalculoJuros.Aplicacao.CalculoJuros.Dtos;

namespace Soft.CalculoJuros.Aplicacao.CalculoJuros
{
    public interface IAplicCalculoJuros
    {
        decimal CalcularJuros(CalcularJurosDto dto);
    }
}
