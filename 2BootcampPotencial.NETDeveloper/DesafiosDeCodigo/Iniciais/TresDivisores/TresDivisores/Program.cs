using System;

namespace TresDivisores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroTestado = int.Parse(Console.ReadLine());
            int quantidadeDeDivisores = 0;

            for(int i = 1; i <= numeroTestado; i++)
            {
                if(numeroTestado % i == 0)
                {
                    quantidadeDeDivisores++;
                }
            }
            if(quantidadeDeDivisores >= 3)
            {
                Console.WriteLine("True");
            }else
                Console.WriteLine("False");
        }
    }
}
