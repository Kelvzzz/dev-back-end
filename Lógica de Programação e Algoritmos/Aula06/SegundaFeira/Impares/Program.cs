using static System.Console;
using static System.Linq.Enumerable;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Declaração de variáveis
int x, y, controle, control;
int impar = 0;

try
{
	//Entrada de dados
	WriteLine("Digite dois numeros: ");
	x = int.Parse(ReadLine()!);
	y = int.Parse(ReadLine()!);

	//Processamento de dados



	if (x < y)
	{
		controle = x;
		control = y;
	}
	else
	{
		controle = y;
		control = x;
	}
	foreach (int a in Range(controle, control))
	{
		if(a%2 != 0 & a != x & a!= y)
        {
			impar += a;
			if (a == control)
			{
				break;
			}
        }
    }

	WriteLine($"Soma dos impares : {impar}");
}
catch (Exception erro)
{
	WriteLine($"Valor inválido, ERRO: {erro.Message}");


}

while (turistas != 0)
{
    Console.WriteLine("Informe o numero de turistas entrando ou saindo: ");
    movimento = int.Parse(Console.ReadLine()!);
    turistas += movimento;
    if (movimento > 0)
    {
        entrando += movimento;
    }
    else
    {
        voltando += Math.Abs(movimento);
    }
}
Console.WriteLine($"A quantidade de turistas que entraram foi: {entrando}\n" +
                  $"A quantidade de turistas que sairam foi: {voltando}");
break;
    }
    catch (Exception erro)
    {
    Console.WriteLine($"Valor invalido, erro: {erro}");
}