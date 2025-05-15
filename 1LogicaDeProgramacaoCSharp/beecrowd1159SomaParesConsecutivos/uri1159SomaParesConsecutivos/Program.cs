using System;

namespace uri1159SomaParesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, soma;

            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                if (X % 2 != 0)
                {
                    X++;
                }
                soma = X * 5 + 20;
                Console.WriteLine(soma);

                X = int.Parse(Console.ReadLine());
            }
           
        }
    }
}
