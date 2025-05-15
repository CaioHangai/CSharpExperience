// See https://aka.ms/new-console-template for more information

int senha;

senha = int.Parse (Console.ReadLine());


while (senha != 2002)
{
    Console.WriteLine("Senha Invalida");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso Permitido");

