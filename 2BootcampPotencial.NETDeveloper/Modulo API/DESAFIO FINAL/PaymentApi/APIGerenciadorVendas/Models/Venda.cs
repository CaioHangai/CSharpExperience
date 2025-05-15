namespace APIGerenciadorVendas.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Vendedor Vendedor { get; set; }
        public DateTime Data { get; set; }
        public List<Produto> Produto { get; set; }
        public StatusDaVenda Status { get; set; }
    }
}
