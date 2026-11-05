
using Microsoft.EntityFrameworkCore;
namespace UltimaAula.Models.Entidades.Contextos
    
{
    public class ContextoUsuario : DbContext
    {

        public DbSet<Usuario> usuarios { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Data Source = Usuarios.db";
            opcoesDeConstrucao.UseSqlite(caminho);

        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Usuario>(entidade =>
            {
                entidade.HasKey(e => e.ID);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.Senha);

                entidade.Property(e => e.Regra);

            }

        );
        }


    }
}
