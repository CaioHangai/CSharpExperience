using System;
using System.Globalization;

class minhaClasse
{

    static void Main(string[] args)
    {

        decimal reajuste = 0.00m;
        decimal novoSalario = 0.00m;
        decimal percentual = 0.00m;

        decimal salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario >= 0.00m && salario <= 400.00m)
        {
            reajuste = 0.15m;
            percentual = reajuste * 100;                     

        }
        else if (salario >= 400.01m && salario <= 800.00m)
        {
            reajuste = 0.12m;
            percentual = reajuste * 100;

        }
        else if (salario >= 800.01m && salario <= 1200.00m)
        {
            reajuste = 0.10m;
            percentual = reajuste * 100;

        }
        else if (salario >= 1200.01m && salario <= 2000.00m)
        {
            reajuste = 0.07m;
            percentual = reajuste * 100;

        }
        else if (salario > 2000.00m)
        {
            reajuste = 0.04m;
            percentual = reajuste * 100;
        }

        novoSalario = salario + salario * reajuste ;
        reajuste = salario * reajuste;

        Console.WriteLine($"Novo salario: {novoSalario.ToString("f2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Reajuste ganho: {reajuste.ToString("f2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("Em percentual: " + percentual.ToString("F0") + " %");

    }
}