

namespace CasasBahia.Classes.Entidades
{
    internal class Produto
    {

        //Propriedades
        public int CodigoDoProduto { get; set; }
        public string NomeDoProduto { get; set; }
        public int QuantidadeDeProduto { get; set; }
        public decimal ValorDoProduto { get; set; }

        //Construtor
        public Produto(string nomeDoProduto, int quantidadeDeProduto, decimal valorDoProduto)
        {
            NomeDoProduto = nomeDoProduto;
            QuantidadeDeProduto = quantidadeDeProduto;
            ValorDoProduto = valorDoProduto;
        }

        //Métodos
        public void ExibirDados()
        {
            Console.WriteLine("-- Dados do produto --" +
            $"\nCódigo do Produto: {CodigoDoProduto}" +
            $"\nNome do Produto: {NomeDoProduto}" +
            $"\nQuantidade do Produto: {QuantidadeDeProduto}" +
            $"\nValor do Produto: {ValorDoProduto:C}");
        }
    }

}
