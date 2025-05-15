using System;
using System.Globalization;

namespace exercicio1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoDeViagem, velocidadeMedia; 
            double kmPorLitro = 12.0, litrosNecessarios;

            tempoDeViagem = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            litrosNecessarios = tempoDeViagem / kmPorLitro * velocidadeMedia;

            Console.WriteLine(litrosNecessarios.ToString("f3", CultureInfo.InvariantCulture));

        }
    }
}