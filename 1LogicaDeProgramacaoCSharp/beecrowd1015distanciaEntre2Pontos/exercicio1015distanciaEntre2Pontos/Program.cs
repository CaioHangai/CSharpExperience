using System;
using System.Globalization;

namespace exercicio1015distanciaEntre2Pontos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] p1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            p1 = Console.ReadLine().Split(' ');
            x2 = double.Parse(p1[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0)  + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}