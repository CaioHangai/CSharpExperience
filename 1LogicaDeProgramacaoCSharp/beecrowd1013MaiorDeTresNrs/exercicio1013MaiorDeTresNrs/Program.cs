using System;

namespace exercicio1013MaiorDeTresNrs
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, maiorAB, maior;
            string[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;


            Console.WriteLine(maior + " eh o maior");
        }
    }
}