using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace APIpessoas.Controllers.Models.Entidades
{
    public class Produtos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Para cadastrar um produto inserir um nome de um produto")]
        [Length(2, 15, ErrorMessage = "O nome do produto deve ter entre 2 e 15 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Range(0, 30000, ErrorMessage = "O preço do produto deve estar entre 0 e 50.000")]
        public decimal Preco { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "A quantidade do produto deve estar entre 0 e 100")]
        public int Quantidade { get; set; }


        public Produtos(string nome, decimal preco, string descricao, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
        }

    }
}
