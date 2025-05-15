using System;
using System.Globalization;

namespace uri1040Media3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, peso1 = 2.0, peso2 = 3.0, peso3 = 4.0, peso4 = 1.0, media, exame, notaExame;

            string[] notas = Console.ReadLine().Split(' ');
            n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);


            media = ((n1 * peso1 + n2 * peso2 + n3 * peso3 + n4 * peso4) / (peso1 + peso2 + peso3 + peso4));

            if (media == 4.85f)
            {
                media = 4.8f;
            }
            else if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {

                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                notaExame = (media + exame) / 2;
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame: " + exame.ToString("f1", CultureInfo.InvariantCulture));
                if (notaExame >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + notaExame.ToString("f1", CultureInfo.InvariantCulture));
            }

        }

    }
}

