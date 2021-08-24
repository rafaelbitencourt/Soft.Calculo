using Soft.CalculoJuros.Dominio.Extensoes;

namespace Soft.CalculoJuros.Dominio
{
    public class CalculoJuros
    {
        public CalculoJuros(decimal valorInicial, int meses, decimal juros)
        {
            ValorInicial = valorInicial;
            Meses = meses;
            Juros = juros;
        }

        public decimal ValorInicial { get; private set; }
        public int Meses { get; private set; }
        public decimal Juros { get; private set; }
        public decimal ValorFinal { get; private set; }

        public void Calcular()
        {
            var valorFinal = ValorInicial * (1 + Juros).Potencia(Meses);

            ValorFinal = valorFinal.Truncar(2);
        }
    }
}
