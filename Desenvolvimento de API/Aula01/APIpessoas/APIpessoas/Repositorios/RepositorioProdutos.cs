using APIpessoas.Controllers.Models.Entidades;
using APIpessoas.Models.Contextos;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace APIpessoas.Repositorios
{
    public class RepositorioProdutos
    {

        //Campo
        private ProdutosContexto contexto = new ProdutosContexto();

        //Propriedades
      

        protected ProdutosContexto Contexto
        {
            get { return contexto; }
            set { contexto = value; }
        }

        //Métodos
        /// <summary>
        /// Método para listar produtos do banco de dados sqlite
        /// </summary>
        /// <returns></returns>
        public List<Produtos> ListaProdutos()
        {
            return contexto.produtos.ToList();
        }

        /// <summary>
        /// Pesquisa o ID no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Se encontrar o ID retorna o objeto, se não retorna um valor nulo -> null</returns>
        public Produtos PesquisarProdutosID(int id)
        {
            var pesquisar = contexto.produtos.FirstOrDefault(p => p.Id == id);
            return pesquisar;
        }

        /// <summary>
        /// Cria um produto na base de dados
        /// </summary>
        /// <param name="produtos">Passar para a API um JSON</param>
        /// <example>   
        /// "nome" :"TVK",
        /// "preco": 2000, 
        /// "descricao": "Toca Fita",
        /// "quantidade": -10 
        /// </example>
        public void CriarProduto(Produtos produtos)
        {
            contexto.produtos.Add(produtos);
            contexto.SaveChanges();
        }
        public void EditarProduto(Produtos produto)

        {
            Produtos p = PesquisarProdutosID(produto.Id);
            p.Nome = produto.Nome;
            p.Preco = produto.Preco;
            p.Descricao = produto.Descricao;
            p.Quantidade = produto.Quantidade;
            ProdutosContexto contexto = new ProdutosContexto();
            contexto.Update(p);
            contexto.SaveChanges();

        }
    }
}
