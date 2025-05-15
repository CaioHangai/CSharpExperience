using System;
using System.Globalization;

namespace exercicio1011CalculaVolumeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi = 3.14159, volume;

            raio = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = ((4.0 / 3.0) * pi * Math.Pow(raio, 3.0));

            Console.WriteLine("VOLUME = " + volume.ToString("f3", CultureInfo.InvariantCulture));

        }
    }
}