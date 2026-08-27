//Declaração de variaveis
using Pessoas.Classes.Entidades;

int n;
List<Funcionario> listaFuncionario = new();

//Entrada de dados
Console.WriteLine("Deseja registrar quantos funcionarios?");
n = int.Parse(Console.ReadLine());


//Processamento de dados
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Coladborador nº {i + 1}");
    Console.WriteLine("O funcionario é terceirizado (s/n) ? ");
    char escolha = char.Parse(Console.ReadLine());
        Console.Write("Nome do funcionario");
        string nome = Console.ReadLine();
        Console.Write("Quantidade de horas trabalhadas: ");
        int horas = int.Parse(Console.ReadLine());
        Console.Write("Valor da hora do funcionário: ");
        double valor = double.Parse(Console.ReadLine());
   
    
    if ( escolha == 's')
    {
        //Criar um funcionario terceirizado
        listaFuncionario.Add(new Terceiro(nome, valor, horas));
    }

    else
    {
        //Criar um funcionario
        listaFuncionario.Add(new Funcionario(nome, valor, horas));
    }
}

Console.WriteLine("Pagamentos : ");

foreach (var pessoa  in listaFuncionario)
{
    Console.WriteLine($"Nome: {pessoa.NomeFuncionario} - Pagamento: {pessoa.Pagamento()}");
}