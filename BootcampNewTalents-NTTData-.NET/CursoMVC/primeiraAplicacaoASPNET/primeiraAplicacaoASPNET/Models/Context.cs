using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiraAplicacaoASPNET.Models
{
    public class Context : DbContext 
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=primeiraAplicacaoASPNET;Integrated Security=true");
        }
    }
}
