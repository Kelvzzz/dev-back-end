

using AtividadeZAbstracao.Classes.Servicos;
using AtividadeZAbstracao.Entidades;
using AtividadeZAbstracao.Entidades.Pessoa_Fisica;
using AtividadeZAbstracao.Entidades.Pessoa_Juridica;

namespace ImpostoContribuintes
{
    class Program
    {
        double saude;
        static void Main(string[] args)
        {
            List<Contribuinte> contribuintes = new();

            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i}");

                Console.Write("Pessoa fisica ou juridica (1/2): ");
                char tipo = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();


                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine());

                if (tipo == '1')
                {

                    Console.WriteLine("Gastos com saúde: ");
                    double saude = double.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaFisica(nome, renda, saude));
                }

                else
                {

                    Console.WriteLine("Numero de funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaJuridica(nome, renda, funcionarios));

                }
            }

            Console.WriteLine();
            Console.WriteLine("Impostos pagos");

            double total = 0;

            CalculadoraImposto calculadora = new CalculadoraImposto();

            foreach (Contribuinte c in contribuintes)
            {
                double imposto = CalculadoraImposto.Calcular(c);
                Console.WriteLine($"{c.Nome}: {imposto:F2}");
                total += imposto;


            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL DE IMPOSTOS: R${total:F2}");




        }
    }
}

