using CriandoPrimeiraAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CriandoPrimeiraAPI.Properties.Context
{
    public class BdAgendaContext:DbContext
    {
        public BdAgendaContext(DbContextOptions<BdAgendaContext> options) : base(options)
        {

        }

        public DbSet<Contatos> Contato { get; set; } 
    }
}
