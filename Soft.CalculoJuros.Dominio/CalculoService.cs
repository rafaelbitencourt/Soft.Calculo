using Soft.CalculoJuros.Dominio.Extensoes;

namespace Soft.CalculoJuros.Dominio
{
    public class CalculoService : ICalculoService
    {
        public decimal CalcularJuros(decimal valorInicial, decimal juros, int meses)
        {
            var valorFinal = valorInicial * (1 + juros).Potencia(meses);

            return valorFinal.Truncar(2);
        }
    }
}
