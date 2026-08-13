

namespace Estoque
{
    internal class Produto
    {
        // Campos
        string nome;
        int quantidade;
        double preco;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;

        }

        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.quantidade -= quantidade;
        }

        public double ValorTotal()
        { 
            return preco * quantidade; 
        
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Quantidade: {quantidade}");
            Console.WriteLine($"Preço: R$ {preco}");
            Console.WriteLine($"Valor total em estoque: R$ {ValorTotal()}");
        }

    }
}
