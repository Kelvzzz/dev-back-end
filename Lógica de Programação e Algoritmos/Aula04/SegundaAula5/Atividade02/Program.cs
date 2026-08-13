//Declaração de variáveis
using System.Linq.Expressions;

double valor1, valor2, valor3;
double triangulo, perimetrotri, perimetrotra;

try
{
    //Entrada de dados
    Console.WriteLine("Digite o primeiro valor: ");
    valor1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor: ");
    valor2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o terceiro valor: ");
    valor3 = double.Parse(Console.ReadLine());
    //Processamento de dados
    Perimetro();
    Console.WriteLine($"Perimetro = {perimetrotri:f1}");
    if (valor1 + valor2 > valor3)
    {
        Console.WriteLine($"Perimetro = {perimetrotri:f1}");
    }
    else
    {
        Console.WriteLine($"Perimet")
    }


} 
catch
{ 
    Console.WriteLine("Digite valores válidos");
}
    


double Perimetro()
{
    perimetrotri = valor1 + valor2 + valor3;
    return perimetrotri;

    perimetrotra = valor1 + valor2 * valor3 / 2;
    return perimetrotra;
}  