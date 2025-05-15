
using SistemaHospedagem.Models.Exceptions;

namespace SistemaHospedagem.Models
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public void CadastrarHospedes()
        {

            Console.Write(" Favor informar a quantidade de hospedes: ");
            int quantidadeDeHospedes = int.Parse(Console.ReadLine());

            if (quantidadeDeHospedes > Suite.Capacidade)
            {
                throw new DomainException(" O numero de hospedes Excede a capacidade da suite.");
            }
            else
            {
                for (int i = 1; i <= quantidadeDeHospedes; i++)
                {
                    Console.Write($" Favor digite o nome do {i}° hospede: ");
                    string nome = Console.ReadLine();

                    Console.Write($" Favor digite o sobrenome do {i}° hospede:");
                    string sobreNome = Console.ReadLine();
                    Console.WriteLine();

                    Pessoa hospede = new Pessoa(nome, sobreNome);
                    Hospedes.Add(hospede);
                }
            }
            foreach (var list in Hospedes)
            {
                Console.WriteLine($" Cliente hospedadado: {list}");
            }
        }
        public int ObterQuantidadeDeHospedes()
        {
            int contagemHospedes = 0;
            for (int i = 0; i < Hospedes.Count; i++)
            {
                contagemHospedes++;
            }
            Console.WriteLine($"\n Suite: {Suite.TipoSuite}, Total de Hospedes: {contagemHospedes}");
            return contagemHospedes;
        }
        public decimal CalcularValorDiaria()
        {
            Console.Write("\n Favor digite a data do Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write(" Favor digite a data do Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            TimeSpan duracao = checkOut.Subtract(checkIn);
            int estadia = (int)duracao.TotalDays;

            decimal valor = Suite.ValorDiaria;
            valor *= estadia;

            decimal desconto = 0.10m;
            decimal valorComDesconto;

            if (estadia >= 10)
            {
                valorComDesconto = valor * desconto;
                valor = valor - valorComDesconto;

                Console.WriteLine($"\n Sua estadia é de {estadia} diária(s). Valor total à pagar com 10% de desconto: {valor:c}");
                Console.WriteLine(" Agradecemos pela preferência! ");
            }
            else
            {
                Console.WriteLine($"\n Sua estadia é de {estadia} diária(s). Valor total à pagar: {valor:c}");
                Console.WriteLine(" Agradecemos pela preferência! ");
            }
            return valor;
        }
    }
}
