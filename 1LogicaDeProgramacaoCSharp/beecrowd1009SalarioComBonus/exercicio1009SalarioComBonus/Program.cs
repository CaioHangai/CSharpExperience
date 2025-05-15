using System;
using System.Globalization;

namespace exercicio1009SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo, valTotalVendas, comissao = 0.15, total;

            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valTotalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = valTotalVendas * comissao + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}