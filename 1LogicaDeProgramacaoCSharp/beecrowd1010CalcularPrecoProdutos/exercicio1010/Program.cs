using System;
using System.Globalization;

namespace exercicio1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, codigoPeca2, quantidadePeca1, quantidadePeca2;
            double valPeca1, valPeca2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(valores[0]);
            quantidadePeca1 = int.Parse(valores[1]);
            valPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(valores[0]);
            quantidadePeca2 = int.Parse(valores[1]);
            valPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = quantidadePeca1 * valPeca1 + quantidadePeca2 * valPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}