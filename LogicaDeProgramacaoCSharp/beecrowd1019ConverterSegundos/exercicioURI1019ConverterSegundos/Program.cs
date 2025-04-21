using System;

namespace exercicioURI1019ConverterSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = 3600, minuto = 60, segundo = 1, n, horaTotal, minutoTotal, segundoTotal;

            n = int.Parse(Console.ReadLine());

            horaTotal = n / hora;
            minutoTotal = n % hora / minuto;
            segundoTotal = n % minuto / segundo;

            Console.WriteLine(horaTotal + ":" + minutoTotal + ":" + segundoTotal);
        }
    }
}
