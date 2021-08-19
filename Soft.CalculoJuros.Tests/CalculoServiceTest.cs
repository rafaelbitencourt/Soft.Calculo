using Soft.CalculoJuros.Dominio;
using Xunit;

namespace Soft.CalculoJuros.Tests
{
    public class CalculoServiceTest
    {
        [Fact]
        public void CalcularJuros_RetornaIgual()
        {
            var mockCalculoService = new CalculoService();
            var valorInicial = 100m;
            var meses = 5;
            var juros = 0.01m;

            var resultado = mockCalculoService.CalcularJuros(valorInicial, juros, meses);

            Assert.Equal(105.10m, resultado);
        }
    }
}
