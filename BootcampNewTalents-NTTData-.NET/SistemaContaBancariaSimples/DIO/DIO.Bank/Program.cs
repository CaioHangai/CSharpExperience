using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {

        static List<Conta> listContas = new List<Conta>();
        
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                   Listarcontas();
                    break;

                    case "2":
                   InserirConta();
                    break;

                    case "3":
                    Transferirir();
                    break;

                    case "4":
                    Sacar();
                    break;

                    case "5":
                   Depositar();
                    break;

                    case "C":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                
                
            }
            opcaoUsuario = ObterOpcaoUsuario();
        }
        Console.WriteLine("Obrigado por utilizar nossos serviços");
        Console.ReadLine();   
        }

        

        private static void Listarcontas()
        {
            System.Console.WriteLine("Listar Contas");

            if(listContas.Count == 0)
            {
                System.Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for(int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                System.Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
           System.Console.WriteLine("Inserir nova conta");

           System.Console.WriteLine("Favor digite 1 para Conta Fisica ou 2 para Conta Juridica: ");
           int entradaTipoConta = int.Parse(Console.ReadLine());

           System.Console.WriteLine("Favor digite o nome do cliente: ");
           string entradaNome = Console.ReadLine();

           System.Console.WriteLine("Favor digite saldo inicial: ");
           double entradaSaldo = double.Parse(Console.ReadLine());

           System.Console.WriteLine("Favor digite o crédito: ");
           double entradaCredito = double.Parse(Console.ReadLine());


           Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);
            
            listContas.Add(novaConta);

        }
        private static void Transferirir()
        {
            System.Console.Write("Favor digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            System.Console.Write("Favor digite o numero da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            System.Console.Write("Favor digite o valor que deseja transferir: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);

        }
        private static void Sacar()
        {
           System.Console.Write("Favor digitar o número da conta: ");
           int indiceConta = int.Parse(Console.ReadLine());

           System.Console.Write("Favor digite o valor que deseja sacar: ");
           double valorSaque = double.Parse(Console.ReadLine());

           listContas[indiceConta].Sacar(valorSaque); 
        }
        private static void Depositar()
        {
            System.Console.Write("Favor digitar o número da conta: ");
           int indiceConta = int.Parse(Console.ReadLine());

           System.Console.Write("Favor digite o valor que deseja depositar: ");
           double valorDeposito = double.Parse(Console.ReadLine());

           listContas[indiceConta].Depositar(valorDeposito); 
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine(   );
            System.Console.WriteLine("** DIO Bank a seu dispor !! **");
            System.Console.WriteLine();
            System.Console.WriteLine("Favor informe a opção desejada: ");            
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar contas");
            System.Console.WriteLine("2 - Inseriri nova conta");
            System.Console.WriteLine("3 - Tranferir");
            System.Console.WriteLine("4 - Sacar");
            System.Console.WriteLine("5 - Depositar");
            System.Console.WriteLine("C - Limpar tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine(   );
            return opcaoUsuario;
        }

    }
}

