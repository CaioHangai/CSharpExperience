using ApiCatalogoJogos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Repositories
{
    public interface IJogosRepository : IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);

        Task<Jogo> Obter(Guid id);

        Task<List<Jogo>> Obter(string nome, string produto);

        Task Inserir(Jogo jogo);

        Task Atualizar(Jogo jogo);

        Task Remover(Guid id);
    }
}
