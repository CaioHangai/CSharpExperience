using Microsoft.AspNetCore.Mvc;

namespace APIGerenciadorVendas.Controllers
{
    [ApiController]
    [Route("DocsAPI")]
    public class ApiDocs : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Redirect("swagger/index.html");
        }
    }
}