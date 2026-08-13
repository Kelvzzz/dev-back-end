//Declaração de Variáveis
double alturamin, alturamax, altura;
int visitante, podem = 0;


try
{
    Console.WriteLine("Digite a quantidade de visitantes:");
    visitante = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura mínina permitida (em cm)");
    alturamin = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura máxima permitida ( em cm)");
    alturamax = double.Parse(Console.ReadLine());

    for (int i = 1; i <= visitante; i++)
    {
        Console.WriteLine("Altura dos visitante" + i + ": ");
        altura = double.Parse(Console.ReadLine());

        if (altura >= alturamin & altura <= alturamax)
        {
            podem++;

        }

    }
    Console.WriteLine("Quantidade de pessoas que podem andar: " + podem);

}
catch
{
    Console.WriteLine("Erro: Digite o valor correto");
}

