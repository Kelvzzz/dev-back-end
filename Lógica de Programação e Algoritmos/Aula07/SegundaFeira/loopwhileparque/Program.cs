//Declaraçaõ de variaveis
int veiculos = 0;
int turistas = 0;
string movimento = "";

while (true)
{


        //Entrada de dados
        Console.WriteLine("veiculo entrando,voltando ou sair: ");
        movimento = (Console.ReadLine()!);

        if (movimento == "sair")
        {
            break;
        }
    try
    {
        
            
            Console.WriteLine("Quantidade de turistas");
            int  quantidade = int.Parse(Console.ReadLine()!);
            
        if (movimento == "entrando")
        {
            turistas += quantidade;
            veiculos++;
        }
        else if (movimento == "voltando")
        {
            turistas -= quantidade;
            veiculos--;
        }
        else
        {
            Console.WriteLine("Movimento invalido, digite 'entrando', 'voltando' ou 'sair'");
        }


Console.WriteLine("Turistas no parque: " + turistas);
            Console.WriteLine("Veiculos no parque " + veiculos);
    }

    catch (Exception erro)
    {
        Console.WriteLine($"Valor invalido, erro: {erro}");

    }

}

Console.WriteLine("\nExpediente encerrado!");
