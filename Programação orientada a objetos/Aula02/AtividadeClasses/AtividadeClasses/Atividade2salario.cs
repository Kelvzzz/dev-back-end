using System;

namespace Class2
{
    internal class Atividade2salario
    {
        //Declaração de Variaveis
        double Salarioliquido;
        double Aumentarporcentagem;
        double porcentagemaumentada;

        //Entrada de dados
        public static void Main()
        {
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
            Aumentarporcentagem += SalarioLíquido * (Aumentarporcentagem / 100);




        }
    }
}
