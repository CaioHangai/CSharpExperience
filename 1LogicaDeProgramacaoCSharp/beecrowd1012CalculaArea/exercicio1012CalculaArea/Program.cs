using System;
using System.Globalization;

namespace exercicio1012CalculaArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, pi = 3.14159, areaTriangoloRetangulo, areaCirculoRaio, areaTrapezio, areaQuadrado, areaRetangulo;

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTriangoloRetangulo = a * c / 2.0;
            areaCirculoRaio = ( pi * Math.Pow(c, 2.0));
            areaTrapezio = (a + b) / 2.0 * c;
            areaQuadrado = Math.Pow(b, 2.0);
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangoloRetangulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculoRaio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("f3", CultureInfo.InvariantCulture));

        }
    }
}