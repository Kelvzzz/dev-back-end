using Microsoft.AspNetCore.Mvc;

namespace APIpessoas.Controllers
{
    [ApiController]
   public class ProdutosController : Controller
    {
        [HttpGet("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            return Ok("Método Produtos1 funcionou");
        }
    }
}
