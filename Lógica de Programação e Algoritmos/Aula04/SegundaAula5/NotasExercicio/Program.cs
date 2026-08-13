//Declaração de variaveis
double nota1, nota2, notafinal;

try
{
    // Entrada de dados
    Console.WriteLine("Digite a primeira nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a segunda nota: ");
    nota2 = double.Parse(Console.ReadLine());
    //Processamento de dados
    Nota(); // utilizado para fazer a função funcionar, somando as notas e fazendo o return
    //Saída de dados
    Console.WriteLine($"Nota final = {notafinal:f1}");
    if(notafinal < 60)
    {
        Console.WriteLine("Reprovado");
    }    
    else
    {
        Console.WriteLine("Aprovado");
    }
}

catch
{
    Console.WriteLine("Digite valores válidos");
}

double Nota()
{
    notafinal = nota1 + nota2;
    return notafinal;
}
