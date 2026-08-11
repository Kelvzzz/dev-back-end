
namespace Triangulo_Com_POO
{
    internal class Triangulo
    {
        //Membros
        //Primeiro membro -> Campos
        public double a, b, c;

        //Segundo membro -> Métodos                       Funções criadas dentro de uma classe são métodos

        public double Area()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

}
