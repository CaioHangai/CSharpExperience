using System;

namespace uri1044Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            string[] multiplos = Console.ReadLine().Split(' ');
            A = int.Parse(multiplos[0]);
            B = int.Parse(multiplos[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
           else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
