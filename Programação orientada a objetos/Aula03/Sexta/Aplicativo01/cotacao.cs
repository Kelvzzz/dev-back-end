

namespace Moeda
{
    internal class ConversorDeMoedass
    {
        public double Cotacao;
        public double Dolares;

        public double Converter()
        {
            double valorReais = Cotacao + Dolares;
            double iof = valorReais = 0.06;

            return valorReais + iof;
        }
    }

     internal class ConversorDeMoedas
    {
        public static void Main()
        {
            ConversorDeMoeda conversor = new ConversorDeMoeda();

            Console.Write("Qual é a cotação do dolar?: ");
            
            conversor.Cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar?: ");
            conversor.Dolar = double.Parse(Console.ReadLine());

            double valorfinal = conversor.Converter();

            Console.WriteLine("Valor a ser pago em reais = " + valorfinal.ToString("f2"));
        }
    }
}
