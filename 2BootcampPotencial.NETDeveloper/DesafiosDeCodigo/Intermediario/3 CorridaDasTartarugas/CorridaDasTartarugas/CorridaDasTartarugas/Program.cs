
using System;

class Desafio
{
    public static void Main()
    {
        int entradas = 3;

        while (entradas > 0)
        {
            var quantidade = Int32.Parse(Console.ReadLine());

            if (quantidade >= 1 && quantidade <= 500)
            {
                string[] tartarugas = Console.ReadLine().Split(" ");
                var maiorVelocidade = Int32.Parse(tartarugas[0]);

                for (int i = 1; i < quantidade; i++)
                {
                    var tartaruga = Int32.Parse(tartarugas[i]);

                    if (tartaruga > maiorVelocidade)
                    {
                        maiorVelocidade = tartaruga;
                    }
                }

                if (maiorVelocidade < 10)
                {
                    Console.WriteLine(1);
                }
                else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
                {
                    Console.WriteLine(2);
                }
                else if (maiorVelocidade >= 20)
                {
                    Console.WriteLine(3);
                }
                entradas--;
            }
            else
            {
                Console.WriteLine("Insira um número entre 1 e 500");
            }
        }
    }
}