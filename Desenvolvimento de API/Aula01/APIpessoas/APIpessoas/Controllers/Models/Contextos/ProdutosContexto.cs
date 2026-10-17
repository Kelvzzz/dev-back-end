using APIpessoas.Controllers.Models.Entidades;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
namespace APIpessoas.Models.Contextos; 
   {

    public class ProdutosContexto : DbContext
    {
        public DbSet<Produtos> produtos { get; set; }

    //Métodos 

    //Métodos
    protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
    {
        string caminho = "";
        opcoesDeConstrucao.UseSqlite(caminho);
    }

}
}
