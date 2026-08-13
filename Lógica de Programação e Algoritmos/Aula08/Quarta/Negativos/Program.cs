//Declaração de variáveis
List<int> numeros = new List<int>();
int n, valor;

try
{
    //Entrada de dados
    Console.Write("Quantos números você vai digitar? ");
    n = int.Parse(Console.ReadLine());

    //Loop Determinado
    for (int i = 0; i < n; i++)  //n = lenght que significa até onde voce quer que vá  // for é para gravação de dados, enquanto o foreach é para leitura de dados/ percorrer a lista até o valor ser impresso no cw
    {
        Console.WriteLine("Digite um número");
        valor = int.Parse(Console.ReadLine());
        numeros.Add(valor);
    }
    Console.WriteLine("Números Negativos : ");
    foreach (var item in numeros)
    {
        if (item < 0)
        {
            Console.WriteLine(item);
        }
    }
}
catch (Exception e)
{

    Console.WriteLine("Valor inválido, erro: " + e);
}