using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;
using System.ComponentModel;

namespace SistemaERP.Classes.Contextos
{
    internal class ContextoUsuario : DbContext
    {

        //Propriedades
        public DbSet<Usuario> Usuario { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319373\SQLEXPRESS01;Database=dbdevback;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }
      
    
        
        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Usuario>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.NomeDoUsuario);
                entidade.Property(e => e.SenhaDoUsuario);
                entidade.Property(e => e.Regra);
            }
            );
        }


    }
}
