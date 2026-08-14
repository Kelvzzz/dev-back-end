
namespace Aplicativo01
{
    internal class Calculadora
    {
        //Membros
        // Campos
        double raio;
        public const double pi = 3.1415;

        // Segundo membro da classe - Construtor
        public Calculadora(double raio)
        {
            this.raio = raio;
        }


        // Terceiro membro da classe - Métodos
        public double Circunferencia()
        {
            return 2 * pi * raio;
        }

        public double volume()
        {
            return 4 * pi * Math.Pow(raio, 3) / 3;
        }

        public void PI()
        {
            Console.WriteLine(pi);
        }


    }
}
