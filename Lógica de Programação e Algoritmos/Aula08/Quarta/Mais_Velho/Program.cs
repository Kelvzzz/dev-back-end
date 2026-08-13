//Declaração de variaveis
Dictionary<string, int> pessoas = new Dictionary<string, int>();
string nome;
int idade, n;
int valor;

try
{
    //Entrada de dados

    Console.Write("Quantas pessoas você vai digitar: ");
    n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Dados da {i+1} pessoa");
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
       idade = int.Parse(Console.ReadLine());
        pessoas.Add(nome, idade);
    }
    Console.Write("PESSOAS MAIS VELHA");
    
    
    foreach (var item in pessoas)
    {
      valor = pessoas.Values.Max(); // Pega o valor máximo do dicionário
        if (item.Value == valor) // Se o valor do item for igual ao valor máximo, imprime o nome e a idade da pessoa mais velha
        {
            Console.WriteLine($"{item.Key} tem {item.Value} anos");
        }
    }
}
catch (Exception e)
{

    Console.WriteLine("Valor invalido, erro : " + e);
}