

namespace Moeda
{
    internal class ConversorDeMoeda
    {
        public double Cotacao;
        public double Dolar;

        public double Converter()
        {
            double valorReais = Cotacao * Dolar;
            double iof = valorReais * 0.06;

            return valorReais + iof;
        }

        internal  class ConversorDeMoedas
        {
            static void Main()
            {
                ConversorDeMoeda conversor = new ConversorDeMoeda();

                Console.WriteLine("Qual é a cotação do dólar: ");
                conversor.Cotacao = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos dólares você vai comprar: ?");
                conversor.Dolar = double.Parse(Console.ReadLine());

                double valorfinal = conversor.Converter();

                Console.WriteLine("Valor a ser pago em reais = " + valorfinal.ToString("f2"));

            }

        }
        

       


        

        

    }

}
