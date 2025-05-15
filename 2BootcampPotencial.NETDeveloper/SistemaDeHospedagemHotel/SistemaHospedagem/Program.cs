using SistemaHospedagem.Models;
using SistemaHospedagem.Models.Exceptions;

try
{
    Console.WriteLine(" *******************************************************************************");
    Console.WriteLine(" ******************* BEM VINDO A REDE DE HOTEL POTTENCIAL **********************");
    Console.WriteLine(" *******************************************************************************");

    Console.Write(" *******************************************************************************");
    Console.WriteLine("\n **************** HOSPEDANDO-SE NO HOTEL 10 DIAS OU MAIS ***********************");
    Console.WriteLine(" ************ VOCÊ TERÁ 10% DE DESCONTO NO VALOR TOTAL DAS DIÁRIAS *************");
    Console.Write(" *******************************************************************************\n");

    Console.WriteLine("\n Favor selecionar o tipo de suite desejada:\n");
    Console.WriteLine(" 1 - Suite Gold     (Capacidade máxima: 6 hospedes, valor da diária: R$: 900.00)");
    Console.WriteLine(" 2 - Suite Silver   (Capacidade máxima: 4 hospedes, valor da diária: R$: 580.00)");
    Console.WriteLine(" 3 - Suite Platinum (Capacidade máxima: 2 hospedes, valor da diária: R$: 280.00)");
    Console.WriteLine(" 4 - Encerrar");

    Suite tipoQuarto = new Suite();

    bool exibirMenu = true;
    int selecaoMenu;

    while (exibirMenu)
    {
        switch (Console.ReadLine())
        {
            case "1":
                selecaoMenu = 1;
                tipoQuarto.SelecaoSuite(selecaoMenu);
                exibirMenu = false;
                break;

            case "2":
                selecaoMenu = 2;
                tipoQuarto.SelecaoSuite(selecaoMenu);
                exibirMenu = false;
                break;

            case "3":
                selecaoMenu = 3;
                tipoQuarto.SelecaoSuite(selecaoMenu);
                exibirMenu = false;
                break;

            case "4":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine(" Opção inválida, favor selecionar o tipo de suite desejada no menu acima ↑ ");
                break;
        }
    }

    Reserva reserva = new Reserva();

    reserva.CadastrarSuite(tipoQuarto);
    reserva.CadastrarHospedes();
    reserva.ObterQuantidadeDeHospedes();
    reserva.CalcularValorDiaria();
}
catch(DomainException e)
{
    Console.WriteLine(" \n Erro na reserva." + e.Message);
}