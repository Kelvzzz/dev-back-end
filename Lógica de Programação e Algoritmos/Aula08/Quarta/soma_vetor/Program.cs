//Declaração de variaveis
double[] numeros;
double valores, soma, media;
int n;

try
{
    //Entrada de dados
    Console.Write("Quantos numeros você vai digitar? ");
    n = int.Parse(Console.ReadLine());
    numeros = new double[n]; // Declaração de um array de double com tamanho n

    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite um número: ");
        numeros[i] = double.Parse(Console.ReadLine());
    }

    Console.Write("Valores =");
    foreach (var item in numeros)
    {
        Console.Write($" {item} ");
    }
   media = numeros.Average(); // Calcula a média dos valores do array
    soma = numeros.Sum(); // Calcula a soma dos valores do array
    Console.WriteLine($"\nSoma = {soma}" +
        $"\nMedia = { media: f2}");

}
catch (Exception e)
{

    Console.WriteLine($"Valor invalido, erro: {e}");
}