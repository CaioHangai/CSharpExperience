using System;

public class Program
{
    public static void Main(String[] args)
    {
        int tamanhoArr = int.Parse(Console.ReadLine());

        int[] elemento = new int[tamanhoArr];

        for (int i = 0; i < tamanhoArr; i++)
        {
            elemento[i] = int.Parse(Console.ReadLine());
        }

        int count = 1;
        int numeroMajoritario = elemento[0];

        for (int i = 0; i < elemento.Length; i++)

            if (elemento[i] != numeroMajoritario)
            {
                numeroMajoritario = elemento[i];
                count++;
            }
            else
            {
                if (numeroMajoritario == elemento[i])
                {
                    count++;
                }                
            }

        Console.WriteLine(numeroMajoritario);
    }
}