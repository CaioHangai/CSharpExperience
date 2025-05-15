using GerenciadorTarefasWebAPI.Context;
using GerenciadorTarefasWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace GerenciadorTarefasWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly TarefaContext _context;
        public TarefaController(TarefaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarTarefa(Tarefa tarefa)
        {
            _context.Add(tarefa);
            _context.SaveChanges();

            return Ok(tarefa);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
                return NotFound();

            return Ok(tarefa);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa tarefaStatus)
        {
            var tarefa = _context.Tarefas.Where(x => x.Status == tarefaStatus);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string obterTitulo)
        {
            var tarefa = _context.Tarefas.Where(x => x.Titulo.Contains(obterTitulo));
            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var tarefa = _context.Tarefas;

            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;

            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
