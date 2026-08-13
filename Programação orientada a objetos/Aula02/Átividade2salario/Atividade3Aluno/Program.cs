// Entrada de dados

try
{


    Console.Write("Nome do aluno: ");
    string nome = Console.ReadLine();

    Console.Write("Digite a nota 1: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.Write("Digite a nota 2: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.Write("Digite a nota 3: ");
    double nota3 = double.Parse(Console.ReadLine());

    // Processamento de dados
    double Notafinal = (nota1 + nota2 + nota3);

    // Saída de dados
    if (Notafinal >= 60)
    {
        Console.WriteLine("Nota final do aluno: " + Notafinal);
        Console.WriteLine("Aluno aprovado!");
    }
    else
    {
        Console.WriteLine("Nota final do aluno: " + Notafinal);
        Console.WriteLine("Aluno reprovado, faltaram " + (60 - Notafinal) + " pontos!");
    }
}
catch
{

    Console.WriteLine("Erro na digitação dos dados!");
}