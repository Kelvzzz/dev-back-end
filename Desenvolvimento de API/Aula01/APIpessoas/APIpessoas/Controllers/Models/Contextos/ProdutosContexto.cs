using APIpessoas.Controllers.Models.Entidades;

using Microsoft.EntityFrameworkCore;
namespace APIpessoas.Models.Contextos;

public class ProdutosContexto : DbContext
{
    public DbSet<Produtos> produtos { get; set; }



    //Métodos
    protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
    {
        string caminho = "Data Source=produtos.db";
        opcoesDeConstrucao.UseSqlite(caminho);
    }




    protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
    {
        modeloDeConstrucao.Entity<Produtos>(entidade =>
        {

            entidade.HasKey(e => e.Id);
            entidade.Property(e => e.Nome);
            entidade.Property(e => e.Descricao);
            entidade.Property(e => e.Preco);
            entidade.Property(e => e.Quantidade);
        });

    }
}




