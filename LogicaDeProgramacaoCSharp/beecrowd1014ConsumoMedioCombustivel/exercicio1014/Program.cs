using System;
using System.Globalization;

namespace exercicio1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaPercorrida;
            double kmPorLitro, consumoMedio;

            distanciaPercorrida = int.Parse(Console.ReadLine());
            kmPorLitro = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distanciaPercorrida / kmPorLitro;

            Console.WriteLine(consumoMedio.ToString("f3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
