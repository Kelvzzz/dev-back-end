// Dicionario
// Declaração de variaveis
using System.Runtime.InteropServices;

Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    //Código , Valor
    {1,        5.0 },
    {2,        3.50 },
    {3,        4.80 },
    {4,        8.90 },
    {5,        7.32 }
}; // Declaração de um dicionário com chave do tipo int e valor do tipo double
    int codigo, quantidade;
double preco;

try
{
    //Entrada de dados
    Console.WriteLine("Digite o código do produto: ");
    codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de produto: ");
    quantidade = int.Parse(Console.ReadLine());

    //Processamento de dados
    preco = quantidade * produtos[codigo];

    //Saida de dados
    Console.WriteLine($"Valor a pagar: {preco:c}"); // o c é formatação de dados pra virar moeda/ reais dinheiro  c = coin
}
catch (Exception e)
{

    Console.WriteLine("Valor inválido, erro: " + e);
}

