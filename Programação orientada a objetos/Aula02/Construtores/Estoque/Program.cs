using Estoque;

//Declaração de variáveis
string nome;
int qtd;
double preco;

///entrada de dados
Console.WriteLine("Digite o nome do produto: ");
nome = Console.ReadLine();

Console.WriteLine("Digite a quantidade de produto: ");
qtd = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço: R$ ");
preco = double.Parse(Console.ReadLine());

Produto objeto = new Produto(nome,qtd,preco);
Produto objeto2 = new Produto(nome, preco);
Produto p = new Produto()



Console.WriteLine();
Console.ReadKey();