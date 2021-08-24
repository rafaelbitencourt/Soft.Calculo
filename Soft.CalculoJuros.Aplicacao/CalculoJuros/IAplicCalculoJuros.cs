using Soft.CalculoJuros.Aplicacao.CalculoJuros.Dtos;
using System.Threading.Tasks;

namespace Soft.CalculoJuros.Aplicacao.CalculoJuros
{
    public interface IAplicCalculoJuros
    {
        Task<decimal> CalcularJuros(CalcularJurosDto dto);
    }
}
