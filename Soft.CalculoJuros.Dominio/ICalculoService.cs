namespace Soft.CalculoJuros.Dominio
{
    public interface ICalculoService
    {
        decimal CalcularJuros(decimal valorInicial, decimal juros, int meses);
    }
}
