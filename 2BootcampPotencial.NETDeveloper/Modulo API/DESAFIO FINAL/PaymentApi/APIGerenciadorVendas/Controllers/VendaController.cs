using APIGerenciadorVendas.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGerenciadorVendas.Controllers
{
    [ApiController]
    [Route("Venda")]
    public class VendaController : ControllerBase
    {
        public VendaController()
        {

        }

        [HttpPost("CriarVenda")]
        public IActionResult CriarVenda(Venda venda)
        {
                if (!ModelState.IsValid)
                {
                    return UnprocessableEntity();
                }
                venda.Status = StatusDaVenda.AguardandoPagamento;
                venda.Data = DateTime.Now;

                DBMock.Add(venda);
                return Ok(venda);            
        }

        [HttpGet("ObterPorId{id}")]
        public IActionResult ObterPorId(int id)
        {
            var venda = DBMock.Find(id);
            
            if (venda == null)
                return NotFound();

            return Ok(venda);
        }

        [HttpPost("Atualizar")]
        public IActionResult AtualizarVenda(int id, StatusDaVenda atualizarStatus)
        {
            var venda = DBMock.Find(id);

            switch (atualizarStatus)
            {
                case StatusDaVenda.PagamentoAprovado:
                    if (venda.Status != StatusDaVenda.AguardandoPagamento)
                    {
                        return BadRequest();
                    }
                    break;
                case StatusDaVenda.EnviadoParaTransportadora:

                    if (venda.Status != StatusDaVenda.PagamentoAprovado)
                    {
                        return BadRequest();
                    }
                    break;
                case StatusDaVenda.Entregue:
                    if (venda.Status != StatusDaVenda.EnviadoParaTransportadora)
                    {
                        return BadRequest();
                    }
                    break;
                case StatusDaVenda.Cancelada:
                   if (venda.Status != StatusDaVenda.AguardandoPagamento && venda.Status != StatusDaVenda.PagamentoAprovado)
                    {
                        return BadRequest();
                    }
                    break;
            }

            venda.Status = atualizarStatus;
            var newVenda = DBMock.Update(venda);
            return Ok(newVenda);
        }
    }
}
