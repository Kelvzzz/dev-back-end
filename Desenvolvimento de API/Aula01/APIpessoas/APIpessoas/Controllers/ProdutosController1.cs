using APIpessoas.Controllers.Models.Entidades;
using APIpessoas.Models.Contextos;
using APIpessoas.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace APIpessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
   public class ProdutosController : Controller

    {
        RepositorioProdutos rep = new RepositorioProdutos();

        [HttpGet("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            var lista = rep.ListaProdutos();
            return Ok(lista);
        }

        [HttpGet("PesquisarProdutosID/{valorID}")]
        public IActionResult PesquisarProdutosID(int valorID)

            
        {
            try
            {
               var valor = rep.PesquisarProdutosID(valorID);
                
                if (valor != null)
                {
                    return Ok(valor);
                }
                else
                {
                    return NotFound("Valor não encontrado");
                }
            }
            catch (Exception)
            {

                return BadRequest("Valor informado incorreto, por favor pesquise somente números inteiros");
            }
            
        }

        [HttpPost("CriarProduto")]

        public IActionResult CriarProduto([FromBody]Produtos produtos)
        {
            try
            {
                rep.CriarProduto(produtos);
                return Ok("Produto criado na base de dados");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


        [HttpPut("EditarProduto/{id}")]
        public IActionResult EditarProduto(int id, [FromBody] Produtos produtos)
        {
            try
            {
                Produtos p = rep.PesquisarProdutosID(id);
                if (p == null)
                {
                    return NotFound("Produto para editar não encontrado na base de dados");
                }
                else
                {
                   
                  
                    return Ok("Produto editado com sucesso");
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }

}
