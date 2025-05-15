using System;

namespace DiferencaProdutoESoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntrada = int.Parse(Console.ReadLine());

            int multiplicacacao = 1;
            int soma = 0;

            while (numeroEntrada > 0)
            {
                int temp = numeroEntrada % 10;
                multiplicacacao *= temp;
                soma += temp;
                numeroEntrada = numeroEntrada / 10;
            }

            int diferenca = multiplicacacao - soma;
            Console.WriteLine(diferenca);
        }       
    }
}
