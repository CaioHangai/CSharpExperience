
using GerenciadorTarefasWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefasWebAPI.Context
{
    public class TarefaContext : DbContext    
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
