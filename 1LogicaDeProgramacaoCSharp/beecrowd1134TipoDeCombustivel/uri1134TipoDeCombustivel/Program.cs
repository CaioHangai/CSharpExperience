using System;

namespace uri1134TipoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntrada, alcool = 0, gasolina = 0, diesel = 0;
            

            numeroEntrada = int.Parse(Console.ReadLine());

            while (numeroEntrada != 4)
            {
                if (numeroEntrada == 1)
                {
                   alcool++;
                }
                else if (numeroEntrada == 2)
                {
                    gasolina++;
                }
                else if (numeroEntrada == 3)
                {
                    diesel++;
                }
                numeroEntrada = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
