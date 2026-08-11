// Declaração de variavel
using POO2;
//Produto p = new Produto();
Produto p = new Produto();

//Entrada de dados
Console.WriteLine("Entre com os dados do produto:");
Console.Write("Nome: ");
p.nome = Console.ReadLine();
Console.Write("Preço: ");
p.preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
p.quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto:");
p.ExibirDados();

Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
int quantidade = int.Parse((Console.ReadLine() ));
p.AdicionarProdutos(quantidade);
p.ExibirDados();

Console.Write("Digite o número de produtos a ser removidos do estoque: ");
quantidade = int.Parse(Console.ReadLine());
p.RemoverProdutos(quantidade);
p.ExibirDados();
