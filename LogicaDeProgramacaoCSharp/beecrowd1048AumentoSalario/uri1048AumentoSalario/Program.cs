using System;
using System.Globalization;

namespace uri1048AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento, calcAumento, novoSalario;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                aumento = 0.15;
                calcAumento = salario * aumento;
                novoSalario = calcAumento + salario;
                aumento *= 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + calcAumento.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + aumento.ToString("f0") + " %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                aumento = 0.12;
                calcAumento = salario * aumento;
                novoSalario = calcAumento + salario;
                aumento *= 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + calcAumento.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + aumento.ToString("f0") + " %");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                aumento = 0.10;
                calcAumento = salario * aumento;
                novoSalario = calcAumento + salario;
                aumento *= 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + calcAumento.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + aumento.ToString("f0") + " %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                aumento = 0.07;
                calcAumento = salario * aumento;
                novoSalario = calcAumento + salario;
                aumento *= 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + calcAumento.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + aumento.ToString("f0") + " %");
            }
            else if (salario > 2000.00)
            {
                aumento = 0.04;
                calcAumento = salario * aumento;
                novoSalario = calcAumento + salario;
                aumento *= 100;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + calcAumento.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + aumento.ToString("f0") + " %");
            }
        }

    }
}

