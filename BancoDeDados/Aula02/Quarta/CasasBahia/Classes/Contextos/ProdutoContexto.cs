

using Microsoft.EntityFrameworkCore;

namespace CasasBahia.Classes.Contextos
{
    internal class ProdutoContexto : DbContext
    {
        //Propriedade DbSet para a entidade Produto
        public DbSet<Entidades.Produto> Produtos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcaodeConstrucao)
        {
            string config = @"Server = ECFP507D1319373\SQLEXPRESS01;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True";
            opcaodeConstrucao.UseSqlServer(config);


        }

        protected override void OnModelCreating(ModelBuilder ModeloDeConstrucao)
        {
            ModeloDeConstrucao.Entity<Entidades.Produto>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDeProduto);
                entidade.Property(e => e.ValorDoProduto);


            });
        }
    }
}