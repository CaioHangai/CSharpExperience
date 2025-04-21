using System;
using System.Globalization;

namespace exercicio1008CalculaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncionario, qtdHoras;
            double valorHora, calcSalario;

            numFuncionario = int.Parse(Console.ReadLine());
            qtdHoras = int.Parse(Console.ReadLine());
            valorHora = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            calcSalario = qtdHoras * valorHora;

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + calcSalario.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
