using Xunit;

namespace Soft.CalculoJuros.Tests
{
    public class CalculoJurosTest
    {
        [Fact]
        public void Calcular_RetornaValorFinalIgual()
        {
            var valorInicial = 100m;
            var meses = 5;
            var juros = 0.01m;
            var mockCalculoJuros = new Dominio.CalculoJuros(valorInicial, meses, juros);

            mockCalculoJuros.Calcular();

            Assert.Equal(105.10m, mockCalculoJuros.ValorFinal);
        }
    }
}
