using System;
using System.Globalization;

namespace calcularDuasNotasValidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            int contador = 0;

            do
            {
                double notaDaProva = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (notaDaProva < 0 || notaDaProva > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    contador++;
                    media += notaDaProva;
                }
            } while (contador < 2);

            Console.WriteLine("media = " + (media / 2).ToString("n2", CultureInfo.InvariantCulture));
        }
    }
}
