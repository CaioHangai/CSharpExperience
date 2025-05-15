
using AbsttacaoCelular.Models;

Console.WriteLine("Favor selecione o aparelho:");

Console.WriteLine(" 1 - Smartphone Nokia");
Console.WriteLine(" 2 - Iphone");
Console.WriteLine(" 3 - Encerar");

bool exibirMenu = true;
int selecaoMenu;

while (exibirMenu)
{
    switch (Console.ReadLine())
    {
        case "1":
            selecaoMenu = 1;
            Smartphone nokia = new Nokia( numero: "123456", modelo: "Modelo Tijolão", imei: "666666", memoria: 64 );
            nokia.Ligar();
            nokia.InstalarAplicativo("Jogo cobrinha");
            exibirMenu = false;
            break;

        case "2":
            selecaoMenu = 2;
            Smartphone iphone = new Iphone(numero: "654321", modelo: "14 Pro Max", imei: "251657", memoria: 512);
            iphone.Ligar();
            iphone.InstalarAplicativo("Tik Tok");
            iphone.ReceberLigacao();
            exibirMenu = false;
            break;

        case "3":            
            exibirMenu = false;
            break;                  

        default:
            Console.WriteLine(" Opção inválida, favor selecionar o tipo de celular no menu acima ↑ ");
            break;
    }
}