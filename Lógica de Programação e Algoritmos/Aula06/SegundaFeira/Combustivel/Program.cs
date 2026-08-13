//Declaração de variaveis
int codigo, alcool, gasolina, diesel;

alcool = 0;
gasolina = 0;
diesel = 0;
codigo = 0;
while (true)
    try
    {
        while (codigo != 4)
        {
            Console.WriteLine("Informe um código (1, 2, 3) ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine()!);
            if (codigo == 1)
            {
                alcool++;
            }
            else if (codigo == 2)
            {
                gasolina++;

            }
            else if (codigo == 3)
            {
                diesel++;
            }
        }
        Console.WriteLine($"MUITO OBRIGADO\n" +
            $"Alcool: {alcool}\n" +
                            $"Gasolina: {gasolina}\n" +
                            $"Diesel: {diesel}");

        break;


    }
    catch (Exception erro)
    {

        Console.WriteLine($"Valor invalido, erro: {erro}");
    }
