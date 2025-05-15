
namespace ConsoleApp1.Models
{
    internal class Estacionamento
    {
        public decimal TaxaInicial { get; set; }

        public decimal ValorPorHora { get; set; }

        List<string> Veiculos = new List<string>();

        public Estacionamento(decimal taxaInicial, decimal valorPorHora)
        {
            this.TaxaInicial = taxaInicial;
            this.ValorPorHora = valorPorHora;

        }
        public void AdicionarVeiculos()
        {
            Console.WriteLine("Favor digitar a placa do veículo que será estacionado: ");
            string veiculos = Console.ReadLine();
            Veiculos.Add(veiculos);
        }

        public void RemoverVeiculos()
        {
            Console.WriteLine("Digite a placa do veículo que será removido do estacionamento:");
            string placaVeiculo = Console.ReadLine();


            if (Veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int totalDeHoras = int.Parse(Console.ReadLine());
                decimal valorTotal = totalDeHoras * ValorPorHora + TaxaInicial;
                Veiculos.Remove(placaVeiculo);

                Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("As placas dos veículos estacionados são:");
                foreach (string cars in Veiculos)
                {
                    Console.WriteLine(cars);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

    }
}
