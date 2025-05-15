using System;
using System.Globalization;

namespace uri1154Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            double novaIdade, idade = 0, idadeMedia;
            int contador = 0;

            novaIdade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(novaIdade > 0)
            {
                idade += novaIdade;
                contador++;
                novaIdade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            idadeMedia = idade / contador;
            Console.WriteLine(idadeMedia.ToString ("F2", CultureInfo.InvariantCulture));            
        }

    }
}
