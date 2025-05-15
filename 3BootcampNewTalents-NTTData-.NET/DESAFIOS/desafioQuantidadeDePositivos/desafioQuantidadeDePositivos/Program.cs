using System;

namespace desafioQuantidadeDePositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInformado;
            int totalDePositivos = 0;

            for(int i = 0; i < 6; i++)
            {
                valorInformado = double.Parse(Console.ReadLine());

                if(valorInformado > 0)
                {
                    totalDePositivos ++;
                }
            }

            Console.WriteLine(totalDePositivos + " valores positivos");
        }
    }
}

