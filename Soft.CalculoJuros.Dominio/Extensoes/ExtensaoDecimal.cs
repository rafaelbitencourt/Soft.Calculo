using System;

namespace Soft.CalculoJuros.Dominio.Extensoes
{
    public static class ExtensaoDecimal
    {
        public static decimal Potencia(this decimal valor, int potencia)
        {
            return (decimal)Math.Pow((double)valor, potencia);
        }

        public static decimal Truncar(this decimal valor, int precisao)
        {
            decimal num = (decimal)Math.Pow(10.0, precisao);
            return Math.Truncate(num * valor) / num;
        }
    }
}
