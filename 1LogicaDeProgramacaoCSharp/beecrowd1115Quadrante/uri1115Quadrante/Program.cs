using System;

namespace uri1115Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            int coordenadaX, coordenadaY;

            string[] coordenada = Console.ReadLine().Split(' ');
            coordenadaX = int.Parse(coordenada[0]);
            coordenadaY = int.Parse(coordenada[1]);

            while (coordenadaX != 0 && coordenadaY != 0 )
            {
                if (coordenadaX > 0 && coordenadaY > 0)
                {
                    Console.WriteLine("primeiro");

                }
                else if (coordenadaX < 0 && coordenadaY > 0)
                {
                    Console.WriteLine("segundo");

                }
                else if (coordenadaX < 0 && coordenadaY < 0)
                {
                    Console.WriteLine("terceiro");

                }
                else
                {
                    Console.WriteLine("quarto");
                }
                coordenada = Console.ReadLine().Split(' ');
                coordenadaX = int.Parse(coordenada[0]);
                coordenadaY = int.Parse(coordenada[1]);
            }
        }
    }
}
