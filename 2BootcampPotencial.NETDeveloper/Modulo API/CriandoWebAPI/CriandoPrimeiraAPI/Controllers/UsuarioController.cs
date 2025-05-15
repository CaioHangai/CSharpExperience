using Microsoft.AspNetCore.Mvc;

namespace CriandoPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController: ControllerBase
       
    {
        //API QUE RETORNA A DATA E HORA ATUAL NO MOMENTO DA CONSULTA
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }

        //API QUE RETORNA UMA APRESENTACAO COM O QUE FOR PASSADO NO CAMPO nome
        [HttpGet("Apresentar/{nome})")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new { mensagem });
        }

    }
}
