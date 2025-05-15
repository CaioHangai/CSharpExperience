using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIGerenciadorVendas.Models
{
    public static class DBMock
    {
        private static int id = 1;       
        private static Dictionary<int, Venda> vendas = new();
        
        public static void Add(Venda venda)
        {
            vendas.Add(id, venda);
            Console.WriteLine(id);
            id += 1;
        }

        public static Venda Find(int id)
        {
            vendas.TryGetValue(id, out Venda venda);
            return venda;
        }
       
        public static void Delete(int id)
        {
            vendas.Remove(id);
        }

        public static Venda Update(Venda venda)
        {
            vendas.TryGetValue(venda.Id, out Venda vendaDBMock);
            vendaDBMock.Vendedor = venda.Vendedor;
            vendaDBMock.Data = venda.Data;
            vendaDBMock.Status = venda.Status;
            vendaDBMock.Produto = venda.Produto;

            return vendaDBMock;
        }
    }
}