using // Moeda/Conversor.cs
namespace Moeda
{
    public class Conversor
    {
        public double Cotacao { get; }
        public double Quantidade { get; }

        public Conversor(double cotacao, double quantidade)
        {
            Cotacao = cotacao;
            Quantidade = quantidade;
        }

        public double Converter()
        {
            return Cotacao * Quantidade;
        }
    }
}
using System;
using Moeda;

class Program
{
    static void Main()
    {
        Console.Write("Qual é a cotação do dolar?: ");
        double cotacao = double.Parse(Console.ReadLine());

        Console.Write("Quantos dólares você vai comprar?: ");
        double quantidade = double.Parse(Console.ReadLine());

        var conversor = new Conversor(cotacao, quantidade);
        double valorfinal = conversor.Converter();

        Console.WriteLine("Valor a ser pago em reais = " + valorfinal.ToString("f2"));
    }
};

        static void Main()
        {
          

            Console.Write("Qual é a cotação do dolar?: ");
       

            Console.WriteLine("Quantos dólares você vai comprar?: ");
           

            double valorfinal = conversor.Converter();

            Console.WriteLine("Valor a ser pago em reais = " + valorfinal.ToString("f2"));
        }
    



