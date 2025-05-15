using System;
using System.Globalization;

namespace uri1038Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            int  codProd, qtdProd;
            double produto, total;

            string[] pedido = Console.ReadLine().Split(' ');
            codProd = int.Parse(pedido[0]);
            qtdProd = int.Parse(pedido[1]);

            switch (codProd)
            {
                case 1:
                    produto = 4.00;
                    total = qtdProd * produto;
                    Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
                    break;

                case 2:
                    produto = 4.50;
                    total = qtdProd * produto;
                    Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
                    break;

                case 3:
                    produto = 5.00;
                    total = qtdProd * produto;
                    Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
                    break;

                case 4:
                    produto = 2.00;
                    total = qtdProd * produto;
                    Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
                    break;

                case 5:
                    produto = 1.50;
                    total = qtdProd * produto;
                    Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
                    break;

                default:                    
                    break;                    
            }          
        }
    }
}
