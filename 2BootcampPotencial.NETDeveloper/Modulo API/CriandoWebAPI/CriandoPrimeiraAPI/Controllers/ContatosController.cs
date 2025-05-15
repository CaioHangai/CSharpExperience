using CriandoPrimeiraAPI.Entities;
using CriandoPrimeiraAPI.Properties.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CriandoPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatosController : ControllerBase
    {
        private readonly BdAgendaContext _bdAgendaContext;
        public ContatosController (BdAgendaContext context)
        {
            _bdAgendaContext = context;
        }

        [HttpPost]
        public IActionResult Create (Contatos contatos)
        {
            _bdAgendaContext.Add(contatos);
            _bdAgendaContext.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = contatos.Id }, contatos);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {            
            var contato = _bdAgendaContext.Contato.Find(id);

            if (contato == null)            
               return NotFound();            

            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _bdAgendaContext.Contato.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contatos contatos)
        {
            var contatoBanco = _bdAgendaContext.Contato.Find(id);

            if (contatoBanco == null)
                NotFound();

            contatoBanco.Nome = contatos.Nome;
            contatoBanco.Telefone = contatos.Telefone;
            contatoBanco.Ativo = contatos.Ativo;

            _bdAgendaContext.Contato.Update(contatoBanco);
            _bdAgendaContext.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            var contatoBanco = _bdAgendaContext.Contato.Find(id);

            if (contatoBanco == null)
                NotFound();

            _bdAgendaContext.Contato.Remove(contatoBanco);
            _bdAgendaContext.SaveChanges();
            return NoContent();
        }
    }
}
