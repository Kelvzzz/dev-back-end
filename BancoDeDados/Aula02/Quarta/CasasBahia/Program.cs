

using CasasBahia.Classes.Contextos;
using CasasBahia.Classes.Entidades;

ProdutoContexto contexto = new ProdutoContexto();

contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("-- Menu do almoxarifado --" +
        "\n1 - Consultar item no esque" +
        "\n2 - Cadastrar novo produto" +
        "\n3 - Sair");
    Console.Write("\nEscolha uma opção:");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            //Consulta ao item no estoque
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
            if (codigoProduto != null)
            {
                codigoProduto.ExibirDados();
            }
            else
            {
                Console.WriteLine($"Código do produto não encontrado, código: {codigo}\n");
            }
            break;

            case 2:
            //Cadastro no item no estoque

           CadastroDeItem(contexto);


            break;
            
        case 3:
          //Deletar item no estoque

            break;
        case 4:
            //Sair
            continuar = false;
            Console.WriteLine("Encerrando o sistema...");
            break
    }
}

void CadastroDeItem(ProdutoContexto produto)
{
    Console.WriteLine(" === Cadastro de Item ===");
    Console.WriteLine("Digite o nome do produto:");
    string nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome) | string.IsNullOrWhiteSpace(nome)) ;
    {
        Console.WriteLine("Não permitido cadastro de produto sem nome");
        return;
    }
    if(string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Não permitido cadastro de produto vazio");
        return;
    }
    Console.WriteLine("Digite a quantidade do produto:");
    int qtd = int.Parse(Console.ReadLine());
    if (qtd < 0)
    {
        Console.WriteLine("Não permitido cadastro de produto com valor negativo");
        return;
    }
    Console.WriteLine("Digite o custo do produto:");
    decimal valor = decimal.Parse(Console.ReadLine());
    if ( valor<0)
    {
        Console.WriteLine("Não permitido cadastro de produto com valor negativo");

    }

    Produto produto1 = new Produto(nome, qtd, valor);
    contexto.Produtos.Add(produto1);
    contexto.SaveChanges();
    produto1.ExibirDados();
}

void DeletarItem(ProdutoContexto contexto)
{
    Console.Write("Digite o código do produto: ");
    int codigo = int.Parse(Console.ReadLine());
    var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
    if (codigoProduto != null)
    {
        Console.Write("Deseja realmente realizar esta operação? (s/n): ");
        char escolha = char.Parse(Console.ReadLine().ToLower());
        if (escolha.Equals('s'))
        {
            contexto.Produtos.Remove(codigoProduto);
            contexto.SaveChanges();
            Console.WriteLine("Produto deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Operação cancelada.");
        }
        }
    else
    {
        Console.WriteLine("Produto não encontrado.");
    }
}