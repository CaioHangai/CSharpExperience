using System;

namespace EncaixaoOuNaoEncaixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeTestes = int.Parse(Console.ReadLine());
            string[] valores = new string[2];

            for (int i = 0; i < quantidadeDeTestes; i++)
            {
                valores = Console.ReadLine().Split(' ');

                string valorA = valores[0];
                string valorB = valores[1]; 

                if (valorB.Length > valorA.Length)
                {
                    Console.WriteLine("nao encaixa");
                }

                else if (valorA.EndsWith(valorB))
                {
                    Console.WriteLine("encaixa");
                }
                else
                    Console.WriteLine("nao encaixa");
            }
        }
    }
}
