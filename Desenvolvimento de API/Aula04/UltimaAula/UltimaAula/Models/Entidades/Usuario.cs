using System.ComponentModel.DataAnnotations;

namespace UltimaAula.Models.Entidades
{
    public class Usuario
    {
        [Key]
        
        public int ID { get; set; }
        [Required]
        [MinLength(3), MaxLength(20)]
        public string Nome { get; set; }
        [Required]
        [MinLength(6)]
        public string Senha { get; set; }
        [Required]
        public string Regra { get; set; }

        public Usuario(string nome, string senha, string regra)
        {
            Nome = nome;
            Senha = senha;
            Regra = regra;
        }
    }
}
