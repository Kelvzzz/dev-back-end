
const string janela = "Problema medidas"; // para alocar em outra parte da memoria
Console.Title = janela;

//Declaração de variaveis
double a, b, c, quadrado, triangulo, trapezio;

//Entrada de Dados
Console.WriteLine("Digite a medida A: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida B: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida C: ");
c = double.Parse(Console.ReadLine());

// Processamento de dados
AreaQuadrado();
AreaTriangulo();
AreaTrapezio();

Console.ReadKey();

double AreaQuadrado()
{
    string nome = "SENAI";
    quadrado = a * a;
    return quadrado;
}

double AreaTriangulo()
{
    triangulo = (a * b) / 2;
    return triangulo;
}
    double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
}
void Saida()
{
    Console.WriteLine(($"A area do quadrado = {quadrado:f4}\n" + 
        $"A area do triangulo é {triangulo:f4}\n" + 
        $"A área do trapézio é {trapezio:f4}"));
}