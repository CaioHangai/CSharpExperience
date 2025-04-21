using System;
using System.Globalization;

namespace uri1037Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double nrEntrada;

            nrEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nrEntrada >= 0.0 && nrEntrada <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (nrEntrada > 25.0 && nrEntrada <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (nrEntrada > 50.0 && nrEntrada <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (nrEntrada > 75.0 && nrEntrada <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else if (nrEntrada < 0.0 || nrEntrada > 100.0)
            {
                Console.WriteLine("Fora de intervalo" );
            }

        }
    }
}
