using System;
using System.Globalization;

namespace exercicio1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoA = 2, pesoB = 3, pesoC = 5, notaA, notaB, notaC, media;

            notaA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaC = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (notaA * pesoA + notaB * pesoB + notaC * pesoC) / (pesoA + pesoB + pesoC);

            Console.WriteLine("MEDIA = " + media.ToString("f1", CultureInfo.InvariantCulture));
        }
    }
}