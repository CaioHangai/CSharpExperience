/*                                                          ** DESAFIO **

Dado um array **nums** de tamanho **n**, retorne o **elemento majoritário**, isto é, o elemento que aparece o maior número de vezes no seu array.

 **Entrada**

A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas **nums** serão os valores da sua array.

 **Saída**

A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.*/
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