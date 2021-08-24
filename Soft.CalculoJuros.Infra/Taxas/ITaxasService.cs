using System.Threading.Tasks;

namespace Soft.CalculoJuros.Infra.Taxas
{
    public interface ITaxasService
    {
        Task<decimal> RecuperarTaxaDeJuros();
    }
}
