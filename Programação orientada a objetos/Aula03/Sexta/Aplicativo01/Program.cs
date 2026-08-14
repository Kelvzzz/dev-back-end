//Declaração de variaveis
using Aplicativo01;
double raio;


//Entrada de dados

Console.Write("Entre com o valor do raio da circunferência: ");
raio = double.Parse(Console.ReadLine());

//Instanciação do objeto


//Processamento de dados



//Saida de dados
Console.WriteLine($"Cicunferência: {Calculadora.Circunferencia(raio):f2}" +
    $"Volume: {Calculadora.volume(raio):f2}");
Calculadora.PI();
