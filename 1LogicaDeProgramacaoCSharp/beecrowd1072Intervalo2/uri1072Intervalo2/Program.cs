using System;

namespace uri1072Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int contadorIn = 0, contadorOut = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contadorIn++;
                }
                else
                {
                    contadorOut++;
                }
            }
            Console.WriteLine(contadorIn + " in");
            Console.WriteLine(contadorOut + " out");
        }
    }
}
