using Master.Classes.Entidades;
using Master.Enumeracoes;

//Conta contaCesar = new Conta("Cesar", 123456, 1000);
//Conta contaClodoaldo = new ContaPoupanca("Clodoaldo", 123456, 10);
//Conta senai = new ContaEmpresa("Mange", 123456, 10000); 


//Declaração de variaveis
Conta conta;
string titular;
int numero;
double saldo, limite, taxa;

//Entrada de dados
Console.WriteLine("Deseja abrir qual tipo de conta: " +
    "\n 1 - Conta pessoa fisica" +
    "\n 2 - Conta poupança" +
    "\n 3 - Conta empresa ");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine($"Tipo Escolhido = {TipoConta.Conta_Normal}");
        AbrirConta();
        break;
    case 2:
        Console.WriteLine(($"Tipo Escolhido = {TipoConta.Conta_Poupanca}"));
        AbrirPoupanca();
        break;
    case 3:
        Console.WriteLine($"Tipo Escolhido = {TipoConta.Conta_Empresa}");
        AbrirEmpresa();
        break;
    default:
        Console.WriteLine("Nenhuma opção selecionada");
        conta = null;        break;
}

conta.ExibirDados();

void AbrirConta()
{
    Console.Write("Titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero}" );
    Console.Write("Limite da conta: ");
    limite = double.Parse(Console.ReadLine());
    Console.Write("Deseja fazer depósito inical (s/n ? ");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if (opcion == 's')
    {
        Console.Write("Qual o valor do depósito inicial: ");
            saldo = double.Parse(Console.ReadLine());
        conta = new Conta(titular, numero, saldo);
    }
    else
    {
        conta = new Conta(titular, numero);
    }

    
}
void AbrirPoupanca()
{
    Console.Write("Titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta poupança: {numero}");
    Console.Write($"Taxa da conta: ");
    taxa = double.Parse(Console.ReadLine());
    Console.Write("Deseja fazer depósito inical (s/n ? ");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if (opcion == 's')
    {
        Console.Write("Qual o valor do depósito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaPoupanca(titular, numero, saldo, taxa);
    }
    else
    {
        conta = new ContaPoupanca(titular, numero, taxa);
    }

    void AbrirEmpresa()
    {
        Console.Write("Titular da conta: ");
        titular = Console.ReadLine();
        Random random = new Random();
        numero = random.Next(1000, 6000);
        Console.WriteLine($"Numero da conta : {numero}");
        Console.Write($"Limite da conta: ");
        limite = double.Parse(Console.ReadLine());
        Console.Write("Deseja fazer depósito inical (s/n ? ");
        char opcion = char.Parse(Console.ReadLine().ToLower());
        if (opcion == 's')
        {
            Console.Write("Qual o valor do depósito inicial: ");
            saldo = double.Parse(Console.ReadLine());
            conta = new ContaEmpresa(titular, numero,saldo, limite);
        }
        else
        {
            conta = new ContaEmpresa(titular, numero,limite);
        }
    }
}