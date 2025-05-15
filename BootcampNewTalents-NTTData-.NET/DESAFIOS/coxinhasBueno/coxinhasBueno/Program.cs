using System;
using System.Globalization;

namespace coxinhasBueno
{
    class Program
    {
        static void Main(string[] args)
        {
            double coxinhas, participantes, mediaCoxinhasConsumidas;

            string[] entDados = Console.ReadLine().Split(' ');

            coxinhas = double.Parse(entDados[0], CultureInfo.InvariantCulture);
            participantes = double.Parse(entDados[1], CultureInfo.InvariantCulture);

            mediaCoxinhasConsumidas = coxinhas / participantes;

            if(coxinhas % participantes != 0)
            {
                Console.WriteLine(Math.Round(mediaCoxinhasConsumidas, 2).ToString("f2", CultureInfo.InvariantCulture));
            }
            else
                Console.WriteLine(mediaCoxinhasConsumidas.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
