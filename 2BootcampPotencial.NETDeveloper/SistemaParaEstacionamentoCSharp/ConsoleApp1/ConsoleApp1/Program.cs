// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Models;
using System.Linq;
using System.Globalization;

decimal taxaInit = 5.00M;
decimal valorHora = 2.00M;

Estacionamento es = new Estacionamento(taxaInit, valorHora);

Console.WriteLine("\n**** Seja Bem Vindo a Rede de estacionamento da Pottencial! ****");
Console.WriteLine($"A taxa inicial para estacionar é de: R$ {taxaInit} e o valor por hora é de: R$ {valorHora}: \n");

Console.Write("Deseja estacionar? (S/N): ");
char simOuNao = char.Parse(Console.ReadLine().ToUpper());

if (simOuNao == 'S')
{
    string opcao = string.Empty;
    bool exibirMenu = true;

    while (exibirMenu)
    {
        Console.Clear();
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Encerrar");

        switch (Console.ReadLine())
        {
            case "1":
                es.AdicionarVeiculos();
                break;

            case "2":
                es.RemoverVeiculos();
                break;

            case "3":
                es.ListarVeiculos();
                break;

            case "4":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
}else
{
    Console.WriteLine("\nObrigado!");
}

Console.WriteLine("Programa foi encerrado.");
