using System;
using System.Globalization;

namespace exercicio1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoA = 3.5, pesoB = 7.5, notaA, notaB, media;

            notaA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (notaA * pesoA + notaB * pesoB) / (pesoA + pesoB);

            Console.WriteLine("MEDIA = " + media.ToString("f5", CultureInfo.InvariantCulture));
        }
    }
}