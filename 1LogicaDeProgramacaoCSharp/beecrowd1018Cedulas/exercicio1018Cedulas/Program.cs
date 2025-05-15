using System;

namespace exercicio1018Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota, resto, qtdNota;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            nota = 100;
            qtdNota = resto / nota;
            Console.WriteLine(qtdNota + " nota (s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            qtdNota = resto / nota;
            Console.WriteLine(qtdNota + " nota (s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            qtdNota = resto / nota;
            Console.WriteLine(qtdNota + " nota (s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            qtdNota = resto / nota;
            Console.WriteLine(qtdNota + " nota (s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            qtdNota = resto / nota;
            Console.WriteLine(qtdNota + " nota (s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            qtdNota = resto / nota;
            Console.WriteLine(qtdNota + " nota (s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 1;
            qtdNota = resto / nota;
            
            Console.WriteLine(qtdNota + " nota (s) de R$ " + nota + ",00");
        }
    }
}