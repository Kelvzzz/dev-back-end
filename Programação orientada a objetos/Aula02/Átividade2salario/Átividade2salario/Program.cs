


Console.WriteLine("Digite o nome do funcionário: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite o salário bruto do funcionário: ");
double SalarioBruto = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor total de imposto a ser pago pelo funcionario: ");
double Imposto = double.Parse(Console.ReadLine());

//Processamento de dados
double SalarioLíquido = SalarioBruto - Imposto;

Console.WriteLine("Dados do funcionário:");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Salário Líquido: R$ " + SalarioLíquido);

Console.WriteLine("Digite a porcentagem de aumento do salario do funcionario: ");
double Aumentarporcentagem = double.Parse(Console.ReadLine());
Aumentarporcentagem = SalarioBruto * (Aumentarporcentagem / 100);

//Saída de dados
Console.WriteLine("Dados do funcionário atualizados:");
Console.WriteLine("Nome do funcionário: " + nome);
Console.WriteLine("Salário Líquido: R$ " + ((SalarioBruto - Imposto) + Aumentarporcentagem));

