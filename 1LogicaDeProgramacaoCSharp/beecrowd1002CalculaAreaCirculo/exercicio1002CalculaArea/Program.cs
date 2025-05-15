using System;
using System.Globalization;

namespace exercicio1002CalculaArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, n = 3.14159, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (n * Math.Pow(raio, 2.0));

            Console.WriteLine("A=" + area.ToString("f4", CultureInfo.InvariantCulture));

        }
    }
}
